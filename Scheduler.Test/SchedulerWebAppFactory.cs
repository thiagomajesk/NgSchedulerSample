using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Scheduler.Web.Data;

namespace Scheduler.Test
{
    public class SchedulerWebAppFactory<TStartup> : WebApplicationFactory<Web.Startup>
    {
        protected override void ConfigureWebHost(IWebHostBuilder builder)
        {
            builder.ConfigureServices(services =>
            {

                var serviceProvider = new ServiceCollection()
                   .AddEntityFrameworkInMemoryDatabase()
                   .BuildServiceProvider();

                services.AddDbContext<DatabaseContext>(options =>
                {
                    options.UseInMemoryDatabase("SchedulerInMemmoryDatabase");
                    options.UseInternalServiceProvider(serviceProvider);
                });

            });

            base.ConfigureWebHost(builder);
        }
    }
}
