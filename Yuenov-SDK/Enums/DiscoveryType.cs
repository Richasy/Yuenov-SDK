using System.Runtime.Serialization;

namespace Yuenov_SDK.Enums
{
    public enum DiscoveryType
    {
        /// <summary>
        /// 大家都在看
        /// </summary>
        [EnumMember(Value ="READ_MOST")]
        ReadMost,

        /// <summary>
        /// 最近更新
        /// </summary>
        [EnumMember(Value = "RECENT_UPDATE")]
        RecentUpdate,

        /// <summary>
        /// 书籍分类
        /// </summary>
        [EnumMember(Value = "CATEGORY")]
        Category
    }
}
