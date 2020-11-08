using Newtonsoft.Json;
using System.Collections.Generic;
using Yuenov_SDK.Models.Discovery;

namespace Yuenov_SDK.Models.Response
{
    public class SpecialListResponse
    {
        [JsonProperty("specialList")]
        public List<SpecialContainer> SpecialList { get; set; }
    }
}
