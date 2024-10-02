using System;
using System.Threading.Tasks;
using System.Text.Json.Nodes;


namespace FourBits.Backend {

    class Message {

        public static readonly string PROP_SENDER = "sender";
        public static readonly string PROP_CONTENT = "content";

        /// <summary>
        /// Létrehoz egy példányt egy JSON objektumból.
        /// Vigyázz! Exceptiont dob, hogyha a <paramref name="node"/> tartalmilag nincs jól felépítve.
        /// </summary>
        public static Message FromJson(JsonNode? node) {
            if(node is null) throw new NullReferenceException("Node must not be null.");

            JsonObject obj = node.AsObject();
            return new Message(
                sender: obj[PROP_SENDER]!.AsValue().GetValue<string>(),
                content: obj[PROP_CONTENT]!.AsValue().GetValue<string>()
            );
        }

        /// <summary>
        /// Lásd: <see cref="FromJson(JsonNode?)"/>.
        /// </summary>
        public static async Task<Message> FromJson(System.IO.Stream stream) {
            return FromJson(await JsonNode.ParseAsync(stream));
        }


        /// <summary>
        /// JSONná alakítja ezt a beszélgetést.
        /// Ez a metódus szálbiztos.
        /// </summary>
        public JsonNode ToJson() {
            var obj = new JsonObject();

            obj.Add(PROP_SENDER, JsonValue.Create(Sender));
            obj.Add(PROP_CONTENT, JsonValue.Create(Content));

            return obj;
        }


        //


        /// <summary>Az üzenet feladója.</summary>
        public string Sender { get; set; }
        /// <summary>Az üzenet tartalma.</summary>
        public string Content { get; set; }


        public Message(string sender, string content) {
            this.Sender = sender;
            this.Content = content;
        }

    }

}
