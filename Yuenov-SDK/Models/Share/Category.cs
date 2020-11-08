using Newtonsoft.Json;
using System.Collections.Generic;

namespace Yuenov_SDK.Models.Share
{
    public class Category
    {
        /// <summary>
        /// 分类号
        /// </summary>
        [JsonProperty("categoryId")]
        public int CategoryId { get; set; }

        /// <summary>
        /// 分类名
        /// </summary>
        [JsonProperty("categoryName")]
        public string CategoryName { get; set; }

        /// <summary>
        /// 分类的封面列表，包含该分类排名前三书籍的封面URL
        /// </summary>
        [JsonProperty("coverImgs")]
        public List<string> CoverImgs { get; set; }

        public override bool Equals(object obj)
        {
            return obj is Category category &&
                   CategoryId == category.CategoryId;
        }

        public override int GetHashCode()
        {
            return -2133319772 + CategoryId.GetHashCode();
        }
    }
}
