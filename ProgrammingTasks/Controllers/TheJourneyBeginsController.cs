using Microsoft.AspNetCore.Mvc;

namespace ProgrammingTasks.Controllers
{
    [ApiController]
    [Route("TheJourneyBegins")]
    public class TheJourneyBeginsController : ControllerBase
    {
        [HttpGet("{param1}/{param2}")]
        public ActionResult<int> Add([FromRoute] int param1, [FromRoute] int param2)
        {
            int result = param1 + param2;
            return Ok(result);
        }
    }
}
