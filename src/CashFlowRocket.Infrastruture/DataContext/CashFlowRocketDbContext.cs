using CashFlowRocket.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace CashFlowRocket.Infrastruture.DataContext
{
    public class CashFlowRocketDbContext : DbContext
    {
        public DbSet<Expense> Expenses { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer("YourConnectionStringHere");
        }

    }
}
