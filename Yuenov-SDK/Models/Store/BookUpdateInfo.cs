using Newtonsoft.Json;
using System;
using Yuenov.SDK.Enums;

namespace Yuenov.SDK.Models.Store
{
    public class BookUpdateInfo
    {
        /// <summary>
        /// 最新的章节号
        /// </summary>
        [JsonProperty("chapterId")]
        public long ChapterId { get; set; }

        /// <summary>
        /// 最新的章节名称
        /// </summary>
        [JsonProperty("chapterName")]
        public string ChapterName { get; set; }

        /// <summary>
        /// 书籍连载状态
        /// </summary>
        [JsonProperty("chapterStatus")]
        public ChapterStatus ChapterStatus { get; set; }

        /// <summary>
        /// 书籍最近更新时间
        /// </summary>
        [JsonProperty("time")]
        public long Time { get; set; }

        /// <summary>
        /// 获取时间戳对应的<see cref="DateTimeOffset"/>对象
        /// </summary>
        /// <returns></returns>
        public DateTime GetUpdateTime()
        {
            return DateTimeOffset.FromUnixTimeMilliseconds(Time).LocalDateTime;
        }
    }
}
