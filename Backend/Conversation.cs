using System;
using System.Threading.Tasks;
using System.Text.Json.Nodes;
using System.Collections.Generic;


namespace FourBits.Backend {

    class Conversation {

        public struct Item {
            public long id;
            public long unixTimestamp;
            public Message message;
        }


        public static long GetUnixTimestamp(DateTime time) {
            return (long)time.Subtract(new DateTime(1970, 1, 1)).TotalSeconds;
        }

        class Comparer : IComparer<Item> {
            public int Compare(Item x, Item y) {
                return x.unixTimestamp.CompareTo(y.unixTimestamp);
            }
        }

        static readonly Comparer comparer = new Comparer();


        public static readonly string PROP_MESSAGES = "messages";
        public static readonly string PROP_ID = "id";
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

                long id = msgObj[PROP_ID]!.AsValue().GetValue<long>();
                long timestamp = msgObj[PROP_TIMESTAMP]!.AsValue().GetValue<long>();
                Message message = Message.FromJson(msgObj[PROP_TIMESTAMP]!.AsObject());

                var item = new Item() {
                    id = id,
                    unixTimestamp = timestamp,
                    message = message
                };
                inst.InternalInsertMessage(item);
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
        /// <param name="minimumId">Csak az ekkora vagy nagyobb id-jű üzeneteket tartalmazza. Ha nincs megadva, akkor mindegyik benne lesz.</param>
        public JsonNode ToJson(int minimumId = -1) {
            var obj = new JsonObject();

            JsonArray msgs = new JsonArray();

            foreach(Item item in CloneMessages()) {
                if(item.id < minimumId) continue;

                JsonObject msgObj = new JsonObject();

                msgObj.Add(PROP_ID, JsonValue.Create(item.id));
                msgObj.Add(PROP_TIMESTAMP, JsonValue.Create(item.unixTimestamp));
                msgObj.Add(PROP_MESSAGE, item.message.ToJson());

                msgs.Add(msgObj);
            }

            obj.Add(PROP_MESSAGES, msgs);

            return obj;
        }


        //


        private List<Item> _messages;
        /// <summary>Vigyázz! Ezt a listát más threadek bármikor módosíthatják. Valószínűleg a <see cref="CloneMessages"/>t akarod használni.</summary>
        public IList<Item> Messages => _messages;

        /// <summary>Szálbiztosan lemásolja a <see cref="Messages"/>t egy új listába, és visszaadja azt.</summary>
        public IList<Item> CloneMessages() {
            lock(_messages) {
                return new List<Item>(_messages);
            }
        }


        public Conversation() {
            _messages = new List<Item>();
        }


        private void InternalInsertMessage(Item item) {
            int index = _messages.BinarySearch(item, comparer);
            if(index < 0) index = ~index;

            _messages.Insert(index, item);
        }

        /// <summary>
        /// Üzenetet szúr be a <see cref="Messages"/>hez a megadott időbélyeggel.
        /// Ez a metódus szálbiztos.
        /// </summary>
        public void InsertMessage(Message msg, DateTime timestamp) {
            long unix = GetUnixTimestamp(timestamp);

            lock(_messages) {
                Item item = new Item() {
                    id = Messages.Count + 1,
                    unixTimestamp = unix,
                    message = msg
                };

                InternalInsertMessage(item);
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
