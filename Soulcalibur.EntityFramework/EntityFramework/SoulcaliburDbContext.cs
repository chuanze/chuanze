using System.Data.Common;
using Abp.Zero.EntityFramework;
using Soulcalibur.Authorization.Roles;
using Soulcalibur.MultiTenancy;
using Soulcalibur.Users;
using System.Data.Entity;
using Soulcalibur.Tasks;

namespace Soulcalibur.EntityFramework
{
    public class SoulcaliburDbContext : AbpZeroDbContext<Tenant, Role, User>
    {
        //TODO: Define an IDbSet for your Entities...

        /* NOTE: 
         *   Setting "Default" to base class helps us when working migration commands on Package Manager Console.
         *   But it may cause problems when working Migrate.exe of EF. If you will apply migrations on command line, do not
         *   pass connection string name to base classes. ABP works either way.
         */
        public SoulcaliburDbContext()
            : base("Default")
        {

        }

        /* NOTE:
         *   This constructor is used by ABP to pass connection string defined in SoulcaliburDataModule.PreInitialize.
         *   Notice that, actually you will not directly create an instance of SoulcaliburDbContext since ABP automatically handles it.
         */
        public SoulcaliburDbContext(string nameOrConnectionString)
            : base(nameOrConnectionString)
        {

        }

        //This constructor is used in tests
        public SoulcaliburDbContext(DbConnection existingConnection)
         : base(existingConnection, false)
        {

        }

        public SoulcaliburDbContext(DbConnection existingConnection, bool contextOwnsConnection)
         : base(existingConnection, contextOwnsConnection)
        {

        }
        public IDbSet<Task> Tasks { get; set; }
    }
}
