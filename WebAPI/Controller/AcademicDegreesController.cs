using Business.Abstract;
using Core.Entities.Concrete;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class AcademicDegreesController : ControllerBase
    {
        IAcademicDegreeService _academicDegreeService;
        public AcademicDegreesController(IAcademicDegreeService academicDegreeService)
        {
            _academicDegreeService = academicDegreeService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {

            var result = _academicDegreeService.getAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("getbyid")]
        public IActionResult GetById(int Id)
        {
            var result = _academicDegreeService.getById(Id);
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
        public IActionResult Add(AcademicDegree academicDegree)
        {
            var result = _academicDegreeService.add(academicDegree);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("delete")]
        public IActionResult Delete(AcademicDegree academicDegree)
        {
            var result = _academicDegreeService.delete(academicDegree);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("update")]
        public IActionResult Update(AcademicDegree academicDegree)
        {
            var result = _academicDegreeService.update(academicDegree);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
