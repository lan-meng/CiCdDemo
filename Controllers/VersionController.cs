using Microsoft.AspNetCore.Mvc;

namespace CiCdDemo.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class VersionController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(new
            {
                Version = "1.0.2"
                BuildTime = DateTime.Now
            });
        }
    }
}
