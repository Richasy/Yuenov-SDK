﻿using Newtonsoft.Json;
using System.Collections.Generic;
using Yuenov_SDK.Models.Discovery;

namespace Yuenov_SDK.Models.Response
{
    public class ChannelRankResponse
    {
        [JsonProperty("channels")]
        public List<RankContainer> Channels { get; set; }
    }
}
