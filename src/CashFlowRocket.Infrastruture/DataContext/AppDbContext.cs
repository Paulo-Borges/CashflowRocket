using Microsoft.EntityFrameworkCore;

namespace CashFlowRocket.Infrastruture.DataContext
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
    }
}
