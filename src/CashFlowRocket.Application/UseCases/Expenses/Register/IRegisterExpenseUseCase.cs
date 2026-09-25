using CashFlowRocket.Communication.Requests;
using CashFlowRocket.Communication.Responses;

namespace CashFlowRocket.Application.UseCases.Expenses.Register
{
    public interface IRegisterExpenseUseCase
    {
        ResponseRegisteredExpenseJson Execute(RequestRegisterExpensesJson request);
    }
}
