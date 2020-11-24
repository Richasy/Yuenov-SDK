using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Yuenov.SDK.Models.Response;
using Yuenov.SDK.Models.Shelf;

namespace Yuenov.SDK
{
    public sealed partial class YuenovClient
    {
        /// <summary>
        /// 批量检查书籍是否有更新
        /// </summary>
        /// <param name="needCheckItems"></param>
        /// <returns></returns>
        public async Task<Response<UpdateCheckResponse>> CheckUpdateAsync(params CheckUpdateItem[] needCheckItems)
        {
            if (needCheckItems == null || needCheckItems.Length == 0)
                throw new ArgumentException("传入的查询不能为空");

            var obj = new
            {
                books = needCheckItems
            };

            var result = await PostAsync<Response<UpdateCheckResponse>>(API_CHECK_UPDATE, obj);
            return result;
        }

        /// <summary>
        /// 根据关键词搜索书籍
        /// </summary>
        /// <param name="keyword">书籍关键词</param>
        /// <param name="pageNum">请求第几页的数据，最小值为1</param>
        /// <param name="pageSize">请求每页多少条的数据</param>
        /// <returns></returns>
        public async Task<Response<BookListPageResponse>> SearchBookAsync(string keyword, int pageNum=1,int pageSize = 20)
        {
            if(string.IsNullOrEmpty(keyword) || pageNum<1 || pageSize<1)
                throw new ArgumentException("请求参数无效");

            var dict = new Dictionary<string, string>();
            dict.Add("keyWord", keyword);
            dict.Add("pageNum", pageNum.ToString());
            dict.Add("pageSize", pageSize.ToString());

            var result = await GetAsync<Response<BookListPageResponse>>(API_SEARCH_BOOK, dict);
            return result;
        }
    }
}
