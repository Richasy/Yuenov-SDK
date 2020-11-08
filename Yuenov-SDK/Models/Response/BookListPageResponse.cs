using Newtonsoft.Json;
using System.Collections.Generic;
using Yuenov_SDK.Models.Share;

namespace Yuenov_SDK.Models.Response
{
    public class BookListPageResponse : PageResponseBase
    {
        /// <summary>
        /// 搜索的结果书籍列表
        /// </summary>
        [JsonProperty("list")]
        public List<Book> List { get; set; }
    }
}
