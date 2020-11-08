using Newtonsoft.Json;
using System.Collections.Generic;
using Yuenov.SDK.Models.Share;

namespace Yuenov.SDK.Models.Store
{
    public class BookChapters : Book
    {
        /// <summary>
        /// 书籍的目录列表
        /// </summary>
        [JsonProperty("chapters")]
        public List<Chapter> Chapters { get; set; }
    }
}
