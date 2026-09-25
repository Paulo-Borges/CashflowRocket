using CashFlowRocket.Domain.Entities;

namespace CashFlowRocket.Domain.Repositories.Expenses
{
    public interface IExpensesRepository
    {
        void Add(Expense expense);
    }
}
