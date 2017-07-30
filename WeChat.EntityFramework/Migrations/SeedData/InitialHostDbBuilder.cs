using WeChat.EntityFramework;
using EntityFramework.DynamicFilters;

namespace WeChat.Migrations.SeedData
{
    public class InitialHostDbBuilder
    {
        private readonly WeChatDbContext _context;

        public InitialHostDbBuilder(WeChatDbContext context)
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
