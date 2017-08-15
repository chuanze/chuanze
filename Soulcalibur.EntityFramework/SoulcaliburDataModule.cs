using System.Data.Entity;
using System.Reflection;
using Abp.Modules;
using Abp.Zero.EntityFramework;
using Soulcalibur.EntityFramework;

namespace Soulcalibur
{
    [DependsOn(typeof(AbpZeroEntityFrameworkModule), typeof(SoulcaliburCoreModule))]
    public class SoulcaliburDataModule : AbpModule
    {
        public override void PreInitialize()
        {
            Database.SetInitializer(new CreateDatabaseIfNotExists<SoulcaliburDbContext>());

            Configuration.DefaultNameOrConnectionString = "Default";
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
