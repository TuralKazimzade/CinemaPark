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
    internal class HallConfig : IEntityTypeConfiguration<Hall>
    {
        public void Configure(EntityTypeBuilder<Hall> builder)
        {
            builder
                .HasKey(x => x.Id);

            builder
                .Property(x=>x.HallNumber)
                .IsRequired();

            builder
                .Property(x=> x.SeatCount)
                .IsRequired();
        }
    }
}
