using Newtonsoft.Json;
using System.Collections.Generic;
using Yuenov_SDK.Models.Share;

namespace Yuenov_SDK.Models.Discovery
{
    public class EndBookContainer
    {
        /// <summary>
        /// 书籍分类号
        /// </summary>
        [JsonProperty("categoryId")]
        public int CategoryId { get; set; }

        /// <summary>
        /// 每个分类的名称
        /// </summary>
        [JsonProperty("categoryName")]
        public string CategoryName { get; set; }

        /// <summary>
        /// 书籍列表
        /// </summary>
        [JsonProperty("bookList")]
        public List<Book> BookList { get; set; }
    }
}
