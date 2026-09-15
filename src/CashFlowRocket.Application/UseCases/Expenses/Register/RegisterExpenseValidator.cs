using CashFlowRocket.Communication.Requests;
using FluentValidation;

namespace CashFlowRocket.Application.UseCases.Expenses.Register
{
    public class RegisterExpenseValidator : AbstractValidator<RequestRegisterExpensesJson>
    {
        public RegisterExpenseValidator()
        {
            RuleFor(e => e.Title).NotEmpty().WithMessage("The title is required");
            RuleFor(e => e.Amount).GreaterThan(0).WithMessage("The amount must be greater than zero");
            RuleFor(e => e.Date).LessThanOrEqualTo(DateTime.Now).WithMessage("The date cannot be in the future");
            RuleFor(e => e.PaymentType).IsInEnum().WithMessage("Please specify a valid payment type");
        }
    }
}
