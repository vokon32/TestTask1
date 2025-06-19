
namespace TestTask.BLL.Models.DTO.Booking
{
    public class CreateBookingDto
    {
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public Guid UserId { get; set; }
        public Guid RoomId { get; set; }
    }
}
