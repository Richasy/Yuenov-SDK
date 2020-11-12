<p align="center">
    <img src="https://i.loli.net/2020/11/08/UEnYJ3MV1WAcvat.png" align="center" height="80"/>
</p>

<div align="center">

# 阅小说 .NET SDK

[![Nuget](https://img.shields.io/nuget/v/Richasy.Yuenov.Sdk)](https://www.nuget.org/packages/Richasy.Yuenov.Sdk/)

该SDK基于[阅小说公开API](https://github.com/yuenov/reader-api)实现，在.NET Standard 2.0上构建

</div>

## 开发环境

|||
|-|-|
|.NET版本|.NET Standard 2.0|
|开发工具|Visual Studio 2019|
|开发环境|Windows10 ver.20H2|

## 简单的开始

*使用前，你需要先安装[Richasy.Yuenov.Sdk](https://www.nuget.org/packages/Richasy.Yuenov.Sdk) nuget包*

```csharp
// 创建Client
YuenovClient _client = new YuenovClient();

//查询书籍
var response = await _client.SearchBookAsync(keyword: "xx小说", pageNum: 1, pageSize: 5);
```

以上步骤实现了根据关键词查找书籍的请求，意即：

**查找关键词为`xx小说`的搜索结果，将结果分页，每页5个，回传第一页的结果**

## 端口配置

根据[公开API](https://github.com/yuenov/reader-api)的说明，开发者可以自选端口，有`15555`, `17777`等端口可选，SDK提供了相应的配置，在`YuenovClient`的构造函数中，你可以使用对应的重载：

```csharp
var _client = new YuenovClient(17777);
```

客户端内有两个基础地址，一个是用于API请求的`_baseUrl`，另一个是用于显示图片的`_picUrl`。使用端口重载会一起修改两个基础地址。如果你需要让这两个地址分别使用不同的端口，请使用另外一种重载：

```csharp
var _client = new YuenovClient(baseUrl: "http://yuenov.com:15555", pictureUrl: "http://yuenov.com:17777");
```

## 令牌设置

阅小说相关服务免费公开了API，但是对IP单位时间内的请求次数进行了限制（10s内请求一次）。如果要解除限制，需要联系服务开发者获取令牌。

当获取令牌后，可以使用如下代码进行令牌设置：

```csharp
_client.SetOpenToken(yourToken);
```

## 图片链接

API请求得到的图片链接实际上是图片在服务器中的路径，并不能够直接使用，需要进行地址拼接。SDK提供了简单的方法用于返回图片链接：

```csharp
string imgUrl = _client.GetImageUrl(someBook.CoverImg);
```

## 预热与释放

SDK在内部使用`HttpClient`进行网络请求，并在内部创建了一个不会立即释放的`HttpClient`实例。

在进行请求前，你可以先预热连接，以便缩短下一次请求的时间：

```csharp
var _client = new YuenovClient();
_client.WarmUpAsync();
```

当你觉得客户端已经完成了使命，到了该释放的时候，那么你可以调用`Dispose`方法释放客户端对象。

```csharp
_client.Dispose();
```

或者

```csharp
using(var _client = new YuenovClient())
{
    // do something...
}
```

## 鸣谢

- [阅小说](https://github.com/yuenov)
