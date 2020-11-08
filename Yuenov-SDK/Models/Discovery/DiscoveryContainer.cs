using Newtonsoft.Json;
using System.Collections.Generic;
using Yuenov_SDK.Enums;
using Yuenov_SDK.Models.Share;

namespace Yuenov_SDK.Models.Discovery
{
    public class DiscoveryContainer
    {
        /// <summary>
        /// 书籍列表
        /// </summary>
        [JsonProperty("bookList")]
        public List<Book> BookList { get; set; }

        /// <summary>
        /// 每个分类的名称
        /// </summary>
        [JsonProperty("categoryName")]
        public string CategoryName { get; set; }

        /// <summary>
        /// 每个分类的类型
        /// </summary>
        [JsonProperty("type")]
        public DiscoveryType Type { get; set; }

        /// <summary>
        /// 只有当type=CATEGORY时才有值表示书籍分类号
        /// </summary>
        [JsonProperty("categoryId")]
        public int CategoryId { get; set; }
    }
}
