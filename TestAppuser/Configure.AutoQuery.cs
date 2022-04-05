using ServiceStack;

[assembly: HostingStartup(typeof(TestAppuser.ConfigureAutoQuery))]

namespace TestAppuser
{
    public class ConfigureAutoQuery : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder) => builder
            .ConfigureAppHost(appHost => {
                appHost.Plugins.Add(new AutoQueryFeature {
                    MaxLimit = 1000,
                    IncludeTotal = true,

                    GenerateCrudServices = new GenerateCrudServices
                    {
                        AutoRegister = true,
                        //CreateServices =
                        //{
                        //    new CreateCrudServices{Schema = "Environment"},
                        //    new CreateCrudServices{Schema = "Governance"},
                        //    new CreateCrudServices{Schema = "HealthAndSafety"},
                        //    new CreateCrudServices{Schema = "Social"},
                        //    new CreateCrudServices{Schema = "TrainingAndDev"},
                        //    new CreateCrudServices{Schema = "Transformation"},
                        //    new CreateCrudServices{Schema = "Answers"},
                        //    new CreateCrudServices{Schema = "Configuration"},

                        //}

                    }
                });
            });
    }
}