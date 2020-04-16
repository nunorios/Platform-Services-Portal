using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Platform_Services_Portal.Data;

[assembly: HostingStartup(typeof(Platform_Services_Portal.Areas.Identity.IdentityHostingStartup))]
namespace Platform_Services_Portal.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) =>
            {
                services.AddDbContext<Platform_Services_PortalContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("Platform_Services_PortalContextConnection")));

                services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = false)
                 .AddRoles<IdentityRole>()
                .AddEntityFrameworkStores<Platform_Services_PortalContext>();
            });
        }
    }
}