using Bogus;
using CashFlowRocket.Communication.Requests;

namespace CommonTestUtilities.Requests
{
    public class RequestRegisterExpenseJsonBuilder
    {
        public RequestRegisterExpensesJson Build()
        {

            return new Faker<RequestRegisterExpensesJson>()
                .RuleFor(r => r.Title, faker => faker.Commerce.ProductName())
                .RuleFor(r => r.Description, faker => faker.Commerce.ProductDescription())
                .RuleFor(r => r.Date, faker => faker.Date.Past())
                .RuleFor(r => r.PaymentType, faker => faker.PickRandom<CashFlowRocket.Communication.Enums.PaymentType>())
                .RuleFor(r => r.Amount, faker => faker.Random.Decimal(min: 0, max: 1000));

        }
    }
}
