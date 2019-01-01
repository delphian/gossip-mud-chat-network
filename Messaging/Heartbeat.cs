using Newtonsoft.Json;
using System;

namespace BeforeOurTime.Gossip.Messaging
{
    [Serializable]
    public class Heartbeat : IPayload
    {
        [JsonIgnore]
        public string Type => "heartbeat";
    }
}
