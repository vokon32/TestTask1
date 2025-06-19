using TestTask.BLL.Models.DTO.Room;
using TestTask.DAL.Models;

namespace TestTask.BLL.Models.DTO.Booking
{
    public class BookingDto
    {
        public Guid Id { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public Guid UserId { get; set; }
        public UserDto User { get; set; }
        public Guid RoomId { get; set; }
        public RoomDto Room { get; set; }
    }
}
