﻿using AzureFunc.Services;
using Microsoft.Azure.Functions.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;

[assembly: FunctionsStartup(typeof(AzureFunc.Startup))]
namespace AzureFunc
{
	public class Startup : FunctionsStartup
	{
		public override void Configure (IFunctionsHostBuilder builder)
		{
			builder.Services.AddSingleton<IGreeterService, GreeterService>();
		}
	}
}
