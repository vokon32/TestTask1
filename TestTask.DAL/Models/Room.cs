
namespace TestTask.DAL.Models
{
    public class Room : BaseModel
    {
        public string Name { get; set; } = string.Empty;
        public int Capacity { get; set; }

        public IList<Booking> Bookings { get; set; }


    }
}
