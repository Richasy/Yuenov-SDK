using Newtonsoft.Json;
using System.Collections.Generic;
using Yuenov.SDK.Models.Share;

namespace Yuenov.SDK.Models.Response
{
    public class ChapterListResponse
    {
        [JsonProperty("list")]
        public List<ChapterDetail> List { get; set; }
    }
}
