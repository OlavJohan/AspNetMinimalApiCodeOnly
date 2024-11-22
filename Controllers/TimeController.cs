using Microsoft.AspNetCore.Mvc;

namespace AspNetMinimalApiCodeOnly.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TimeController : ControllerBase
    {

        [HttpGet]
        public string Get()
        {
            return $"Klokken er {DateTime.Now:hh:mm:ss}";
        }
    }
}
