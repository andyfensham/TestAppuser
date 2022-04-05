using Funq;
using ServiceStack;
using TestAppuser.ServiceInterface;
using TestAppuser.ServiceModel.Types;

[assembly: HostingStartup(typeof(TestAppuser.AppHost))]

namespace TestAppuser;

public class AppHost : AppHostBase, IHostingStartup
{
    public void Configure(IWebHostBuilder builder) => builder
        .ConfigureServices(services => {
            // Configure ASP.NET Core IOC Dependencies
        });

    public AppHost() : base("TestAppuser", typeof(MyServices).Assembly) {}

    public override void Configure(Container container)
    {
        // Configure ServiceStack only IOC, Config & Plugins
        SetConfig(new HostConfig {
            UseSameSiteCookies = true,
        });
    }
}
