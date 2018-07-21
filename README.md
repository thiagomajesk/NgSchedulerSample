# NgSchedulerSample
A simplistic scheduler demo using AngularJs and Asp.Net Core

*This app was created as a demo for the fine guys at [ITIX TI](https://github.com/ItixTI)*

## Instructions

#### Requirements:

- dotnet core sdk 2.1.x (`choco install dotnetcore-sdk`)
- SQL Server 2017 Express LocalDB 14.x (`choco install sqllocaldb`) or Full SQL Server (you'll need to change the connection string)

> If you are not sure, it may be easier to just use the latest version of Visual Studio 2017.

**From the solution folder:**

```
> dotnet restore
> cd Scheduler.Web & dotnet ef database update¹
> dotnet run²
```


> ¹ If you have any problems related to file permission while running `database update` through command line, refer to [this link](https://github.com/aspnet/EntityFramework6/issues/384). This is a known Issue that only happens with locadb 2017 standalone


> ² Notice that since ssl is enabled by default, you have two options to run https in development mode:
> - Use Visual Studio to run the app, since it already has a self signed certificate
> - Generate a new one - for more information follow this [link](https://blogs.msdn.microsoft.com/webdev/2017/11/29/configuring-https-in-asp-net-core-across-different-platforms/) 

#### Known (intentional) limitations:
- Scheduling span of 40 minutes (not inforced by the API)
- Using external CDN for client side dependencies (Make sure you are in a open network)
