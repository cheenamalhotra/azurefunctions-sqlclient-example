# Example to demonstrate SqlClient usage in Azure Functions

## Tests below combination of tools:

1. .NET Core _3.0_. [Download Link](https://dotnet.microsoft.com/download/dotnet-core/3.0)
2. Microsoft.NET.Sdk.Functions _3.0.0-preview2_
3. Microsoft.Data.SqlClient _v1.1.0_

## Steps to run this Example:

1. Clone or download this project
2. Open in Visual Studio Code
3. Run with F5
4. Open URL in Browser: `http://localhost:7071/api/HttpTriggerSqlClient?server=myservername&uid=username&pwd=*****`

## Verify output as under:

Hello, {username}. You are connected!