using System.Runtime.Serialization;

namespace Yuenov_SDK.Enums
{
    public enum SortType
    {
        /// <summary>
        /// 按照最新的书籍进行排序
        /// </summary>
        [EnumMember(Value ="NEWEST")]
        Newest,

        /// <summary>
        /// 按照最火爆的书籍进行排序
        /// </summary>
        [EnumMember(Value = "HOT")]
        Hot,

        /// <summary>
        /// 筛选已完结的书籍
        /// </summary>
        [EnumMember(Value = "END")]
        End
    }
}
