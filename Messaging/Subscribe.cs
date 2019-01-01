using Newtonsoft.Json;
using System;

namespace BeforeOurTime.Gossip.Messaging
{
    [Serializable]
    public class Subscribe : IPayload
    {
        [JsonIgnore]
        public string Type => "channels/subscribe";

        [JsonProperty("channel")]
        public string Channel { get; set; }
    }
}
