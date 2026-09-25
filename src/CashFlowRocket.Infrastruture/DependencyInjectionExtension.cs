using CashFlowRocket.Domain.Repositories.Expenses;
using CashFlowRocket.Infrastruture.DataContext.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace CashFlowRocket.Infrastruture
{
    public static class DependencyInjectionExtension
    {
        public static void AddInfrastructure(this IServiceCollection services)
        {
            services.AddScoped<IExpensesRepository, ExpensesRepository>();

        }
    }
}
