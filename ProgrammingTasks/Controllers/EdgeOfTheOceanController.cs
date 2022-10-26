using Microsoft.AspNetCore.Mvc;
using ProgrammingTasks.Services;

namespace ProgrammingTasks.Controllers
{
    [ApiController]
    [Route("api/edgeOfTheOcean")]
    public class EdgeOfTheOceanController : ControllerBase
    {
        private readonly IEdgeOfTheOceanService _edgeOfTheOceanService;

        public EdgeOfTheOceanController(IEdgeOfTheOceanService edgeOfTheOceanService)
        {
            _edgeOfTheOceanService = edgeOfTheOceanService;
        }

        //["3", "6", "-2", "-5", "7", "3"] postman body json raw
        [HttpGet("adjacentElementsProduct")]
        public ActionResult<int> AdjacentElementsProduct([FromBody] int[] inputArray)
        {
            int result = _edgeOfTheOceanService.AdjacentElementsProduct(inputArray);
            return Ok(result);
        }
        [HttpGet("shapeArea/{n}")]
        public ActionResult<int> ShapeArea([FromRoute] int n)
        {
            int result = _edgeOfTheOceanService.ShapeArea(n);
            return Ok(result);
        }
    }
}
