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

        //postman body json raw
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
        [HttpGet("MakeArrayConsecutive2")]
        public ActionResult<int> MakeArrayConsecutive2([FromBody] int[] statues)
        {
            int result = _edgeOfTheOceanService.MakeArrayConsecutive2(statues);
            return Ok(result);
        }
        [HttpGet("AlmostIncreasingSequence")]
        public ActionResult<bool> AlmostIncreasingSequence([FromBody] int[] sequence)
        {
            bool result = _edgeOfTheOceanService.AlmostIncreasingSequence(sequence);
            return Ok(result);
        }
        [HttpGet("MatrixElementsSum")]
        public ActionResult<bool> MatrixElementsSum([FromBody] int[][] matrix)
        {
            int result = _edgeOfTheOceanService.MatrixElementsSum(matrix);
            return Ok(result);
        }
        
    }
}
