# NgSchedulerSample
A simplistic scheduler demo using AngularJs and Asp.Net Core

*This app was created as a demo for the fine guys at [ITIX TI](https://github.com/ItixTI)*

## Instructions

*Framework version: dotnet core 2.1+ (cli or VS 15.7.5)*

**From the solution folder:**

```
> dotnet restore
> cd Scheduler.Web & dotnet ef database update
> dotnet run
```


> Notice that since ssl is enabled by default, you have two options to run https in development mode:
> - Use Visual Studio to run the app, since it already has a self signed certificate
> - Generate a new one - for more information follow this [link](https://blogs.msdn.microsoft.com/webdev/2017/11/29/configuring-https-in-asp-net-core-across-different-platforms/) 

#### Known (intentional) limitations:
- Scheduling span of 40 minutes (not inforced by the API)
- Using external CDN for client side dependencies (Make sure you are in a open network)
