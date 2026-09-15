using CashFlowRocket.Communication.Requests;
using CashFlowRocket.Communication.Responses;
using System.Net.Http.Headers;

namespace CashFlowRocket.Application.UseCases.Expenses.Register
{
    public class RegisterExpenseUseCase
    {
        public ResponseRegisteredExpenseJson Execute(RequestRegisterExpensesJson request)
        {
            Validate(request);

            return new ResponseRegisteredExpenseJson();
        }

        private void Validate(RequestRegisterExpensesJson request)
        {
            var validator = new RegisterExpenseValidator();

            var result = validator.Validate(request);
           
        }
    }
}
