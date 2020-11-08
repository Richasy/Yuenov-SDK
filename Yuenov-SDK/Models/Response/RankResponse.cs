using Newtonsoft.Json;
using System.Collections.Generic;
using Yuenov_SDK.Models.Share;

namespace Yuenov_SDK.Models.Response
{
    public class RankResponse : PageResponseBase
    {
        /// <summary>
        /// 榜单书籍列表
        /// </summary>
        [JsonProperty("list")]
        public List<Book> List { get; set; }
    }
}
