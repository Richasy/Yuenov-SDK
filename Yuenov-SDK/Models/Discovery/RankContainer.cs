using Newtonsoft.Json;
using System.Collections.Generic;
using Yuenov_SDK.Models.Share;

namespace Yuenov_SDK.Models.Discovery
{
    public class RankContainer
    {
        /// <summary>
        /// 榜单信息列表
        /// </summary>
        [JsonProperty("ranks")]
        public List<Rank> Ranks { get; set; }

        /// <summary>
        /// 频道号
        /// </summary>
        [JsonProperty("channelId")]
        public int ChannelId { get; set; }

        /// <summary>
        /// 频道名称
        /// </summary>
        [JsonProperty("channelName")]
        public string ChannelName { get; set; }
    }
}
