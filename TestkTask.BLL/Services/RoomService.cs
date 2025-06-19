
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using TestTask.BLL.Models.DTO.Room;
using TestTask.BLL.Services.Interfaces;
using TestTask.DAL.Data;
using TestTask.DAL.Models;

namespace TestTask.BLL.Services
{
    public class RoomService : BaseService<Room, RoomDto>, IRoomService
    {
        private readonly ApplicationDbContext _context;

        public RoomService(ApplicationDbContext context, IMapper mapper) : base(context, mapper)
        {
            _context = context;
        }

        public async Task<bool> Create(CreateRoomDto createRoomDto)
        {
            if (createRoomDto.Capacity <= 0)
            {

                throw new Exception($"Capacity {createRoomDto.Capacity} cannot be less then 0!");
            }

            var room = new Room
            {

                Capacity = createRoomDto.Capacity,
                Name = createRoomDto.Name
            };

            await _context.Rooms.AddAsync(room);
            return await _context.SaveChangesAsync() > 0;
        }
    }
}
