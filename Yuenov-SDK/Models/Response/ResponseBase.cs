using Newtonsoft.Json;
using Yuenov_SDK.Enums;

namespace Yuenov_SDK.Models.Response
{
    public class Response<T>
    {
        [JsonProperty("result")]
        public ResponseResult Result { get; set; }

        [JsonProperty("data")]
        public T Data { get; set; }
    }

    /// <summary>
    /// HTTP返回的数据状态信息
    /// </summary>
    public class ResponseResult
    {
        /// <summary>
        /// HTTP返回的数据状态码（非HTTP状态码）
        /// </summary>
        [JsonProperty("code")]
        public ResultCode Code { get; set; }

        /// <summary>
        /// HTTP返回的数据状态说明
        /// </summary>
        [JsonProperty("message")]
        public string Message { get; set; }
    }
}
