using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using demoFirstApp.EntityFrameworkCore;
using demoFirstApp.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace demoFirstApp.Web.Tests
{
    [DependsOn(
        typeof(demoFirstAppWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class demoFirstAppWebTestModule : AbpModule
    {
        public demoFirstAppWebTestModule(demoFirstAppEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(demoFirstAppWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(demoFirstAppWebMvcModule).Assembly);
        }
    }
}