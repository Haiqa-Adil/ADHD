using ADHD.Dto.booking;
using ADHD.Models.booking;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Nancy.Json;

namespace ADHD.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BookingController : Controller
    {
        public IMapper _mapper;

        public BookingController(IMapper mapper)
        {
            _mapper = mapper;
        }


        [HttpPost("booking")]
        public async Task<IActionResult> Booking([FromBody]BookingDto bookingDto)
        {
            var bookingModel = _mapper.Map<Booking>(bookingDto);
            var personalInfo = new JavaScriptSerializer().Serialize(bookingDto.PatientInfo);
            bookingModel.PatientInfo = personalInfo;
            return Ok(bookingModel);
        }

        [HttpPost("booking/reschedule")]
        public async Task<IActionResult> BookingReschedule([FromBody] BookingRescheduleDto bookingRescheduleDto)
        {
            var bookingModel = _mapper.Map<BookingReschedule>(bookingRescheduleDto);

            var sessionIds = new JavaScriptSerializer().Serialize(bookingRescheduleDto.SessionIds);
            var newSessionIds = new JavaScriptSerializer().Serialize(bookingRescheduleDto.NewSessionIds);
            
            bookingModel.SessionIds = sessionIds;
            bookingModel.NewSessionIds = newSessionIds;
            return Ok(bookingModel);
        }

        [HttpPost("booking/session")]
        public async Task<IActionResult> BookingSession([FromBody] BookingSessionDto bookingSessionDto)
        {
            var bookingModel = _mapper.Map<BookingSession>(bookingSessionDto);
            return Ok(bookingModel);
        }
    }
}
