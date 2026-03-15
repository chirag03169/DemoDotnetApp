using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DemoApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {

        [HttpGet]
        [Route("hello")]
        public string GetHello()
        {
            return "Hello from Web API";
        }
    }
}
