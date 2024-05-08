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
    internal class TicketConfig : IEntityTypeConfiguration<Ticket>
    {
        public void Configure(EntityTypeBuilder<Ticket> builder)
        {
            builder
                .HasKey(x => x.Id);

            builder
                .Property(x => x.SeatNumber)
                .IsRequired();

            builder
                .Property(x=> x.Price)
                .IsRequired();

            builder
                .Property(x => x.PurchaseDate)
                .HasDefaultValueSql("GETDATE()");
        }
    }
}
