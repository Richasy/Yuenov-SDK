using Newtonsoft.Json;
using Yuenov.SDK.Enums;

namespace Yuenov.SDK.Models.Discovery
{
    public class DiscoveryContainer : BookListContainerBase
    {
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
