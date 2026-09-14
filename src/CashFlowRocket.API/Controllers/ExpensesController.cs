using CashFlowRocket.Communication.Requests;
using Microsoft.AspNetCore.Mvc;

namespace CashFlowRocket.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExpensesController : ControllerBase
    {
        [HttpPost]
        public IActionResult Register([FromBody] RequestRegisterExpensesJson request)
        {
            return Created();
        }
    }
}
