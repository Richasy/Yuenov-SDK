using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Yuenov.SDK.Enums;
using Yuenov.SDK.Models.Response;
using Yuenov.SDK.Models.Store;

namespace Yuenov.SDK
{
    public sealed partial class YuenovClient
    {
        /// <summary>
        /// 获取某个分类下所有的书籍
        /// </summary>
        /// <param name="categoryId">书籍所属的分类号</param>
        /// <param name="type">分类书籍排序与筛选规则</param>
        /// <param name="channelId">某个频道下的分类书籍</param>
        /// <param name="pageNum">请求第几页的数据，pageNum最小值为1</param>
        /// <param name="pageSize">请求每页多少条的数据</param>
        /// <returns></returns>
        public async Task<Response<BookListPageResponse>> GetCategoryDetailAsync(int categoryId, SortType type = SortType.Newest, int channelId = 0, int pageNum = 1, int pageSize = 20)
        {
            if (categoryId < 1 || pageNum < 1 || pageSize < 1)
                throw new ArgumentException("请输入有效的参数");

            var dict = new Dictionary<string, string>();
            dict.Add("categoryId", categoryId.ToString());
            dict.Add("pageNum", pageNum.ToString());
            dict.Add("pageSize", pageSize.ToString());
            dict.Add("orderBy", GetEnumMemberValue(type));
            if (channelId > 0)
                dict.Add("channelId", channelId.ToString());

            var result = await GetAsync<Response<BookListPageResponse>>(API_CATEGORY_DETAIL, dict);
            return result;
        }

        /// <summary>
        /// 获取书籍详情
        /// </summary>
        /// <param name="bookId">书籍号</param>
        /// <returns></returns>
        public async Task<Response<BookDetail>> GetBookDetailAsync(int bookId)
        {
            if (bookId < 1)
                throw new ArgumentException("请输入有效的参数");

            var dict = new Dictionary<string, string>();
            dict.Add("bookId", bookId.ToString());

            var result = await GetAsync<Response<BookDetail>>(API_BOOK_DETAIL, dict);
            return result;
        }

        /// <summary>
        /// 获取在书籍详情中的推荐列表和换一换
        /// </summary>
        /// <param name="bookId">书籍所属的分类号</param>
        /// <param name="pageNum">请求第几页的数据，pageNum最小值为1</param>
        /// <param name="pageSize">请求每页多少条的数据</param>
        /// <returns></returns>
        public async Task<Response<BookListPageResponse>> GetCategoryDetailAsync(int bookId, int pageNum = 1, int pageSize = 20)
        {
            if (bookId < 1 || pageNum < 1 || pageSize < 1)
                throw new ArgumentException("请输入有效的参数");

            var dict = new Dictionary<string, string>();
            dict.Add("bookId", bookId.ToString());
            dict.Add("pageNum", pageNum.ToString());
            dict.Add("pageSize", pageSize.ToString());

            var result = await GetAsync<Response<BookListPageResponse>>(API_BOOK_RECOMMEND, dict);
            return result;
        }

        /// <summary>
        /// 获取书籍全部或部分目录信息
        /// </summary>
        /// <param name="bookId">书籍号</param>
        /// <param name="chapterId">从第几章开始请求目录信息，如果不传请求全部的目录信息</param>
        /// <returns></returns>
        public async Task<Response<BookChapters>> GetBookChaptersAsync(int bookId, long chapterId = 0)
        {
            if (bookId < 1)
                throw new ArgumentException("请输入有效的参数");

            var dict = new Dictionary<string, string>();
            dict.Add("bookId", bookId.ToString());
            if (chapterId > 0)
                dict.Add("chaperId", chapterId.ToString());

            var result = await GetAsync<Response<BookChapters>>(API_CHAPTER_LIST, dict);
            return result;
        }

        /// <summary>
        /// 下载章节内容，目前开放接口不支持批量下载
        /// </summary>
        /// <param name="bookId">下载的书籍号</param>
        /// <param name="chapters">下载的章节号列表</param>
        /// <returns></returns>
        public async Task<Response<ChapterListResponse>> DownloadChaptersAsync(int bookId, params long[] chapters)
        {
            if (bookId < 1 || chapters.Length == 0 || chapters.Any(c => c < 1))
                throw new ArgumentException("请输入有效的参数");

            var obj = new
            {
                bookId,
                chapterIdList = chapters
            };

            var result = await PostAsync<Response<ChapterListResponse>>(API_CHAPTER_DOWNLOAD, obj);
            return result;
        }

        /// <summary>
        /// 刷新章节内容，获取最新的章节数据
        /// 与下载不一样，下载是获取服务器缓存的数据，但不是最新的数据。一般是下载的内容不正确时会调用该接口。该接口响应时间比较长，谨慎调用
        /// </summary>
        /// <param name="bookId">更新的书籍号</param>
        /// <param name="chapters">更新的章节号列表</param>
        /// <returns></returns>
        public async Task<Response<ChapterListResponse>> UpdateChaptersAsync(int bookId, params long[] chapters)
        {
            if (bookId < 1 || chapters.Length == 0 || chapters.Any(c => c < 1))
                throw new ArgumentException("请输入有效的参数");

            var obj = new
            {
                bookId,
                chapterIdList = chapters
            };

            var result = await PostAsync<Response<ChapterListResponse>>(API_CHAPTER_UPDATE, obj);
            return result;
        }
    }
}
