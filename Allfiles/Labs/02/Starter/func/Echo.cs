using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.Azure.WebJobs;
using Microsoft.Extensions.Logging;

public static class Echo {

    [FunctionName("Echo")]
    public static IActionResult Run([HttpTrigger("POST")]HttpRequest req, ILogger logger) {

        logger.LogInformation("Http request received!");
        return new OkObjectResult(req.Body);
    }
}