using System;
using System.Data;
using System.Linq;
using Yuenov_SDK;
using Yuenov_SDK.Enums;
using Yuenov_SDK.Models.Share;

namespace Yuenov_ConsoleApp
{
    class Program
    {
        /**
         * 这里只是一些简单的测试，包含一些基础的调用
         */
        static YuenovClient _client;
        static void Main(string[] args)
        {
            _client = new YuenovClient();
            Console.WriteLine("欢迎使用Yuenov测试命令行程序");
            //SearchBook();
            //GetDiscoveryPage();
            //GetTotalCateories();
            //GetTotalRanks();
            //GetRankDetail();
            //GetEndBooks();
            //GetSpecialList();
            //GetSpecialDetail();
            //GetDiscoveryDetail();
            //GetBookDetail();
            //GetBookChapters();
            GetChapterContent();
            Console.ReadKey();
        }

        static async void SearchBook()
        {
            Console.Write("\n请输入关键词以查询书籍：");
            string keyword = Console.ReadLine();
            try
            {
                Console.WriteLine("正在获取书籍数据...");
                var response = await _client.SearchBookAsync(keyword, 1, 5);
                if (response != null && response.Result.Code == ResultCode.Success)
                {
                    var list = response.Data.List;
                    foreach (var book in list)
                    {
                        WriteBook(book);
                    }
                }
            }
            catch (Exception ex)
            {
                ErrorHandle(ex.Message);
            }

        }

        static void WriteBook(Book book)
        {
            string status = Convert.ToBoolean(book.ChapterStatus == ChapterStatus.End) ? "已完结" : "连载中";
            Console.WriteLine($"书名：{book.Title}\n" +
                $"书号：{book.BookId}\n" +
                $"作者：{book.Author}\n" +
                $"简介：{book.Description}\n" +
                $"分类：{book.CategoryName}\n" +
                $"字数：{book.Word}\n" +
                $"状态：{status}\n" +
                $"\n-----------\n");
        }

        static async void GetDiscoveryPage()
        {
            Console.WriteLine("正在获取发现页数据...");
            try
            {
                var data = await _client.GetDiscoveryPageAsync();
                if (data.Result.Code == ResultCode.Success)
                {
                    foreach (var item in data.Data.List)
                    {
                        string bookNames = string.Join(", ", item.BookList.Select(p => p.Title));
                        Console.WriteLine($"分类名：{item.CategoryName}\n" +
                            $"书籍列表：{bookNames}\n" +
                            $"类型：{item.Type}\n" +
                            $"分类ID：{item.CategoryId}\n" +
                            $"---------");
                    }
                }
            }
            catch (Exception ex)
            {
                ErrorHandle(ex.Message);
            }

        }

        static async void GetTotalCateories()
        {
            Console.WriteLine("正在获取全部分类数据...\n");
            try
            {
                var data = await _client.GetTotalCategoriesAsync();
                if (data.Result.Code == ResultCode.Success)
                {
                    foreach (var item in data.Data.Channels)
                    {
                        Console.WriteLine($"频道名：{item.ChannelName}\n" +
                            $"频道号：{item.ChannelId}\n" +
                            $"--------------\n");
                        foreach (var cate in item.Categories)
                        {
                            Console.WriteLine($"分类名：{cate.CategoryName}\n" +
                                $"分类号：{cate.CategoryId}\n" +
                                $"分类图片：\n");
                            foreach (var pic in cate.CoverImgs)
                            {
                                Console.WriteLine($"· {pic}");
                            }
                            Console.WriteLine("\n********\n");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                ErrorHandle(ex.Message);
            }
        }

        static async void GetTotalRanks()
        {
            Console.WriteLine("正在获取全部榜单数据...\n");
            try
            {
                var data = await _client.GetTotalRanksAsync();
                if (data.Result.Code == ResultCode.Success)
                {
                    foreach (var item in data.Data.Channels)
                    {
                        Console.WriteLine($"频道名：{item.ChannelName}\n" +
                            $"频道号：{item.ChannelId}\n" +
                            $"--------------\n");
                        foreach (var cate in item.Ranks)
                        {
                            Console.WriteLine($"榜单名：{cate.RankName}\n" +
                                $"榜单号：{cate.RankId}\n" +
                                $"榜单图片：\n");
                            foreach (var pic in cate.CoverImgs)
                            {
                                Console.WriteLine($"· {pic}");
                            }
                            Console.WriteLine("\n********\n");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                ErrorHandle(ex.Message);
            }
        }

        static async void GetRankDetail()
        {
            Console.WriteLine("正在获取男生-热搜榜数据...\n");
            try
            {
                var data = await _client.GetRankDetailAsync(1, 101, 1, 5);
                if (data != null && data.Result.Code == ResultCode.Success)
                {
                    foreach (var book in data.Data.List)
                    {
                        WriteBook(book);
                    }
                }
            }
            catch (Exception ex)
            {
                ErrorHandle(ex.Message);
                throw;
            }
        }

        static async void GetEndBooks()
        {
            Console.WriteLine("正在获取完本榜数据...\n");
            try
            {
                var data = await _client.GetEndBooksAsync();
                if (data != null && data.Result.Code == ResultCode.Success)
                {
                    foreach (var item in data.Data.List)
                    {
                        Console.WriteLine($"分类名称：{item.CategoryName}\n" +
                            $"分类数据号：{item.CategoryId}\n" +
                            $"---------\n");
                        foreach (var book in item.BookList)
                        {
                            WriteBook(book);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                ErrorHandle(ex.Message);
                throw;
            }
        }

        static async void GetSpecialList()
        {
            Console.WriteLine("正在获取专题数据...\n");
            try
            {
                var data = await _client.GetAllSpecialListAsync();
                if (data != null && data.Result.Code == ResultCode.Success)
                {
                    foreach (var item in data.Data.SpecialList)
                    {
                        Console.WriteLine($"专题名称：{item.Name}\n" +
                            $"专题号：{item.Id}\n" +
                            $"---------\n");
                        foreach (var book in item.BookList)
                        {
                            WriteBook(book);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                ErrorHandle(ex.Message);
                throw;
            }
        }

        static async void GetSpecialDetail()
        {
            Console.WriteLine("正在获取书友专题数据...\n");
            try
            {
                var data = await _client.GetSpecialDetailAsync(17, 1, 5);
                if (data != null && data.Result.Code == ResultCode.Success)
                {
                    foreach (var item in data.Data.List)
                    {
                        WriteBook(item);
                    }
                    Console.WriteLine($"\n总条目数：{data.Data.Total}");
                }
            }
            catch (Exception ex)
            {
                ErrorHandle(ex.Message);
                throw;
            }
        }

        static async void GetDiscoveryDetail()
        {
            Console.WriteLine("正在获取玄幻分类数据...\n");
            try
            {
                var data = await _client.GetDiscoveryDetailAsync(DiscoveryType.Category, 1, 5, 1);
                if (data != null && data.Result.Code == ResultCode.Success)
                {
                    foreach (var item in data.Data.List)
                    {
                        WriteBook(item);
                    }
                    Console.WriteLine($"\n总条目数：{data.Data.Total}");
                }
            }
            catch (Exception ex)
            {
                ErrorHandle(ex.Message);
                throw;
            }
        }

        static async void GetBookDetail()
        {
            Console.WriteLine("正在获取书籍详情...\n");
            try
            {
                var data = await _client.GetBookDetailAsync(55166);
                if (data.Result.Code == ResultCode.Success)
                {
                    WriteBook(data.Data);
                    if (data.Data.Update != null)
                    {
                        var update = data.Data.Update;
                        Console.WriteLine($"更新信息：\n" +
                            $"-----\n" +
                            $"最新章节名：{update.ChapterName}\n" +
                            $"更新时间：{update.GetUpdateTime():yyyy/MM/dd HH:mm:ss}\n" +
                            $"-----\n");
                    }
                    if (data.Data.Recommend != null)
                    {
                        Console.WriteLine("推荐书籍：\n-----");
                        data.Data.Recommend.ForEach(p => WriteBook(p));
                    }
                }
            }
            catch (Exception ex)
            {
                ErrorHandle(ex.Message);
            }
        }

        static async void GetBookChapters()
        {
            Console.WriteLine("正在获取书籍目录...\n");
            try
            {
                var data = await _client.GetBookChaptersAsync(55166);
                if (data.Result.Code == ResultCode.Success)
                {
                    Console.WriteLine($"书号：{data.Data.BookId}\n" +
                        $"章节数：{data.Data.Chapters.Count}\n" +
                        $"前五章：\n");
                    int maxCount = 5;
                    for (int i = 0; i < data.Data.Chapters.Count; i++)
                    {
                        
                        if (i >= maxCount)
                            break;
                        var cha = data.Data.Chapters[i];
                        Console.WriteLine($"· ({cha.Id}){cha.Name}\n");
                    }
                }
            }
            catch (Exception ex)
            {
                ErrorHandle(ex.Message);
            }
        }

        static async void GetChapterContent()
        {
            Console.WriteLine("正在获取章节内容...\n");
            try
            {
                var data = await _client.DownloadChaptersAsync(55166, 1257207220320452609);
                if (data.Result.Code == ResultCode.Success)
                {
                    var chapter = data.Data.List.First();
                    Console.WriteLine($"章节名：{chapter.Name}\n" +
                        $"章节内容：{chapter.Content}");
                }
            }
            catch (Exception ex)
            {
                ErrorHandle(ex.Message);
            }
        }

        static void ErrorHandle(string msg)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("出错了！");
            Console.WriteLine(msg);
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
