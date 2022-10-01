using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProgramsController : ControllerBase
    {
        IProgramService _programService;
        public ProgramsController(IProgramService programService)
        {
            _programService = programService;
        }
        [HttpGet("getall")]
        public IActionResult GetAll()
        {

            var result = _programService.getAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("getbyid")]
        public IActionResult GetById(int Id)
        {
            var result = _programService.getById(Id);
            if (result.Success)
            {
                return Ok(result);
            }
            else
            {
                return BadRequest(result);
            }
        }

        [HttpGet("getbyacademicdegreeid")]
        public IActionResult GetByAcademicDegreeId(int Id)
        {
            var result = _programService.getByAcademicDegreeId(Id);
            if (result.Success)
            {
                return Ok(result);
            }
            else
            {
                return BadRequest(result);
            }
        }
        [HttpGet("getbyebsid")]
        public IActionResult GetByEbsId(int Id)
        {
            var result = _programService.getByEbsId(Id);
            if (result.Success)
            {
                return Ok(result);
            }
            else
            {
                return BadRequest(result);
            }
        }
        [HttpGet("getbycategoryid")]
        public IActionResult GetByCategoryId(int Id)
        {
            var result = _programService.getByCategoryId(Id);
            if (result.Success)
            {
                return Ok(result);
            }
            else
            {
                return BadRequest(result);
            }
        }
        [HttpGet("getbydepartmentid")]
        public IActionResult GetByDepartmentId(int Id)
        {
            var result = _programService.getByDepartmentId(Id);
            if (result.Success)
            {
                return Ok(result);
            }
            else
            {
                return BadRequest(result);
            }
        }
        [HttpGet("getbyprgramdetails")]
        public IActionResult GetByProgramDetails()
        {
            var result = _programService.getByProgramDetail();
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
        public IActionResult Add(Entities.Concrete.Program program)
        {
            var result = _programService.add(program);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("delete")]
        public IActionResult Delete(Entities.Concrete.Program program)
        {
            var result = _programService.delete(program);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("update")]
        public IActionResult Update(Entities.Concrete.Program program)
        {
            var result = _programService.update(program);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
