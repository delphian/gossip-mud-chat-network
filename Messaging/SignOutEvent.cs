using Newtonsoft.Json;
using System;

namespace BeforeOurTime.Gossip.Messaging
{
    [Serializable]
    public class SignOutEvent
    {
        [JsonProperty("name")]
        public string PlayerName { get; set; }

        [JsonProperty("game")]
        public string GameName { get; set; }
    }
}
