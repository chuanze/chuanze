using Soulcalibur.EntityFramework;
using EntityFramework.DynamicFilters;

namespace Soulcalibur.Migrations.SeedData
{
    public class InitialHostDbBuilder
    {
        private readonly SoulcaliburDbContext _context;

        public InitialHostDbBuilder(SoulcaliburDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            _context.DisableAllFilters();

            new DefaultEditionsCreator(_context).Create();
            new DefaultLanguagesCreator(_context).Create();
            new HostRoleAndUserCreator(_context).Create();
            new DefaultSettingsCreator(_context).Create();
        }
    }
}
