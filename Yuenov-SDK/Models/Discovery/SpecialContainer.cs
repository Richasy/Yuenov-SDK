using Newtonsoft.Json;

namespace Yuenov.SDK.Models.Discovery
{
    public class SpecialContainer : BookListContainerBase
    {
        /// <summary>
        /// 每个专题的名称
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// 专题号
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; set; }
    }
}
