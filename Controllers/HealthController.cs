using Microsoft.AspNetCore.Mvc;
using System;

namespace App.Controllers;

[ApiController]
[Route("api/[controller]")]
public class HealthController : ControllerBase
{
    [HttpGet]
    public IActionResult Check() => Ok(new { status = "healthy", timestamp = DateTime.UtcNow });
}
