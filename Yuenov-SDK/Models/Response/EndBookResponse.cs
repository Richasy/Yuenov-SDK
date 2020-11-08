using Newtonsoft.Json;
using System.Collections.Generic;
using Yuenov_SDK.Models.Discovery;

namespace Yuenov_SDK.Models.Response
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
