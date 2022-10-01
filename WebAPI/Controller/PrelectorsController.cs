using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class PrelectorsController : ControllerBase
    {
        IPrelectorService _prelectorService;
        public PrelectorsController(IPrelectorService prelectorService)
        {
            _prelectorService = prelectorService;
        }
        [HttpGet("getall")]
        public IActionResult GetAll()
        {

            var result = _prelectorService.getAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("getbyid")]
        public IActionResult GetById(int Id)
        {
            var result = _prelectorService.getById(Id);
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
        public IActionResult Add(Prelector prelector)
        {
            var result = _prelectorService.add(prelector);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("delete")]
        public IActionResult Delete(Prelector prelector)
        {
            var result = _prelectorService.delete(prelector);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("update")]
        public IActionResult Update(Prelector prelector)
        {
            var result = _prelectorService.update(prelector);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
