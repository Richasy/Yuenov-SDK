using Newtonsoft.Json;

namespace Yuenov_SDK.Models.Share
{
    public class Chapter
    {
        /// <summary>
        /// 章节号
        /// </summary>
        [JsonProperty("id")]
        public long Id { get; set; }

        /// <summary>
        /// 章节名
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class ChapterDetail : Chapter
    {
        /// <summary>
        /// 章节内容
        /// </summary>
        [JsonProperty("content")]
        public string Content { get; set; }
    }
}
