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
    internal class UserConfig : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder
                .HasKey(x => x.Id);

            builder
                .Property(x => x.UserName)
                .IsRequired()
                .HasMaxLength(50);

            builder
                .Property (x => x.Email)
                .HasMaxLength(50)
                .IsRequired();

            builder
                .HasOne(x => x.Ticket)
                .WithOne(x => x.User)
                .HasForeignKey<User>(x => x.TicketId);
        }
    }
}
