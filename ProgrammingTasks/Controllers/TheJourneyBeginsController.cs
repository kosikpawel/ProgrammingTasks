using Microsoft.AspNetCore.Mvc;

namespace ProgrammingTasks.Controllers
{
    [ApiController]
    [Route("TheJourneyBegins")]
    public class TheJourneyBeginsController : ControllerBase
    {
        [HttpGet("add/{param1}/{param2}")]
        public ActionResult<int> Add([FromRoute] int param1, [FromRoute] int param2)
        {
            int result = param1 + param2;
            return Ok(result);
        }

        [HttpGet("centuryFromYear/{year}")]
        public ActionResult<int> CenturyFromYear([FromRoute] int year)
        {
            int century, modulo;
            century = (year / 100);
            modulo = (year % 100);

            int result = modulo == 0 ? century : century + 1;

            return Ok(result);
        }
    }
}
