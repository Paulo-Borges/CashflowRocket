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
            if (request == null)
            {
                throw new ArgumentException("Request cannot be null.");
            }
            if (request.Amount <= 0)
            {
                throw new ArgumentException("Amount must be greater than zero.");
            }
            if (request.Date == default)
            {
                throw new ArgumentException("Date is required.");
            }
        }
    }
}
