using Microsoft.AspNetCore.Mvc;

namespace RoutingExample.Controllers
{   
    [ApiController]
    //Raj added this, if not there already
    [Route("api/[controller]")]
    public class ValuesController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public ActionResult<string> Get()
        {
            return "V 1";
        }
    }
}
