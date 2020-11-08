using Newtonsoft.Json;

namespace Yuenov.SDK.Models.Response
{
    public class PageResponseBase
    {
        /// <summary>
        /// 请求第几页的数据，pageNum最小值为1
        /// </summary>
        [JsonProperty("pageNum")]
        public int PageNumber { get; set; }

        /// <summary>
        /// 请求每页多少条的数据
        /// </summary>
        [JsonProperty("pageSize")]
        public int PageSize { get; set; }

        /// <summary>
        /// 总共有多少条数据
        /// </summary>
        [JsonProperty("total")]
        public int Total { get; set; }
    }
}
