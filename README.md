# Example to demonstrate SqlClient usage in Azure Functions

## Tests below combination of tools:

1. .NET Core _3.1-preview3_. [Download Link](https://dotnet.microsoft.com/download/dotnet-core/3.1)
2. Microsoft.NET.Sdk.Functions _3.0.0-preview2_
3. Microsoft.Data.SqlClient _v3.1.5_
4. Azure Functions Version _v2_

## Azure Functions Versions for testing

- Branch [af-v1](https://github.com/cheenamalhotra/azurefunctions-sqlclient-example/tree/af-v1) contains example for working with Azure Functions **v1**
- Branch [af-v3](https://github.com/cheenamalhotra/azurefunctions-sqlclient-example/tree/af-v3) contains example for working with Azure Functions **v3-preview**

## Steps to run this Example:

1. Clone or download this project
2. Open in Visual Studio Code
3. Run with F5
4. Open URL in Browser: `http://localhost:7071/api/HttpTriggerSqlClient?server=myservername&uid=username&pwd=*****`

## Verify output as under:

Hello, {username}. You are connected!