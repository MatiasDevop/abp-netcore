using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using demoFirstApp.Configuration;

namespace demoFirstApp.Web.Host.Startup
{
    [DependsOn(
       typeof(demoFirstAppWebCoreModule))]
    public class demoFirstAppWebHostModule: AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public demoFirstAppWebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(demoFirstAppWebHostModule).GetAssembly());
        }
    }
}
