
namespace TestTask.DAL.Models
{
    public class BaseModel
    {
        public Guid Id { get; set; }
        public DateTime DateCreated { get; set; }

        public DateTime DateUpdated { get; set; }
        public bool IsDeleted { get; set; } = false;
    }
}
