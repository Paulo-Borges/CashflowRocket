using CashFlowRocket.Application.UseCases.Expenses.Register;
using CashFlowRocket.Exception;
using CommonTestUtilities.Requests;
using FluentAssertions;

namespace Validators.tests.Expenses.Register
{
    public class RegisterExpenseValidatorTests
    {
        [Fact]
        public void Success()
        {
            //Arrange
            var validator = new RegisterExpenseValidator();
            var request = RequestRegisterExpenseJsonBuilder.Build();

            //Act

            var result = validator.Validate(request);

            //Assert
            result.IsValid.Should().BeTrue();

        }

        [Fact]
        public void Error_Title_Empty()
        {
            //Arrange
            var validator = new RegisterExpenseValidator();
            var request = RequestRegisterExpenseJsonBuilder.Build();
            request.Title = string.Empty;
            //Act
            var result = validator.Validate(request);
            //Assert
            result.IsValid.Should().BeFalse();
            result.Errors.Should().ContainSingle().And.Contain(e => e.ErrorMessage.Equals(ResourceErrorMessages.TITLE_REQUIRED));
        }
    }
}
