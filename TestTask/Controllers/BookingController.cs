using Microsoft.AspNetCore.Mvc;
using TestTask.BLL.Models;
using TestTask.BLL.Models.DTO.Booking;
using TestTask.BLL.Models.DTO.Room;
using TestTask.BLL.Services.Interfaces;
using TestTask.DAL.Models;

namespace TestTask.API.Controllers
{
    public class BookingController : BaseController<Booking, BookingDto>
    {
        private readonly IBookingService _service;

        public BookingController(IBookingService service) : base(service)
        {
            _service = service;
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateBookingDto bookingDto)
        {
            try
            {
                var data = await _service.Create(bookingDto);
                return Ok(new ApiResponse<bool>()
                {
                    Data = data,
                    Error = string.Empty,
                });
            }
            catch (Exception ex)
            {
                return BadRequest(new ApiResponse<bool>()
                {
                    Data = false,
                    Error = ex.Message,
                });
            }
        }
    }
}
