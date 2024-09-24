using System;
using System.Net;
using System.Threading;
using System.Threading.Tasks;


namespace FourBits {

    class Program {

        static readonly int PORT = 8084;

        static void Main(string[] args) {
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
                    Console.WriteLine($"Handling {context.Request.RemoteEndPoint}");
                    await HandleRequest(context);
                }
                listener.Stop();
            }
        }

        static async Task HandleRequest(HttpListenerContext context) {
            string responseString = "<html><body> Hello world!</body></html>";
            byte[] buffer = System.Text.Encoding.UTF8.GetBytes(responseString);

            HttpListenerResponse response = context.Response;
            response.ContentLength64 = buffer.Length;

            System.IO.Stream output = response.OutputStream;
            await output.WriteAsync(buffer, 0, buffer.Length);
            output.Close();
        }

    }

}
