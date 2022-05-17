using Microsoft.AspNetCore.Mvc;

namespace CsPgsql.Controllers;

[ApiController]
[Route("[controller]")]
public class CafeController : ControllerBase
{
    private readonly ILogger<CafeController> _logger;

    public CafeController(ILogger<CafeController> logger)
    {
        _logger = logger;
    }

    
}
