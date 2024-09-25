using System;
using System.Threading.Tasks;
using System.Text.Json.Nodes;
using System.Collections.Generic;


namespace FourBits.Backend {

    class Conversation {

        public static long GetUnixTimestamp(DateTime time) {
            return (long)time.Subtract(new DateTime(1970, 1, 1)).TotalSeconds;
        }

        class Comparer : IComparer<(long timestamp, Message _)> {
            public int Compare((long timestamp, Message _) x, (long timestamp, Message _) y) {
                return x.timestamp.CompareTo(y.timestamp);
            }
        }

        static readonly Comparer comparer = new Comparer();


        public static readonly string PROP_MESSAGES = "messages";
        public static readonly string PROP_TIMESTAMP = "timestamp";
        public static readonly string PROP_MESSAGE = "message";

        /// <summary>
        /// Létrehoz egy példányt egy JSON objektumból.
        /// Vigyázz! Exceptiont dob, hogyha a <paramref name="node"/> tartalmilag nincs jól felépítve.
        /// </summary>
        public static Conversation FromJson(JsonNode? node) {
            if(node is null) throw new NullReferenceException("Node must not be null.");

            var inst = new Conversation();

            JsonObject obj = node.AsObject();
            JsonArray array = obj[PROP_MESSAGES]!.AsArray();

            foreach(JsonNode? elem in array) {
                JsonObject msgObj = (JsonObject)elem!;

                long timestamp = msgObj[PROP_TIMESTAMP]!.AsValue().GetValue<long>();
                Message message = Message.FromJson(msgObj[PROP_TIMESTAMP]!.AsObject());

                inst.InternalInsertMessage((timestamp, message), timestamp);
            }

            return inst;
        }

        /// <summary>
        /// Lásd: <see cref="FromJson(JsonNode?)"/>.
        /// </summary>
        public static async Task<Conversation> FromJson(System.IO.Stream stream) {
            return FromJson(await JsonNode.ParseAsync(stream));
        }


        /// <summary>
        /// JSONná alakítja ezt a beszélgetést.
        /// Ez a metódus szálbiztos.
        /// </summary>
        public JsonNode ToJson() {
            var obj = new JsonObject();

            JsonArray msgs = new JsonArray();

            foreach((long timestamp, Message message) tuple in CloneMessages()) {
                JsonObject msgObj = new JsonObject();

                msgObj.Add(PROP_TIMESTAMP, JsonValue.Create(tuple.timestamp));
                msgObj.Add(PROP_MESSAGE, tuple.message.ToJson());

                msgs.Add(msgObj);
            }

            obj.Add(PROP_MESSAGES, msgs);

            return obj;
        }


        //


        /// <summary>Vigyázz! Ezt a listát más threadek bármikor módosíthatják. Valószínűleg a <see cref="CloneMessages"/>t akarod használni.</summary>
        private List<(long timestamp, Message message)> _messages;
        public IList<(long timestamp, Message message)> Messages => _messages;

        /// <summary>Szálbiztosan lemásolja a <see cref="Messages"/>t egy új listába, és visszaadja azt.</summary>
        public IList<(long timestamp, Message message)> CloneMessages() {
            lock(_messages) {
                return new List<(long timestamp, Message message)>(_messages);
            }
        }


        public Conversation() {
            _messages = new List<(long, Message)>();
        }


        private void InternalInsertMessage((long timestamp, Message message) tuple, long unix) {
            int index = _messages.BinarySearch(tuple, comparer);
            if(index < 0) index = ~index;

            _messages.Insert(index, tuple);
        }

        /// <summary>
        /// Üzenetet szúr be a <see cref="Messages"/>hez a megadott időbélyeggel.
        /// Ez a metódus szálbiztos.
        /// </summary>
        public void InsertMessage(Message msg, DateTime timestamp) {
            long unix = GetUnixTimestamp(timestamp);
            (long, Message) tuple = (unix, msg);

            lock(_messages) {
                InternalInsertMessage(tuple, unix);
            }
        }

        /// <summary>
        /// Üzenetet szúr be a <see cref="Messages"/>hez mostani időbélyeggel.
        /// Ez a metódus szálbiztos.
        /// </summary>
        public void InsertMessage(Message msg) {
            InsertMessage(msg, DateTime.UtcNow);
        }

    }

}
