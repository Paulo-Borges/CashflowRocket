using CashFlowRocket.Communication.Requests;
using CashFlowRocket.Exception;
using FluentValidation;

namespace CashFlowRocket.Application.UseCases.Expenses.Register
{
    public class RegisterExpenseValidator : AbstractValidator<RequestRegisterExpensesJson>
    {
        public RegisterExpenseValidator()
        {
            RuleFor(e => e.Title).NotEmpty().WithMessage(ResourceErrorMessages.TITLE_REQUIRED);
            RuleFor(e => e.Amount).GreaterThan(0).WithMessage(ResourceErrorMessages.AMOUNT_MUST_BE_GREATER_THAN_ZERO);
            RuleFor(e => e.Date).LessThanOrEqualTo(DateTime.Now).WithMessage(ResourceErrorMessages.EXPENSES_CANNOT_BE_FOR_THE_FUTURE);
            RuleFor(e => e.PaymentType).IsInEnum().WithMessage(ResourceErrorMessages.PAYMENT_TYPE_INVALID1);
        }
    }
}
