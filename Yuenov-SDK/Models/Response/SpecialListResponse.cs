using Newtonsoft.Json;
using System.Collections.Generic;
using Yuenov.SDK.Models.Discovery;

namespace Yuenov.SDK.Models.Response
{
    public class SpecialListResponse
    {
        [JsonProperty("specialList")]
        public List<SpecialContainer> SpecialList { get; set; }
    }
}
