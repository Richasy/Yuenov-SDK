using Newtonsoft.Json;

namespace Yuenov_SDK.Models.Shelf
{
    public class CheckUpdateItem
    {
        /// <summary>
        /// 需要检查更新的书籍号
        /// </summary>
        [JsonProperty("bookId")]
        public int BookId { get; set; }

        /// <summary>
        /// 需要检查更新的书籍最后一章的章节号
        /// </summary>
        [JsonProperty("chapterId")]
        public long ChapterId { get; set; }
        public CheckUpdateItem()
        {

        }

        public CheckUpdateItem(int bookId, long chapterId)
        {
            BookId = bookId;
            ChapterId = chapterId;
        }

        public override bool Equals(object obj)
        {
            return obj is CheckUpdateItem request &&
                   BookId == request.BookId &&
                   ChapterId == request.ChapterId;
        }

        public override int GetHashCode()
        {
            int hashCode = -437730420;
            hashCode = hashCode * -1521134295 + BookId.GetHashCode();
            hashCode = hashCode * -1521134295 + ChapterId.GetHashCode();
            return hashCode;
        }
    }
}
