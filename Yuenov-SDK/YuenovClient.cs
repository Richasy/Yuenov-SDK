using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Yuenov_SDK
{
    public partial class YuenovClient
    {
        private static string _baseUrl;
        private static string _picUrl;
        private static string _baseRoute = "/app/open/api";
        internal HttpClient _httpClient;

        /// <summary>
        /// 创建Yuenov客户端实例
        /// </summary>
        public YuenovClient()
        {
            _baseUrl = "http://yuenov.com:15555";
            _picUrl = "http://pt.yuenov.com:15555";
            _httpClient = new HttpClient();
        }

        /// <summary>
        /// 创建Yuenov客户端实例
        /// </summary>
        /// <param name="baseProtocal">指定端口</param>
        public YuenovClient(string baseProtocal) : this()
        {
            _baseUrl = $"http://yuenov.com:{baseProtocal}";
            _picUrl = $"http://pt.yuenov.com:{baseProtocal}";
        }

        /// <summary>
        /// 创建Yuenov客户端实例
        /// </summary>
        /// <param name="baseUrl">指定基础地址</param>
        /// <param name="pictureUrl">指定图片地址</param>
        public YuenovClient(string baseUrl, string pictureUrl) : this()
        {
            _baseUrl = baseUrl;
            _picUrl = pictureUrl;
        }

        /// <summary>
        /// 发送POST请求
        /// </summary>
        /// <typeparam name="T">需要转换的目标对象类型</typeparam>
        /// <param name="url">请求地址</param>
        /// <param name="postData">需要POST的数据</param>
        /// <returns></returns>
        internal async Task<T> PostAsync<T>(string url, object postData)
        {
            string json = JsonConvert.SerializeObject(postData);
            var httpContent = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await _httpClient.PostAsync(url, httpContent);
            response.EnsureSuccessStatusCode();
            string result = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<T>(result);
        }

        /// <summary>
        /// 发送GET请求
        /// </summary>
        /// <typeparam name="T">需要转换的目标对象类型</typeparam>
        /// <param name="url">请求地址</param>
        /// <param name="parameters">请求参数</param>
        /// <returns></returns>
        internal async Task<T> GetAsync<T>(string url, Dictionary<string, string> parameters = null)
        {
            string query = "";
            if (parameters != null && parameters.Count > 0)
            {
                query = "?" + string.Join("&", parameters.Select(p => p.Key + "=" + WebUtility.UrlEncode(p.Value)));
                url += query;
            }
            var response = await _httpClient.GetAsync(url);
            response.EnsureSuccessStatusCode();
            string result = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<T>(result);
        }

        /// <summary>
        /// 获取图片地址
        /// </summary>
        /// <param name="path">图片路径</param>
        /// <returns></returns>
        public string GetImageUrl(string path)
        {
            return _picUrl + path;
        }

        /// <summary>
        /// 获取枚举定义的对应值
        /// </summary>
        /// <param name="enum">枚举</param>
        /// <returns></returns>
        internal string GetEnumMemberValue(Enum @enum)
        {
            return @enum.GetType()
                    .GetTypeInfo()
                    .DeclaredMembers
                    .SingleOrDefault(x => x.Name == @enum.ToString())
                    ?.GetCustomAttribute<EnumMemberAttribute>(false)
                    ?.Value;
        }
    }
}
