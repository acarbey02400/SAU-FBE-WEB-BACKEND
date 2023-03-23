using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubTitlesController : ControllerBase
    {
        ISubTitleService _subTitleService;
        public SubTitlesController(ISubTitleService subTitleService)
        {
            _subTitleService = subTitleService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {

            var result = _subTitleService.getAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("getbyid")]
        public IActionResult GetById(int Id)
        {
            var result = _subTitleService.getById(Id);
            if (result.Success)
            {
                return Ok(result);
            }
            else
            {
                return BadRequest(result);
            }
        }

        [HttpGet("getbymaintitleid")]
        public IActionResult GetByMainTitleId(int Id)
        {
            var result = _subTitleService.getByMainTitleId(Id);
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
        public IActionResult Add(SubTitle subTitle)
        {
            var result = _subTitleService.add(subTitle);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("delete")]
        public IActionResult Delete(SubTitle subTitle)
        {
            var result = _subTitleService.delete(subTitle);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("update")]
        public IActionResult Update(SubTitle subTitle)
        {
            var result = _subTitleService.update(subTitle);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
