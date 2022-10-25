using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class MainTitlesController : ControllerBase
    {
        IMainTitleService _mainTitleService;
        public MainTitlesController(IMainTitleService mainTitleService)
        {
            _mainTitleService = mainTitleService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {

            var result = _mainTitleService.getAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("getbyid")]
        public IActionResult GetById(int Id)
        {
            var result = _mainTitleService.getById(Id);
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
        public IActionResult Add(MainTitle mainTitle)
        {
            var result = _mainTitleService.add(mainTitle);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("delete")]
        public IActionResult Delete(MainTitle mainTitle)
        {
            var result = _mainTitleService.delete(mainTitle);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("update")]
        public IActionResult Update(MainTitle mainTitle)
        {
            var result = _mainTitleService.update(mainTitle);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
