using Microsoft.AspNetCore.Mvc;
using CsPgsql.Data;

namespace CsPgsql.Controllers;

[ApiController]
[Route("[controller]")]
public class CafeController : ControllerBase
{
    private readonly ILogger<CafeController> _logger;
    private readonly CafeContext _context;

    public CafeController(ILogger<CafeController> logger, CafeContext context)
    {
        _logger = logger;
        _context = context;
    }

    [HttpGet]
    public async Task<IActionResult> Get()
    {
        _logger.LogInformation("Cafe-DB");
        var result = _context.menu.ToList();
        _logger.LogInformation("Cafe-End");

        return Ok("Alive");
    }
}
