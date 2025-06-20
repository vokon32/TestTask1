using Microsoft.AspNetCore.Mvc;
using TestTask.BLL.Models;
using TestTask.BLL.Models.DTO.Booking;
using TestTask.BLL.Services.Interfaces;
using TestTask.DAL.Models;

namespace TestTask.API.Controllers
{
    public class BookingsController : BaseController<Booking, BookingDto>
    {
        private readonly IBookingService _service;

        public BookingsController(IBookingService service) : base(service)
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

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete([FromRoute] Guid id)
        {
            try
            {
                var data = await _service.Delete(id);
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
