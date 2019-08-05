# azure-functions-host-repro
 
## Setup
Add a ServiceBus ConnectionString to `ServiceBusConnection` in `local.settings.json`. The ServiceBus should have a queue named `myqueue`.

## Reproduction
1. Run this project, and call the HttpFunction, and everything should work as expected
2. Uncomment the file `AzureFunc/Functions/ServiceBusFunction.cs`.
3. Run and call HttpFunction again, now DI fails.
