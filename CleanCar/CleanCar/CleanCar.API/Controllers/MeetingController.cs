using AutoMapper;
using CleanCar.API.Models;
using CleanCar.Core;
using CleanCar.Core.DTOs;
using CleanCar.Core.Models;
using CleanCar.Core.Services;
using CleanCar.Service;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CleanCar.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MeetingController : ControllerBase
    {

        private readonly IMeetingService _meetingService;
        private readonly IMapper _mapper;


        public MeetingController(IMeetingService meetingService, IMapper mapper)
        {
            _meetingService = meetingService;
            _mapper = mapper;
        }


        // GET all the Meetings
        [HttpGet]
        public IEnumerable<Meeting> Get()
        {
            return _meetingService.GetAll();
        }


        // GET by Id
        [HttpGet("{id}")]
        public ActionResult<MeetingDTO> Get(int id)
        {
            var meeting = _meetingService.GetById(id);
            if (meeting == null)
            {
                return NotFound();
            }

            var meetingDto = _mapper.Map<MeetingDTO>(meeting);
            return Ok(meetingDto);
        }


        // POST add meeting
        [HttpPost]
        public async Task<ActionResult> PostAsync([FromBody] MeetingPostModel meeting)//כעקרון גם פה אפשר להשתמש בmapping אבל למען הסדר של הלימוד אשאיר את זה 

        {
            var meetingToAdd = new Meeting { Id = meeting.Id, Body = meeting.Body, Title = meeting.Title, Email = meeting.Email, Phone = meeting.Phone, Name_User = meeting.Name_User };
            return Ok(await _meetingService.AddAsync(meetingToAdd)
 );
        }

        // PUT By meeting and By Id
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Meeting meeting)
        {
            _meetingService.Update(meeting, id);
        }

        // DELETE By Id
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _meetingService.Delete(id);
        }
    }
}
