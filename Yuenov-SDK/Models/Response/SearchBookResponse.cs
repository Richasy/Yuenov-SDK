using Newtonsoft.Json;
using System.Collections.Generic;
using Yuenov_SDK.Models.Share;

namespace Yuenov_SDK.Models.Response
{
    public class SearchBookResponse
    {
        /// <summary>
        /// 搜索的结果书籍列表
        /// </summary>
        [JsonProperty("list")]
        public List<Book> List { get; set; }

        /// <summary>
        /// 请求第几页数据
        /// </summary>
        [JsonProperty("pageNum")]
        public int PageNumber { get; set; }

        /// <summary>
        /// 请求每页多少条的数据
        /// </summary>
        [JsonProperty("pageSize")]
        public int PageSize { get; set; }

        /// <summary>
        /// 实际返回多少条数据
        /// </summary>
        [JsonProperty("total")]
        public int Total { get; set; }
    }
}
