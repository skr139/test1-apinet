using Microsoft.AspNetCore.Mvc;

namespace test1.Controllers;

[ApiController]
[Route("fruits")]
public class WeatherForecastController : ControllerBase
{
    private static readonly Fruit[] fruits = new Fruit[]
    {
        new Fruit { Name = "Apple", Description = "A sweet red fruit" },
        new Fruit { Name = "Banana", Description = "A long yellow fruit" },
        new Fruit { Name = "Orange", Description = "A round citrus fruit" },
        new Fruit { Name = "Grapes", Description = "Small round fruits often found in bunches" },
        new Fruit { Name = "Mango", Description = "A tropical stone fruit with a sweet taste" },
        new Fruit { Name = "Pineapple", Description = "A tropical fruit with a spiky exterior and sweet interior" },
        new Fruit { Name = "Strawberry", Description = "A red fruit with tiny seeds on its surface" },
        new Fruit { Name = "Blueberry", Description = "A small blue fruit often used in desserts" },
    };

    private readonly ILogger<WeatherForecastController> _logger;

    public WeatherForecastController(ILogger<WeatherForecastController> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    [Route("all-fruits")]
    public ActionResult<IEnumerable<Fruit>> GetAllFruits()
    {
        return Ok(fruits);
    }
}
