using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnnouncementCategoriesController : ControllerBase
    {
        IAnnouncementCategoryService _announcementCategoryService;
        public AnnouncementCategoriesController(IAnnouncementCategoryService announcementCategoryService)
        {
                _announcementCategoryService = announcementCategoryService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {

            var result = _announcementCategoryService.getAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("getbyid")]
        public IActionResult GetById(int Id)
        {
            var result = _announcementCategoryService.getById(Id);
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
        public IActionResult Add(AnnouncementCategory announcementCategory)
        {
            var result = _announcementCategoryService.add(announcementCategory);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("delete")]
        public IActionResult Delete(AnnouncementCategory announcementCategory)
        {
            var result = _announcementCategoryService.delete(announcementCategory);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("update")]
        public IActionResult Update(AnnouncementCategory announcementCategory)
        {
            var result = _announcementCategoryService.update(announcementCategory);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
