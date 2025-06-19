using TestTask.BLL.Models.DTO.Room;
using TestTask.DAL.Models;

namespace TestTask.BLL.Services.Interfaces
{
    public interface IRoomService : IBaseService<Room, RoomDto>
    {
        Task<bool> Create(CreateRoomDto createRoomDto); 
    }
}
