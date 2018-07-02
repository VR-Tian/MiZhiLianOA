using VR.Tian.EntityFramework;
using EntityFramework.DynamicFilters;

namespace VR.Tian.Migrations.SeedData
{
    public class InitialHostDbBuilder
    {
        private readonly TianDbContext _context;

        public InitialHostDbBuilder(TianDbContext context)
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
