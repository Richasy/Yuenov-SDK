using Newtonsoft.Json;
using System.Collections.Generic;
using Yuenov.SDK.Models.Share;

namespace Yuenov.SDK.Models.Response
{
    public class ChannelResponse
    {
        [JsonProperty("channels")]
        public List<Channel> Channels { get; set; }
    }
}
