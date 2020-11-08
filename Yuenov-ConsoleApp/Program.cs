using System;
using System.Linq;
using Yuenov_SDK;
using Yuenov_SDK.Enums;

namespace Yuenov_ConsoleApp
{
    class Program
    {
        static YuenovClient _client;
        static void Main(string[] args)
        {
            _client = new YuenovClient();
            Console.WriteLine("欢迎使用Yuenov测试命令行程序");
            //SearchBook();
            //GetDiscoveryPage();
            GetTotalCateories();
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
                        string status = Convert.ToBoolean(book.IsBookFinish()) ? "已完结" : "连载中";
                        Console.WriteLine($"书名：{book.Title}\n" +
                            $"作者：{book.Author}\n" +
                            $"简介：{book.Description}\n" +
                            $"分类：{book.CategoryName}\n" +
                            $"字数：{book.Word}\n" +
                            $"状态：{status}\n" +
                            $"-----------");
                    }
                }
            }
            catch (Exception ex)
            {
                ErrorHandle(ex.Message);
            }

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
            Console.WriteLine("正在获取全部分类数据...");
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
                            Console.WriteLine("********");
                        }
                    }
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
