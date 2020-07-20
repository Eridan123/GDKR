using System.Threading.Tasks;
using Gkdr.Consumer.Data.AppModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Gkdr.Consumer.Helpers
{
    public class ErrorResponse : IActionResult
    {
        private readonly string _message;

        public ErrorResponse(string message)
        {
            _message = message;
        }

        public async Task ExecuteResultAsync(ActionContext context)
        {
            var response = new ApiResponse(true, _message);

            var result = new ObjectResult(response)
            {
                StatusCode = StatusCodes.Status200OK,
                Value = response
            };

            await result.ExecuteResultAsync(context);
        }
    }
}
