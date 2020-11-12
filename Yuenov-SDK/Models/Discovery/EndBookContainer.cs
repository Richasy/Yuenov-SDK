using Newtonsoft.Json;

namespace Yuenov.SDK.Models.Discovery
{
    public class EndBookContainer : BookListContainerBase
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
    }
}
