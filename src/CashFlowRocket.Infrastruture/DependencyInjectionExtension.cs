using CashFlowRocket.Domain.Repositories.Expenses;
using CashFlowRocket.Infrastruture.DataContext;
using CashFlowRocket.Infrastruture.DataContext.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace CashFlowRocket.Infrastruture
{
    public static class DependencyInjectionExtension
    {
        public static void AddInfrastructure(this IServiceCollection services)
        {
            AddDbContext(services);
            AddRepositories(services);

        }

        private static void AddRepositories(IServiceCollection services)
        {
            services.AddScoped<IExpensesRepository, ExpensesRepository>();
        }

        private static void AddDbContext(IServiceCollection services)
        {
            services.AddDbContext<AppDbContext>();
        }
    }
}
