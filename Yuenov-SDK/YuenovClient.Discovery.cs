using System.Collections.Generic;
using System.Threading.Tasks;
using Yuenov_SDK.Models.Discovery;
using Yuenov_SDK.Models.Response;

namespace Yuenov_SDK
{
    public partial class YuenovClient
    {
        /// <summary>
        /// 获取发现页面
        /// </summary>
        /// <returns></returns>
        public async Task<Response<DiscoveryPageResponse>> GetDiscoveryPageAsync()
        {
            var dict = new Dictionary<string, string>();
            dict.Add("pageNum", "2");
            dict.Add("pageSize", "1");

            var result = await GetAsync<Response<DiscoveryPageResponse>>(API_DISCOVERY_PAGE, dict);
            return result;
        }

        /// <summary>
        /// 书籍的全部分类
        /// </summary>
        /// <returns></returns>
        public async Task<Response<ChannelResponse>> GetTotalCategoriesAsync()
        {
            var result = await GetAsync<Response<ChannelResponse>>(API_TOTAL_CATEGORIES);
            if(result!=null && result.Result.Code == Enums.ResultCode.Success)
            {
                foreach (var item in result.Data.Channels)
                {
                    foreach (var cate in item.Categories)
                    {
                        for (int i = 0; i < cate.CoverImgs.Count; i++)
                        {
                            cate.CoverImgs[i] = _picUrl + cate.CoverImgs[i];
                        }
                    }
                }
            }
            return result;
        }
    }
}
