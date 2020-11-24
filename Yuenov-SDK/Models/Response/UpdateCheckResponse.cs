using Newtonsoft.Json;
using System.Collections.Generic;
using Yuenov.SDK.Models.Shelf;

namespace Yuenov.SDK.Models.Response
{
    public class UpdateCheckResponse
    {
        /// <summary>
        /// 需要更新的书籍列表
        /// </summary>
        [JsonProperty("updateList")]
        public List<CheckUpdateItem> UpdateList { get; set; }
    }
}
