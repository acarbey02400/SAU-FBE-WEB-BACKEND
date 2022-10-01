using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class PrelectorPositionsController : ControllerBase
    {
        IPrelectorPositionService _positionService;
        public PrelectorPositionsController(IPrelectorPositionService positionService)
        {
            _positionService = positionService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {

            var result = _positionService.getAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("getbyid")]
        public IActionResult GetById(int Id)
        {
            var result = _positionService.getById(Id);
            if (result.Success)
            {
                return Ok(result);
            }
            else
            {
                return BadRequest(result);
            }
        }


        [HttpPost("add")]
        public IActionResult Add(PrelectorPosition prelectorPosition)
        {
            var result = _positionService.add(prelectorPosition);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("delete")]
        public IActionResult Delete(PrelectorPosition prelectorPosition)
        {
            var result = _positionService.delete(prelectorPosition);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("update")]
        public IActionResult Update(PrelectorPosition prelectorPosition)
        {
            var result = _positionService.update(prelectorPosition);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getbyprelectorpositiondetails")]
        public IActionResult getByPrelectorPositionDetails()
        {
            var result = _positionService.getByPrelectorPositionDetails();
            if (result.Success)
            {
                return Ok(result);
            }
            else
            {
                return BadRequest(result);
            }
        }

        [HttpGet("getbyprelectorpositiondetailsforprogramid")]
        public IActionResult getByPrelectorPositionDetailsForProgramId(int prgoramId)
        {
            var result = _positionService.getByPrelectorPositionDetailsForProgramId(prgoramId);
            if (result.Success)
            {
                return Ok(result);
            }
            else
            {
                return BadRequest(result);
            }
        }
    }
}
