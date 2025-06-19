
using Microsoft.EntityFrameworkCore;
using TestTask.DAL.Configurations;
using TestTask.DAL.Models;

namespace TestTask.DAL.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Room> Rooms{ get; set; }
        public DbSet<Booking> Bookings{ get; set; }

        //dotnet ef migrations add InitialCreate --startup-project ./TestTask --project ./TestTask.DAL --output-dir Migrations
        //dotnet ef database update --startup-project ./TestTask --project ./TestTask.DAL
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);
        }
    }
}
