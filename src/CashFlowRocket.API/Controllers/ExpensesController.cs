using CashFlowRocket.Application.UseCases.Expenses.Register;
using CashFlowRocket.Communication.Requests;
using Microsoft.AspNetCore.Mvc;

namespace CashFlowRocket.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExpensesController : ControllerBase
    {
        [HttpPost]
        public IActionResult Register(
            [FromServices] IRegisterExpenseUseCase useCase,
            [FromBody] RequestRegisterExpensesJson request)
        {  
 

                var response = useCase.Execute(request);

                return Created(string.Empty, response);  
        }
    }
}
