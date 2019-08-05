//using Microsoft.Azure.WebJobs;
//using Microsoft.Extensions.Logging;

//namespace AzureFunc
//{
//	public static class ServiceBusFunction
//	{
//		[FunctionName("ServiceBusFunction")]
//		public static void Run ([ServiceBusTrigger("myqueue", Connection = "ServiceBusConnection")]string myQueueItem, ILogger log)
//		{
//			log.LogInformation($"C# ServiceBus queue trigger function processed message: {myQueueItem}");
//		}
//	}
//}
