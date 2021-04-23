using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using VCM.MIT.Authorization;

namespace VCM.MIT
{
    [DependsOn(
        typeof(MITCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class MITApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<MITAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(MITApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
