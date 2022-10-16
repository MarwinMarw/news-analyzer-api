namespace NewsAnalyzerApi.Controllers;

using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("[controller]")]
public class NewsSourceController : Controller
{
    private readonly ILogger _logger;

    public NewsSourceController(ILogger<NewsSourceController> logger)
    {
        _logger = logger;
    }

    [HttpPost]
    public IActionResult AddSource(Uri newSource)
    {
        _logger.LogInformation("Added new news source {NewsSource}", newSource);
        return Ok(newSource);
    }

    [HttpDelete]
    public IActionResult DeleteSource(Uri source)
    {
        _logger.LogInformation("Delete news source {NewsSource}", source);
        return StatusCode(StatusCodes.Status204NoContent);
    }
}
