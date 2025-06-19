
using AutoMapper;
using TestTask.BLL.Models.DTO;
using TestTask.BLL.Models.DTO.Booking;
using TestTask.BLL.Models.DTO.Room;
using TestTask.DAL.Models;

namespace TestTask.BLL.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<User, UserDto>().ReverseMap();
            CreateMap<Room, RoomDto>().ReverseMap();
            CreateMap<Booking, BookingDto>().ReverseMap();
        }
    }
}
