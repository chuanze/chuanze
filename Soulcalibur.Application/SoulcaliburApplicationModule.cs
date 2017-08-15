using System.Reflection;
using Abp.AutoMapper;
using Abp.Modules;

namespace Soulcalibur
{
    [DependsOn(typeof(SoulcaliburCoreModule), typeof(AbpAutoMapperModule))]
    public class SoulcaliburApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Modules.AbpAutoMapper().Configurators.Add(mapper =>
            {
                //Add your custom AutoMapper mappings here...
                //mapper.CreateMap<,>()
            });
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
