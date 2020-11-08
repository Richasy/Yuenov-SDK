using Newtonsoft.Json;
using System;
using Yuenov_SDK.Enums;

namespace Yuenov_SDK.Models.Share
{
    public class Book
    {
        /// <summary>
        /// 作者
        /// </summary>
        [JsonProperty("author")]
        public string Author { get; set; }

        /// <summary>
        /// 书籍号
        /// </summary>
        [JsonProperty("bookId")]
        public int BookId { get; set; }

        /// <summary>
        /// 书籍所属分类
        /// </summary>
        [JsonProperty("categoryName")]
        public string CategoryName { get; set; }

        /// <summary>
        /// 书籍连载状态
        /// <list type="bullet">
        /// <item>
        /// <c>END</c> : 书籍已完结
        /// </item>
        /// <item>
        /// <c>SERIALIZE</c> : 书籍连载中
        /// </item>
        /// </list>
        /// </summary>
        [JsonProperty("chapterStatus")]
        public ChapterStatus ChapterStatus { get; set; }

        /// <summary>
        /// 书籍的封面路径
        /// </summary>
        [JsonProperty("coverImg")]
        public string CoverImg { get; set; }

        /// <summary>
        /// 书籍内容介绍
        /// </summary>
        [JsonProperty("desc")]
        public string Description { get; set; }

        /// <summary>
        /// 书籍的名称
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; set; }

        /// <summary>
        /// 书籍的字数
        /// </summary>
        [JsonProperty("word")]
        public string Word { get; set; }

        public override bool Equals(object obj)
        {
            return obj is Book book &&
                   BookId == book.BookId;
        }

        public override int GetHashCode()
        {
            return -1590218067 + BookId.GetHashCode();
        }
    }
}
