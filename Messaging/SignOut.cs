using Newtonsoft.Json;
using System;

namespace BeforeOurTime.Gossip.Messaging
{
    [Serializable]
    public class SignOut : IPayload
    {
        [JsonIgnore]
        public string Type => "players/sign-out";

        [JsonProperty("name")]
        public string PlayerName { get; set; }
    }
}
