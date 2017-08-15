using System.Data.Entity.Migrations;
using Abp.MultiTenancy;
using Abp.Zero.EntityFramework;
using Soulcalibur.Migrations.SeedData;
using EntityFramework.DynamicFilters;

namespace Soulcalibur.Migrations
{
    public sealed class Configuration : DbMigrationsConfiguration<Soulcalibur.EntityFramework.SoulcaliburDbContext>, IMultiTenantSeed
    {
        public AbpTenantBase Tenant { get; set; }

        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "Soulcalibur";
        }

        protected override void Seed(Soulcalibur.EntityFramework.SoulcaliburDbContext context)
        {
            context.DisableAllFilters();

            if (Tenant == null)
            {
                //Host seed
                new InitialHostDbBuilder(context).Create();

                //Default tenant seed (in host database).
                new DefaultTenantCreator(context).Create();
                new TenantRoleAndUserBuilder(context, 1).Create();
                new DetfaultTestDataForTask(context).Create();
            }
            else
            {
                //You can add seed for tenant databases and use Tenant property...
            }

            context.SaveChanges();
        }
    }
}
