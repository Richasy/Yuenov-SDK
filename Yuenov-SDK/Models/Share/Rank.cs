using Newtonsoft.Json;
using System.Collections.Generic;

namespace Yuenov_SDK.Models.Share
{
    public class Rank
    {
        /// <summary>
        /// 榜单号
        /// </summary>
        [JsonProperty("rankId")]
        public int RankId { get; set; }

        /// <summary>
        /// 榜单名
        /// </summary>
        [JsonProperty("rankName")]
        public string RankName { get; set; }

        /// <summary>
        /// 榜单的封面列表，包含该榜单排名前三书籍的封面路径
        /// </summary>
        [JsonProperty("coverImgs")]
        public List<string> CoverImgs { get; set; }

        public override bool Equals(object obj)
        {
            return obj is Rank rank &&
                   RankId == rank.RankId;
        }

        public override int GetHashCode()
        {
            return 1451011258 + RankId.GetHashCode();
        }
    }
}
