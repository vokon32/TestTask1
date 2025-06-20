
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using TestTask.BLL.Models.DTO.Booking;
using TestTask.BLL.Models.DTO.Room;
using TestTask.BLL.Services.Interfaces;
using TestTask.DAL.Data;
using TestTask.DAL.Models;

namespace TestTask.BLL.Services
{
    public class BookingService : BaseService<Booking, BookingDto>, IBookingService
    {
        private readonly ApplicationDbContext _context;

        public BookingService(ApplicationDbContext context, IMapper mapper) : base(context, mapper)
        {
            _context = context;
        }

        public async Task<bool> Create(CreateBookingDto bookingDto)
        {
            if (!await _context.Rooms.AnyAsync(r => r.Id != bookingDto.RoomId && !r.IsDeleted))
            {
                throw new Exception("Cannot find the room!");
            }

            if (!await _context.Users.AnyAsync(r => r.Id != bookingDto.UserId && !r.IsDeleted))
            {
                throw new Exception("Cannot find the user!");
            }

            if (bookingDto.StartTime <= DateTime.Now)
            {
                throw new Exception("Cannot book in the past!");
            }

            if (await _context.Bookings.AnyAsync(b => b.RoomId == bookingDto.RoomId &&
        b.StartTime <= bookingDto.EndTime &&
        b.EndTime >= bookingDto.StartTime))
            {
                throw new Exception("The room is already taken!");
            }

            var booking = new Booking
            {
                StartTime = bookingDto.StartTime,
                EndTime = bookingDto.EndTime,
                UserId = bookingDto.UserId,
                RoomId = bookingDto.RoomId
            };

            await _context.Bookings.AddAsync(booking);

            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<bool> Delete(Guid id)
        {
            var booking = await _context.Bookings.Where(b => !b.IsDeleted).FirstOrDefaultAsync();

            if (booking is null)
            {
                throw new Exception("The Booking was not found!");
            }

            booking.IsDeleted = true;
            booking.DateUpdated = DateTime.UtcNow;

            _context.Bookings.Update(booking);

            return await _context.SaveChangesAsync() > 0;
        }
    }
}
