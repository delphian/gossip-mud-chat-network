using Newtonsoft.Json;

namespace BeforeOurTime.Gossip.Messaging
{
    public interface IPayload
    {
        [JsonIgnore]
        string Type { get; }
    }
}
