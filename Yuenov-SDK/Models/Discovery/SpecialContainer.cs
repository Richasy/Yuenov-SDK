using Newtonsoft.Json;
using System.Collections.Generic;
using Yuenov_SDK.Models.Share;

namespace Yuenov_SDK.Models.Discovery
{
    public class SpecialContainer
    {
        /// <summary>
        /// 每个专题的名称
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// 专题号
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; set; }

        /// <summary>
        /// 书籍列表
        /// </summary>
        [JsonProperty("bookList")]
        public List<Book> BookList { get; set; }
    }
}
