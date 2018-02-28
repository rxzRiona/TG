using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using TG.Authorization;

namespace TG
{
    [DependsOn(
        typeof(TGCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class TGApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<TGAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(TGApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddProfiles(thisAssembly)
            );
        }
    }
}
