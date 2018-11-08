using Microsoft.AspNetCore.Mvc;

namespace MsalDemo.WebApi.Controllers
{
    [Route("api/values")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        public ActionResult Get()
        {
            return Ok("Hello world");
        }

    }
}