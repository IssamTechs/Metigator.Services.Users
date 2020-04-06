using Microsoft.AspNetCore.Mvc;
namespace Metigator.Services.Users.Controllers
{
    [ApiController]
    [Route("")]
    public class HomeController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get() => Ok("Metigator Users Service");
    }
}
