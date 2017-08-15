using System.Data.Entity;
using System.Reflection;
using Abp.Modules;
using Soulcalibur.EntityFramework;

namespace Soulcalibur.Migrator
{
    [DependsOn(typeof(SoulcaliburDataModule))]
    public class SoulcaliburMigratorModule : AbpModule
    {
        public override void PreInitialize()
        {
            Database.SetInitializer<SoulcaliburDbContext>(null);

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}