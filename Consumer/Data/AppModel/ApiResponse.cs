namespace Gkdr.Consumer.Data.AppModel
{
    public class ApiResponse
    {
        public bool HasError { get; set; }
        public string Message { get; set; }

        public ApiResponse() { }

        public ApiResponse(bool hasError, string message)
        {
            HasError = hasError;
            Message = message;
        }
    }
}
