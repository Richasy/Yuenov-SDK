using Newtonsoft.Json;
using System.Collections.Generic;
using Yuenov.SDK.Models.Discovery;

namespace Yuenov.SDK.Models.Response
{
    public class DiscoveryPageResponse
    {
        [JsonProperty("list")]
        public List<DiscoveryContainer> List { get; set; }
    }
}
