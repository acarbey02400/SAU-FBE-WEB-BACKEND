using Business.Abstract;
using Core.Entities.Concrete;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;

namespace WebAPI.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnnouncementsController : ControllerBase
    {
        IAnnouncementService _announcementService;
        public AnnouncementsController(IAnnouncementService announcementService)
        {
            _announcementService = announcementService;
        }
        [HttpGet("getall")]
        public IActionResult GetAll()
        {

            var result = _announcementService.getAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("getbyid")]
        public IActionResult GetById(int Id)
        {
            var result = _announcementService.getById(Id);
            if (result.Success)
            {
                return Ok(result);
            }
            else
            {
                return BadRequest(result);
            }
        }

        [HttpGet("getbystartdate")]
        public IActionResult getByStartDate(DateTime date)
        {
            var result = _announcementService.GetByStartDate(date);
            if (result.Success)
            {
                return Ok(result);
            }
            else
            {
                return BadRequest(result);
            }
        }


        [HttpGet("getbystopdate")]
        public IActionResult getByStopDate(DateTime date)
        {
            var result = _announcementService.GetByStopDate(date);
            if (result.Success)
            {
                return Ok(result);
            }
            else
            {
                return BadRequest(result);
            }
        }

        [HttpGet("getByActiveAnnouncement")]
        public IActionResult getByActiveAnnouncement()
        {
            var result = _announcementService.getByActiveAnnouncement();
            if (result.Success)
            {
                return Ok(result);
            }
            else
            {
                return BadRequest(result);
            }
        }

        [HttpGet("getByInActiveAnnouncement")]
        public IActionResult getByInActiveAnnouncement()
        {
            var result = _announcementService.getByInActiveAnnouncement();
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
        public IActionResult Add(Announcement announcement)
        {
            var result = _announcementService.add(announcement);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("update")]
        public IActionResult Update(Announcement announcement)
        {
            var result = _announcementService.update(announcement);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("delete")]
        public IActionResult Delete(Announcement announcement)
        {
            var result = _announcementService.delete(announcement);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

    }
}
