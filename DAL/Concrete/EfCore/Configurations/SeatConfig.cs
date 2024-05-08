using Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Concrete.EfCore.Configurations
{
    internal class SeatConfig : IEntityTypeConfiguration<Seat>
    {
        public void Configure(EntityTypeBuilder<Seat> builder)
        {
            builder
                .HasKey(x => x.Id);

            builder
                .Property(x => x.SeatNumber)
                .IsRequired();

            builder
                .HasOne(x => x.Hall)
                .WithMany(x => x.Seats)
                .HasForeignKey(x => x.HallId);

          
              

               
        }
    }
}
