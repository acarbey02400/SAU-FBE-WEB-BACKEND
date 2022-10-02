using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApplicationConditionsController : ControllerBase
    {
        IApplicationConditionService _applicationConditionService;
        public ApplicationConditionsController(IApplicationConditionService applicationConditionService)
        {
            _applicationConditionService = applicationConditionService;
        }
        [HttpGet("getall")]
        public IActionResult GetAll()
        {

            var result = _applicationConditionService.getAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("getbyid")]
        public IActionResult GetById(int Id)
        {
            var result = _applicationConditionService.getById(Id);
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
        public IActionResult Add(ApplicationCondition applicationCondition)
        {
            var result = _applicationConditionService.add(applicationCondition);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("delete")]
        public IActionResult Delete(ApplicationCondition applicationCondition)
        {
            var result = _applicationConditionService.delete(applicationCondition);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("update")]
        public IActionResult Update(ApplicationCondition applicationCondition)
        {
            var result = _applicationConditionService.update(applicationCondition);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
