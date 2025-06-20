using TestTask.BLL.Models.DTO.Booking;
using TestTask.DAL.Models;

namespace TestTask.BLL.Services.Interfaces
{
    public interface IBookingService : IBaseService<Booking, BookingDto>
    {
        Task<bool> Create(CreateBookingDto bookingDto);
        Task<bool> Delete(Guid id);
    }
}
