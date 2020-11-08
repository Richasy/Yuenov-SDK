namespace Yuenov_SDK
{
    public partial class YuenovClient
    {
        /// <summary>
        /// 批量检查书籍是否有更新API
        /// </summary>
        private string API_CHECK_UPDATE
        {
            get => _baseUrl + _baseRoute + "/book/checkUpdate";
        }

        /// <summary>
        /// 搜索书籍API
        /// </summary>
        private string API_SEARCH_BOOK
        {
            get => _baseUrl + _baseRoute + "/book/search";
        }

        /// <summary>
        /// 发现页面API
        /// </summary>
        private string API_DISCOVERY_PAGE
        {
            get => _baseUrl + _baseRoute + "/category/discovery";
        }

        /// <summary>
        /// 全部分类API
        /// </summary>
        private string API_TOTAL_CATEGORIES
        {
            get => _baseUrl + _baseRoute + "/category/getCategoryChannel";
        }

        /// <summary>
        /// 全部榜单API
        /// </summary>
        private string API_TOTAL_RANKS
        {
            get => _baseUrl + _baseRoute + "/rank/getList";
        }

        /// <summary>
        /// 榜单详情API
        /// </summary>
        private string API_RANK_DETAIL
        {
            get => _baseUrl + _baseRoute + "/rank/getPage";
        }

        /// <summary>
        /// 完本书籍API
        /// </summary>
        private string API_END_BOOK
        {
            get => _baseUrl + _baseRoute + "/category/getCategoryEnd";
        }

        /// <summary>
        /// 专题列表API
        /// </summary>
        private string API_SPECIAL_LIST
        {
            get => _baseUrl + _baseRoute + "/book/getSpecialList";
        }

        /// <summary>
        /// 专题详情API
        /// </summary>
        private string API_SPECIAL_DETAIL
        {
            get => _baseUrl + _baseRoute + "/book/getSpecialPage";
        }

        /// <summary>
        /// 发现页详情API
        /// </summary>
        private string API_DISCOVERY_DETAIL
        {
            get => _baseUrl + _baseRoute + "/category/discoveryAll";
        }

        /// <summary>
        /// 分类下所有书籍API
        /// </summary>
        private string API_CATEGORY_DETAIL
        {
            get => _baseUrl + _baseRoute + "/book/getCategoryId";
        }

        /// <summary>
        /// 书籍详情API
        /// </summary>
        private string API_BOOK_DETAIL
        {
            get => _baseUrl + _baseRoute + "/book/getDetail";
        }

        /// <summary>
        /// 书籍推荐API
        /// </summary>
        private string API_BOOK_RECOMMEND
        {
            get => _baseUrl + _baseRoute + "/book/getRecommend";
        }

        /// <summary>
        /// 书籍目录API
        /// </summary>
        private string API_CHAPTER_LIST
        {
            get => _baseUrl + _baseRoute + "/chapter/getByBookId";
        }

        /// <summary>
        /// 章节下载API
        /// </summary>
        private string API_CHAPTER_DOWNLOAD
        {
            get => _baseUrl + _baseRoute + "/chapter/get";
        }

        /// <summary>
        /// 章节更新API
        /// </summary>
        private string API_CHAPTER_UPDATE
        {
            get => _baseUrl + _baseRoute + "/chapter/updateForce";
        }
    }
}
