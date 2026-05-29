using Microsoft.AspNetCore.Mvc;
using App.Models;

namespace App.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ProductsController : ControllerBase
{
    [HttpGet]
    public IActionResult Get()
    {
        var products = new[]
        {
            new Product { Id = 1, Name = "Laptop", Price = 1200 },
            new Product { Id = 2, Name = "Mouse", Price = 25 }
        };
        return Ok(products);
    }
}
