using Newtonsoft.Json;
using System.Collections.Generic;
using Yuenov_SDK.Models.Share;

namespace Yuenov_SDK.Models.Response
{
    public class ChapterListResponse
    {
        [JsonProperty("list")]
        public List<ChapterDetail> List { get; set; }
    }
}
