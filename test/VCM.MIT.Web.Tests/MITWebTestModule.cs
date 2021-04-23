using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using VCM.MIT.EntityFrameworkCore;
using VCM.MIT.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace VCM.MIT.Web.Tests
{
    [DependsOn(
        typeof(MITWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class MITWebTestModule : AbpModule
    {
        public MITWebTestModule(MITEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(MITWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(MITWebMvcModule).Assembly);
        }
    }
}