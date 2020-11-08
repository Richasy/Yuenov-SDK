using System;
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
            dict.Add("pageNum", "1");
            dict.Add("pageSize", "1");

            var result = await GetAsync<Response<DiscoveryPageResponse>>(API_DISCOVERY_PAGE, dict);
            return result;
        }

        /// <summary>
        /// 获取书籍的全部分类
        /// </summary>
        /// <returns></returns>
        public async Task<Response<ChannelResponse>> GetTotalCategoriesAsync()
        {
            var result = await GetAsync<Response<ChannelResponse>>(API_TOTAL_CATEGORIES);
            return result;
        }

        /// <summary>
        /// 获取书籍榜单信息
        /// </summary>
        /// <returns></returns>
        public async Task<Response<ChannelRankResponse>> GetTotalRanksAsync()
        {
            var result = await GetAsync<Response<ChannelRankResponse>>(API_TOTAL_RANKS);
            return result;
        }

        /// <summary>
        /// 获取每个榜单内的书籍列表
        /// </summary>
        /// <param name="channelId">频道号</param>
        /// <param name="rankId">榜单号</param>
        /// <param name="pageNum">请求第几页的数据，pageNum最小值为1</param>
        /// <param name="pageSize">请求每页多少条的数据</param>
        /// <returns></returns>
        public async Task<Response<RankResponse>> GetRankDetailAsync(int channelId, int rankId, int pageNum=1, int pageSize = 20)
        {
            if (channelId < 1 || rankId < 1 || pageNum < 1 || pageSize < 1)
                throw new ArgumentException("请输入有效的参数");

            var dict = new Dictionary<string, string>();
            dict.Add("channelId", channelId.ToString());
            dict.Add("rankId", rankId.ToString());
            dict.Add("pageNum", pageNum.ToString());
            dict.Add("pageSize", pageSize.ToString());

            var result = await GetAsync<Response<RankResponse>>(API_RANK_DETAIL, dict);
            return result;
        }

        /// <summary>
        /// 获取所有完本书籍信息
        /// </summary>
        /// <returns></returns>
        public async Task<Response<EndBookResponse>> GetEndBooksAsync()
        {
            var dict = new Dictionary<string, string>();
            dict.Add("pageNum", "1");
            dict.Add("pageSize", "1");

            var result = await GetAsync<Response<EndBookResponse>>(API_END_BOOK, dict);
            return result;
        }
    }
}
