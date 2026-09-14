using CashFlowRocket.Communication.Requests;
using CashFlowRocket.Communication.Responses;

namespace CashFlowRocket.Application.UseCases.Expenses.Register
{
    public class RegisterExpenseUseCase
    {
        public ResponseRegisteredExpenseJson Execute(RequestRegisterExpensesJson request)
        {
            return new ResponseRegisteredExpenseJson();
        }
    }
}
