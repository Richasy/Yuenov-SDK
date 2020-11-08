using Newtonsoft.Json;
using System.Collections.Generic;
using Yuenov.SDK.Models.Discovery;

namespace Yuenov.SDK.Models.Response
{
    public class EndBookResponse:PageResponseBase
    {
        /// <summary>
        /// 全部完结书籍的分类列表
        /// </summary>
        [JsonProperty("list")]
        public List<EndBookContainer> List { get; set; }
    }
}
