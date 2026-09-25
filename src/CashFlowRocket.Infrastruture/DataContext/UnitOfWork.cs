using CashFlowRocket.Domain.Repositories;

namespace CashFlowRocket.Infrastruture.DataContext
{
    internal class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _dbContext;
        public UnitOfWork(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public void Commit()
        {
            _dbContext.SaveChanges();
        }
    }
}
