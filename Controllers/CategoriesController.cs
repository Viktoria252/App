using Microsoft.AspNetCore.Mvc;
using App.Models;

namespace App.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CategoriesController : ControllerBase
{
    [HttpGet]
    public IActionResult Get()
    {
        var categories = new[]
        {
            new Category { Id = 1, Name = "Electronics" },
            new Category { Id = 2, Name = "Accessories" }
        };
        return Ok(categories);
    }
}
