using Microsoft.AspNetCore.Mvc;
using ProgrammingTasks.Services;
using System.Linq;

namespace ProgrammingTasks.Controllers
{
    [ApiController]
    [Route("api/theJourneyBegins")]
    public class TheJourneyBeginsController : ControllerBase
    {
        private readonly ITheJourneyBeginsService _theJourneyBeginsService;
        public TheJourneyBeginsController(ITheJourneyBeginsService theJourneyBeginsService)
        {
            _theJourneyBeginsService = theJourneyBeginsService;
        }

        [HttpGet("add/{param1}/{param2}")]
        public ActionResult<int> Add([FromRoute] int param1, [FromRoute] int param2)
        {
            int result = _theJourneyBeginsService.Add(param1, param2);
            return Ok(result);
        }

        [HttpGet("centuryFromYear/{year}")]
        public ActionResult<int> CenturyFromYear([FromRoute] int year)
        { 
            int result = _theJourneyBeginsService.CenturyFromYear(year);

            return Ok(result);
        }

        [HttpGet("checkPalindrome/{inputString}")]
        public ActionResult<bool> CheckPalindrome([FromRoute] string inputString)
        {
            bool result = _theJourneyBeginsService.CheckPalindrome(inputString);
            return Ok(result);
        }
    }
}
