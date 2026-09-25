using CashFlowRocket.Communication.Requests;
using CashFlowRocket.Communication.Responses;
using CashFlowRocket.Domain.Entities;
using CashFlowRocket.Domain.Repositories.Expenses;
using CashFlowRocket.Exception.ExceptionsBase;

namespace CashFlowRocket.Application.UseCases.Expenses.Register
{
    public class RegisterExpenseUseCase : IRegisterExpenseUseCase
    {
        private readonly IExpensesRepository _repository;

        public RegisterExpenseUseCase(IExpensesRepository repository)
        {
            _repository = repository;

        }
        public ResponseRegisteredExpenseJson Execute(RequestRegisterExpensesJson request)
        {
            Validate(request);

            //var dbContext = new AppDbContext();

            var entity = new Expense 
            {
                Amount = request.Amount,
                Date = request.Date,
                Description = request.Description,
                Title = request.Title,
                PaymentType = (Domain.Enums.PaymentType)request.PaymentType,
            };

            _repository.Add(entity);

            //dbContext.Expenses.Add(entity);

            //dbContext.SaveChanges();

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
