namespace CashFlowRocket.Exception.ExceptionsBase
{
    public class ErrorOnValidationException : CashFlowRocketException
    {
        public List<string> Erros { get; set; }
        public ErrorOnValidationException(List<string> errorMessages)
        {
            Erros = errorMessages;
        }
    }
}
 