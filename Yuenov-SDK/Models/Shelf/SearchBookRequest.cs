using Newtonsoft.Json;

namespace Yuenov_SDK.Models.Shelf
{
    public struct SearchBookRequest
    {
        /// <summary>
        /// 书籍关键词
        /// </summary>
        [JsonProperty("keyWord")]
        public string Keyword { get; internal set; }

        /// <summary>
        /// 请求第几页的数据，<c>PageNumber</c>最小值为1
        /// </summary>
        [JsonProperty("pageNum")]
        public int PageNumber { get; internal set; }

        /// <summary>
        /// 请求每页多少条的数据
        /// </summary>
        [JsonProperty("pageSize")]
        public int PageSize { get; internal set; }

        public SearchBookRequest(string keyword, int pageNum = 1, int pageSize = 20)
        {
            Keyword = keyword;
            PageNumber = pageNum < 1 ? 1 : pageNum;
            PageSize = pageSize < 1 ? 1 : pageSize;
        }

        /// <summary>
        /// 检查自身数据有效性
        /// </summary>
        /// <returns>检查结果</returns>
        public bool Check()
        {
            if (string.IsNullOrEmpty(Keyword?.Trim())
               || PageNumber < 1
               || PageSize < 1)
                return false;
            return true;
        }
    }
}
