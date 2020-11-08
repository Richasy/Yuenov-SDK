using Newtonsoft.Json;
using System.Collections.Generic;
using Yuenov_SDK.Models.Discovery;

namespace Yuenov_SDK.Models.Response
{
    public class DiscoveryPageResponse
    {
        [JsonProperty("list")]
        public List<DiscoveryContainer> List { get; set; }
    }
}
