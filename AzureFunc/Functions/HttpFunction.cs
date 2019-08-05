using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using AzureFunc.Services;

namespace AzureFunc
{
	public class HttpFunction
    {
		private readonly IGreeterService _greeter;

		public HttpFunction(IGreeterService greeter)
		{
			_greeter = greeter;
		}

        [FunctionName("HttpFunction")]
        public IActionResult Run(
            [HttpTrigger(AuthorizationLevel.Function, "get", Route = null)] HttpRequest req,
            ILogger log)
        {
            log.LogInformation("C# HTTP trigger function processed a request.");

			return new OkObjectResult(_greeter.Greet());
        }
    }
}
