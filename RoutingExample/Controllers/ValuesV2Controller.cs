using Microsoft.AspNetCore.Mvc;

namespace RoutingExample.Controllers
{
    
    [ApiController]
    //Raj added this
    [ApiVersion("2.0")]
    [Route("api/v{version:apiVersion}/Values")]
    public class ValuesV2Controller : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public ActionResult<string> Get()
        {
            return "V 2";
        }
    }
}
