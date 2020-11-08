using Newtonsoft.Json;
using System.Collections.Generic;
using Yuenov_SDK.Models.Share;

namespace Yuenov_SDK.Models.Discovery
{
    public class ChannelResponse
    {
        [JsonProperty("channels")]
        public List<Channel> Channels { get; set; }
    }
}
