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
    internal class SessionConfig : IEntityTypeConfiguration<Session>
    {
        public void Configure(EntityTypeBuilder<Session> builder)
        {
            builder
                .HasKey(x => x.Id);

            builder
                .Property(x => x.Date)
                .HasDefaultValueSql("GETDATE()");

            builder
                .HasOne(x => x.Seat)
                .WithOne(x => x.Session)
                .HasForeignKey<Session>(x => x.SeatId)
                .OnDelete(DeleteBehavior.ClientSetNull);
                

            builder
                .HasOne(x=>x.Movie)
                .WithMany(x=>x.Sessions)
                .HasForeignKey(x => x.MovieId)
                .OnDelete(DeleteBehavior.ClientSetNull);

            builder
                .HasOne(x => x.Hall)
                .WithMany(x => x.Session)
                .HasForeignKey(x => x.HallId)
                .OnDelete(DeleteBehavior.ClientSetNull);
                
               
                
        }
    }
}
