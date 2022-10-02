using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class PagesController : ControllerBase
    {
        IPageService _pageService;
        public PagesController(IPageService pageService)
        {
            _pageService = pageService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {

            var result = _pageService.getAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("getbyid")]
        public IActionResult GetById(int Id)
        {
            var result = _pageService.getById(Id);
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
        public IActionResult GetByCategoryId(int categroyId)
        {
            var result = _pageService.getByCategoryId(categroyId);
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
        public IActionResult GetByMainTitleId(int mainTitleId)
        {
            var result = _pageService.getById(mainTitleId);
            if (result.Success)
            {
                return Ok(result);
            }
            else
            {
                return BadRequest(result);
            }
        }

        [HttpGet("getbysubtitleid")]
        public IActionResult GetBySubTitleId(int subTitleId)
        {
            var result = _pageService.getBySubTitleId(subTitleId);
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
        public IActionResult Add(Page page)
        {
            var result = _pageService.add(page);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("delete")]
        public IActionResult Delete(Page page)
        {
            var result = _pageService.delete(page);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("update")]
        public IActionResult Update(Page page)
        {
            var result = _pageService.update(page);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

    }
}
