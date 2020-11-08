using System.Runtime.Serialization;

namespace Yuenov_SDK.Enums
{
    public enum ChapterStatus
    {
        /// <summary>
        /// 书籍连载中
        /// </summary>
        [EnumMember(Value = "SERIALIZE")]
        Serialize,

        /// <summary>
        /// 书籍已完结
        /// </summary>
        [EnumMember(Value = "END")]
        End
    }
}
