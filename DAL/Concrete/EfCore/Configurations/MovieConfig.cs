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
    internal class MovieConfig : IEntityTypeConfiguration<Movie>
    {
        public void Configure(EntityTypeBuilder<Movie> builder)
        {
            builder
                .HasKey(x => x.Id);

            builder
                .Property(x => x.Name)
                .IsRequired()
                .HasMaxLength(50);

            builder
                .Property(x=> x.Director)
                .HasMaxLength(50)
                .IsRequired();

            builder
                .Property(x => x.MovieReleaseDate)
                .IsRequired()
                .HasDefaultValueSql("GETDATE()");

            builder
                .Property(x=>x.Description)
                .IsRequired()
                .HasMaxLength(50);

        }
    }
}
