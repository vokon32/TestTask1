
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TestTask.DAL.Data;
using TestTask.DAL.Models;

namespace TestTask.DAL.Configurations
{
    internal class RoomConfiguration : IEntityTypeConfiguration<Room>
    {
        public void Configure(EntityTypeBuilder<Room> builder)
        {
            builder.HasKey(r => r.Id);

            builder.Property(r => r.Name)
                   .IsRequired()
                   .HasMaxLength(100);

            builder.Property(r => r.Capacity)
                   .IsRequired();

            builder.HasData(
     new Room { Id = ConstData.Room1, Name = "Conference Room A", Capacity = 10 },
     new Room { Id = ConstData.Room2, Name = "Meeting Room B", Capacity = 5 }
 );
        }


    }
}
