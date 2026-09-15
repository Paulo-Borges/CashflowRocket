using CashFlowRocket.Application.UseCases.Expenses.Register;
using CashFlowRocket.Communication.Requests;
using CashFlowRocket.Communication.Responses;
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
            try
            {
                var useCase = new RegisterExpenseUseCase();

                var response = useCase.Execute(request);
                return Created(string.Empty, response);
            }
            catch (ArgumentException ex)
            {
                var errorResponse = new ResponseErrorJson
                {
                    ErrorMessage = "An unexpected error occurred."
                };

                return BadRequest(errorResponse);
            }
            catch
            {
                var errorResponse = new ResponseErrorJson
                {
                    ErrorMessage = "An unexpected error occurred."
                };

                return StatusCode(StatusCodes.Status500InternalServerError, errorResponse);
            }
        }
    }
}
