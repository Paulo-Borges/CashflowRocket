using CashFlowRocket.Application.UseCases.Expenses.Register;
using CashFlowRocket.Communication.Enums;
using CashFlowRocket.Communication.Requests;

namespace Validators.tests.Expenses.Register
{
    public class RegisterExpenseValidatorTests
    {
        [Fact]
        public void Success()
        {
            //Arrange
            var validator = new RegisterExpenseValidator();
            var request = new RequestRegisterExpensesJson 
            {
                Amount = 100,
                Date = DateTime.Now.AddDays(-1),
                Description = "Description",
                Title = "Apple",
                PaymentType = PaymentType.CreditCard
            };

            //Act

            var result = validator.Validate(request);

            //Assert
            Assert.True(result.IsValid);

        }
    }
}
