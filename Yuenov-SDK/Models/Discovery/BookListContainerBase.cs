using Newtonsoft.Json;
using System.Collections.Generic;
using Yuenov.SDK.Models.Share;

namespace Yuenov.SDK.Models.Discovery
{
    public class BookListContainerBase
    {
        /// <summary>
        /// 书籍列表
        /// </summary>
        [JsonProperty("bookList")]
        public List<Book> BookList { get; set; }
    }
}
