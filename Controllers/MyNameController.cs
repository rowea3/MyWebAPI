using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace rowea3WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MyNameController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(new { Name = "Cory Rowe" });
        }
    }
}
