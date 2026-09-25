using CashFlowRocket.Domain.Entities;
using CashFlowRocket.Domain.Repositories.Expenses;

namespace CashFlowRocket.Infrastruture.DataContext.Repositories
{
    //------- -- --Fazer a Injeção de Dependência do DbContext no ---------Program.cs---------------
    internal class ExpensesRepository : IExpensesRepository
    {
        private readonly AppDbContext _dbContext;

        public ExpensesRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public void Add(Expense expense)
        {

            _dbContext.Expenses.Add(expense);    

            _dbContext.SaveChanges();
        }
    }
}
