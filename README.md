# NgSchedulerSample
A simplistic scheduler demo using AngularJs and Asp.Net Core

*This app was created as a demo for the fine guys at [ITIX TI](https://github.com/ItixTI)*

## Instructions

**From the solution folder:**

```
> dotnet restore
> cd Scheduler.Web & dotnet ef database update
> dotnet run
```


> Notice that since ssl is enabled by default, you have two options to run https in development mode:
> - Use Visual Studio to run the app, since it already has a self signed certificate
> - Generate a new one - for more information follow this [link](https://blogs.msdn.microsoft.com/webdev/2017/11/29/configuring-https-in-asp-net-core-across-different-platforms/) 
