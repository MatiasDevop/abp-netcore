using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using demoFirstApp.Authorization;

namespace demoFirstApp
{
    [DependsOn(
        typeof(demoFirstAppCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class demoFirstAppApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<demoFirstAppAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(demoFirstAppApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
