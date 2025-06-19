using TestTask.BLL.Models.DTO.Booking;
using TestTask.DAL.Models;

namespace TestTask.BLL.Models.DTO.Room
{
    public class RoomDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public int Capacity { get; set; }

        public IList<BookingDto> Bookings { get; set; }
        public bool IsDeleted { get; set; }
    }
}
