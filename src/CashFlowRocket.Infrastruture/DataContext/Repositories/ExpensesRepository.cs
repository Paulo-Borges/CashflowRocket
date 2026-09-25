using CashFlowRocket.Domain.Entities;
using CashFlowRocket.Domain.Repositories.Expenses;

namespace CashFlowRocket.Infrastruture.DataContext.Repositories
{
    //------- -- --Fazer a Injeção de Dependência do DbContext no ---------Program.cs---------------
    internal class ExpensesRepository : IExpensesRepository
    {
        public void Add(Expense expense)
        {
            var dbContext = new CashFlowRocketDbContext();

            dbContext.Expenses.Add(expense);    

            dbContext.SaveChanges();
        }
    }
}
