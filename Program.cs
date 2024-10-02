using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text.Json.Nodes;
using System.Threading;
using System.Threading.Tasks;
using FourBits.Backend;


namespace FourBits {

    /// <summary>
    /// Akkor van, ha olyan endpointot kértek, amilyen nincs.
    /// </summary>
    class NotFoundException : Exception {
        // semmi
    }

    class Program {

        static readonly int PORT = 8084;
        static readonly string WWW_DIR = "www";

        static byte[] EncodeString(string str) => System.Text.Encoding.UTF8.GetBytes(str);


        static Conversation conversation = new Conversation();


        static void Main(string[] args) {
            conversation.InsertMessage(new Message("Béla", "Szia"));
            Thread.Sleep(2000);
            conversation.InsertMessage(new Message("Béla 2.0", "Üdv"));

            Console.WriteLine(conversation.ToJson().ToJsonString());

            var listenTask = Task.Run( () => ListenTask(CancellationToken.None) );
            listenTask.Wait();
        }

        static async Task ListenTask(CancellationToken cancelToken) {
            using(var listener = new HttpListener()) {
                listener.Prefixes.Add($"http://127.0.0.1:{PORT}/");

                listener.Start();
                Console.WriteLine($"{nameof(HttpListener)} now listening");
                while(true) {
                    HttpListenerContext context = await listener.GetContextAsync();
                    try {
                        Console.WriteLine($"Handling {context.Request.RemoteEndPoint}");
                        await HandleRequest(context);
                    } catch(Exception e) {
                        Console.WriteLine($"Exception while handling request: {e}");
                        try {
                            context.Response.StatusCode = 500;
                        } finally {
                            context.Response.Close();
                        }
                    }
                }
                listener.Stop();
            }
        }

        static async Task HandleRequest(HttpListenerContext context) {
            string path = System.Web.HttpUtility.UrlDecode(context.Request.Url?.AbsolutePath ?? "/");
            if(path.Contains("..")) context.Response.Abort(); // Szűrjük ki a gonosz path traversaleket

            Console.WriteLine($"{context.Request.RemoteEndPoint} -{context.Request.HttpMethod}-> {path}");

            if(path == "/") {
                await SendFile(context.Response, $"{WWW_DIR}/index.html");
            } else if(File.Exists($"{WWW_DIR}{path}")) {
                await SendFile(context.Response, $"{WWW_DIR}{path}");
            } else {
                await ApiCall(context, path);
            }

            context.Response.Close();
        }


        static async Task SendFile(HttpListenerResponse response, string path) {

            // TODO streamreaderrel beolvasni a fájlt és azt írni a bufferbe (próbáld asynccel)
            string content = ReadFile(path).Result;
            byte[] buffer = EncodeString(content);

            await response.OutputStream.WriteAsync(buffer);
            response.OutputStream.Close();
        }
        static async Task<string> ReadFile(string path) {
            using(var reader = new StreamReader(path)) {
                return await reader.ReadToEndAsync();
            }
        }
        static async Task ApiCall(HttpListenerContext context, string path) {
            try {
                switch(context.Request.HttpMethod) {
                    case "GET":
                        JsonNode result = ApiGet(path, context.Request.QueryString);
                        await context.Response.OutputStream.WriteAsync(
                            EncodeString(result.ToJsonString())
                        );
                        context.Response.StatusCode = 200;
                        break;

                    case "POST":
                        JsonNode? payload = await JsonNode.ParseAsync(context.Request.InputStream);

                        ApiPost(path, context.Request.QueryString, payload);


                        context.Response.StatusCode = 200;
                        break;

                    default:
                        context.Response.StatusCode = 405;
                        break;
                }
            } catch(NotFoundException) {
                await context.Response.OutputStream.WriteAsync(EncodeString("Not found"));
                context.Response.StatusCode = 404;
            }
        }

        static JsonNode ApiGet(string path, System.Collections.Specialized.NameValueCollection query) {
            switch(path) {
                case "/messages":
                    if(query == null) {
                        return conversation.ToJson(-1);
                    }
                    else {
                        return conversation.ToJson(int.Parse(query["since"]));
                    }
            }

            throw new NotFoundException();
        }

        static void ApiPost(string path, System.Collections.Specialized.NameValueCollection query, JsonNode? json) {
            switch(path) {
                case "/message":
                    if(json != null) {
                        Conversation.FromJson(json);
                    }
                    return;
            }

            throw new NotFoundException();
        }
    }
}
