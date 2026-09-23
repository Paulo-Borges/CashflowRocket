using CashFlowRocket.Communication.Requests;
using CashFlowRocket.Communication.Responses;
using CashFlowRocket.Domain.Entities;
using CashFlowRocket.Exception.ExceptionsBase;
using CashFlowRocket.Infrastruture.DataContext;

namespace CashFlowRocket.Application.UseCases.Expenses.Register
{
    public class RegisterExpenseUseCase
    {
        public ResponseRegisteredExpenseJson Execute(RequestRegisterExpensesJson request)
        {
            Validate(request);

            var dbContext = new AppDbContext();

            var entity = new Expense 
            {
                Amount = request.Amount,
                Date = request.Date,
                Description = request.Description,
                Title = request.Title,
                PaymentType = (Domain.Enums.PaymentType)request.PaymentType,
            };

            dbContext.Expenses.Add(entity);

            dbContext.SaveChanges();

            return new ResponseRegisteredExpenseJson();
        }

        private void Validate(RequestRegisterExpensesJson request)
        {
            var validator = new RegisterExpenseValidator();

            var result = validator.Validate(request);

            if (result.IsValid == false)
            {
                var errorMessages = result.Errors.Select(f => f.ErrorMessage).ToList();

                throw new ErrorOnValidationException(errorMessages);

            }
        }
    }
}
