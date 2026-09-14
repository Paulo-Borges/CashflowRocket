using CashFlowRocket.Application.UseCases.Expenses.Register;
using CashFlowRocket.Communication.Requests;
using Microsoft.AspNetCore.Mvc;
using System;

namespace CashFlowRocket.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExpensesController : ControllerBase
    {
        [HttpPost]
        public IActionResult Register([FromBody] RequestRegisterExpensesJson request)
        {
            var useCse = new RegisterExpenseUseCase();

            var response = useCse.Execute(request);
            return Created(string.Empty, response);
        }
    }
}
