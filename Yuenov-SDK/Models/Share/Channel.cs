using Newtonsoft.Json;
using System.Collections.Generic;

namespace Yuenov.SDK.Models.Share
{
    public class Channel
    {
        /// <summary>
        ///  分类信息列表
        /// </summary>
        [JsonProperty("categories")]
        public List<Category> Categories { get; set; }

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

        public override bool Equals(object obj)
        {
            return obj is Channel channel &&
                   ChannelId == channel.ChannelId;
        }

        public override int GetHashCode()
        {
            return -1492472495 + ChannelId.GetHashCode();
        }
    }
}
