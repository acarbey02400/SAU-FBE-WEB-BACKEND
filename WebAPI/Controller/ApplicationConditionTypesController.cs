using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApplicationConditionTypesController : ControllerBase
    {
        IApplicationConditionTypeService _applicationConditionTypeService;
        public ApplicationConditionTypesController(IApplicationConditionTypeService applicationConditionTypeService)
        {
            _applicationConditionTypeService = applicationConditionTypeService;
        }
        [HttpGet("getall")]
        public IActionResult GetAll()
        {

            var result = _applicationConditionTypeService.getAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("getbyid")]
        public IActionResult GetById(int Id)
        {
            var result = _applicationConditionTypeService.getById(Id);
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
        public IActionResult Add(ApplicationConditionType applicationConditionType)
        {
            var result = _applicationConditionTypeService.add(applicationConditionType);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("delete")]
        public IActionResult Delete(ApplicationConditionType applicationConditionType)
        {
            var result = _applicationConditionTypeService.delete(applicationConditionType);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("update")]
        public IActionResult Update(ApplicationConditionType applicationConditionType)
        {
            var result = _applicationConditionTypeService.update(applicationConditionType);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
