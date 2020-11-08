using Newtonsoft.Json;
using System.Collections.Generic;
using Yuenov.SDK.Models.Discovery;

namespace Yuenov.SDK.Models.Response
{
    public class ChannelRankResponse
    {
        [JsonProperty("channels")]
        public List<RankContainer> Channels { get; set; }
    }
}
