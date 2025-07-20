using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace JwtAuthApi.Controllers  
{
    [ApiController]
    [Route("api/[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        [HttpGet]
        [Authorize] 
        public IActionResult Get()
        {
            return Ok("This is a protected WeatherForecast endpoint.");
        }
    }
}
