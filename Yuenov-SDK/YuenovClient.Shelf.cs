using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Yuenov_SDK.Models.Response;
using Yuenov_SDK.Models.Shelf;

namespace Yuenov_SDK
{
    public partial class YuenovClient
    {
        /// <summary>
        /// 批量检查书籍是否有更新
        /// </summary>
        /// <param name="needCheckItems"></param>
        /// <returns></returns>
        public async Task<Response<List<CheckUpdateItem>>> CheckUpdateAsync(params CheckUpdateItem[] needCheckItems)
        {
            if (needCheckItems == null || needCheckItems.Length == 0)
                throw new ArgumentException("传入的查询不能为空");

            var result = await PostAsync<Response<List<CheckUpdateItem>>>(API_CHECK_UPDATE, needCheckItems);
            return result;
        }

        /// <summary>
        /// 根据关键词搜索书籍
        /// </summary>
        /// <param name="request">搜索请求</param>
        /// <returns></returns>
        public async Task<Response<SearchBookResponse>> SearchBookAsync(SearchBookRequest request)
        {
            if (!request.Check())
                throw new ArgumentException("请求参数无效");

            var dict = new Dictionary<string, string>();
            dict.Add("keyWord", request.Keyword);
            dict.Add("pageNum", request.PageNumber.ToString());
            dict.Add("pageSize", request.PageSize.ToString());

            var result = await GetAsync<Response<SearchBookResponse>>(API_SEARCH_BOOK, dict);
            if(result!=null && result.Data!=null && result.Data.List.Count > 0)
            {
                foreach (var book in result.Data.List)
                {
                    book.CoverImg = _picUrl + book.CoverImg;
                }
            }
            return result;
        }

        /// <summary>
        /// 根据关键词搜索书籍
        /// </summary>
        /// <param name="keyword">书籍关键词</param>
        /// <param name="pageNum">请求第几页的数据，最小值为1</param>
        /// <param name="pageSize">请求每页多少条的数据</param>
        /// <returns></returns>
        public async Task<Response<SearchBookResponse>> SearchBookAsync(string keyword, int pageNum=1,int pageSize = 20)
        {
            var request = new SearchBookRequest(keyword, pageNum, pageSize);
            return await SearchBookAsync(request);
        }
    }
}
