using Newtonsoft.Json;
using System.Collections.Generic;

namespace Yuenov_SDK.Models.Discovery
{
    public class DiscoveryPageResponse
    {
        [JsonProperty("list")]
        public List<DiscoveryContainer> List { get; set; }
    }
}
