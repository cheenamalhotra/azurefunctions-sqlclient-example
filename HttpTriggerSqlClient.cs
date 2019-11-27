using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Microsoft.Data.SqlClient;

namespace SqlClientTestFunction
{
    public static class HttpTriggerSqlClient
    {
        [FunctionName("HttpTriggerSqlClient")]
        public static async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Function, "get", "post", Route = null)] HttpRequest req,
            ILogger log)
        {
            log.LogInformation("C# HTTP trigger function processed a request.");

            string serverName = req.Query["server"];
            string uid = req.Query["uid"];
            string pwd = req.Query["pwd"];
            string cs = $"Server=tcp:{serverName}.database.windows.net,1433;Initial Catalog=NorthWind;User ID={uid};Password={pwd};";
            string message = "Sorry!";
            using (SqlConnection con = new SqlConnection(cs))
            {
                try
                {
                    con.Open();
                    message = "You are connected!";
                }
                catch (SqlException e)
                {
                    message = "An error occured: " + e.Message;
                }
            }
            string requestBody = await new StreamReader(req.Body).ReadToEndAsync();
            dynamic data = JsonConvert.DeserializeObject(requestBody);
            serverName = serverName ?? data?.name;

            return serverName != null
                ? (ActionResult)new OkObjectResult($"Hello, {uid}. {message}")
                : new BadRequestObjectResult("Please pass a name on the query string or in the request body");
        }
    }
}
