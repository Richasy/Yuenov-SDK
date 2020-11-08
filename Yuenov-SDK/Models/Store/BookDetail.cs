using Newtonsoft.Json;
using System.Collections.Generic;
using Yuenov_SDK.Models.Share;

namespace Yuenov_SDK.Models.Store
{
    public class BookDetail : Book
    {
        /// <summary>
        /// 书籍更新信息
        /// </summary>
        [JsonProperty("update")]
        public BookUpdateInfo Update { get; set; }

        /// <summary>
        /// 相关书籍推荐列表
        /// </summary>
        [JsonProperty("recommend")]
        public List<Book> Recommend { get; set; }
    }
}
