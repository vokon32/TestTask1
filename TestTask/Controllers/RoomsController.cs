using Microsoft.AspNetCore.Mvc;
using TestTask.BLL.Models;
using TestTask.BLL.Models.DTO.Room;
using TestTask.BLL.Services.Interfaces;
using TestTask.DAL.Models;

namespace TestTask.API.Controllers
{
    public class RoomsController : BaseController<Room, RoomDto>
    {
        private readonly IRoomService _service;

        public RoomsController(IRoomService service) : base(service)
        {
            _service = service;
        }


        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateRoomDto createRoomDto)
        {
            try
            {
                var data = await _service.Create(createRoomDto);
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
