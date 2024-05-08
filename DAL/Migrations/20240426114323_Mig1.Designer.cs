﻿// <auto-generated />
using System;
using DAL.Concrete.EfCore.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DAL.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240426114323_Mig1")]
    partial class Mig1
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Entity.Concrete.Hall", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("HallNumber")
                        .HasColumnType("int");

                    b.Property<int>("SeatCount")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Halls");
                });

            modelBuilder.Entity("Entity.Concrete.Movie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Director")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("MovieReleaseDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("GETDATE()");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Movies");
                });

            modelBuilder.Entity("Entity.Concrete.Seat", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("HallId")
                        .HasColumnType("int");

                    b.Property<bool>("IsAviable")
                        .HasColumnType("bit");

                    b.Property<int>("SeatNumber")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("HallId");

                    b.ToTable("Seats");
                });

            modelBuilder.Entity("Entity.Concrete.Session", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Date")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("GETDATE()");

                    b.Property<int>("HallId")
                        .HasColumnType("int");

                    b.Property<int>("MovieId")
                        .HasColumnType("int");

                    b.Property<int>("SeatId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("HallId");

                    b.HasIndex("MovieId");

                    b.HasIndex("SeatId")
                        .IsUnique();

                    b.ToTable("Sessions");
                });

            modelBuilder.Entity("Entity.Concrete.Ticket", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<DateTime>("PurchaseDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("GETDATE()");

                    b.Property<int>("SeatNumber")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Tickets");
                });

            modelBuilder.Entity("Entity.Concrete.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("TicketId")
                        .HasColumnType("int");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("TicketId")
                        .IsUnique();

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Entity.Concrete.Seat", b =>
                {
                    b.HasOne("Entity.Concrete.Hall", "Hall")
                        .WithMany("Seats")
                        .HasForeignKey("HallId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Hall");
                });

            modelBuilder.Entity("Entity.Concrete.Session", b =>
                {
                    b.HasOne("Entity.Concrete.Hall", "Hall")
                        .WithMany("Session")
                        .HasForeignKey("HallId")
                        .IsRequired();

                    b.HasOne("Entity.Concrete.Movie", "Movie")
                        .WithMany("Sessions")
                        .HasForeignKey("MovieId")
                        .IsRequired();

                    b.HasOne("Entity.Concrete.Seat", "Seat")
                        .WithOne("Session")
                        .HasForeignKey("Entity.Concrete.Session", "SeatId")
                        .IsRequired();

                    b.Navigation("Hall");

                    b.Navigation("Movie");

                    b.Navigation("Seat");
                });

            modelBuilder.Entity("Entity.Concrete.User", b =>
                {
                    b.HasOne("Entity.Concrete.Ticket", "Ticket")
                        .WithOne("User")
                        .HasForeignKey("Entity.Concrete.User", "TicketId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Ticket");
                });

            modelBuilder.Entity("Entity.Concrete.Hall", b =>
                {
                    b.Navigation("Seats");

                    b.Navigation("Session");
                });

            modelBuilder.Entity("Entity.Concrete.Movie", b =>
                {
                    b.Navigation("Sessions");
                });

            modelBuilder.Entity("Entity.Concrete.Seat", b =>
                {
                    b.Navigation("Session")
                        .IsRequired();
                });

            modelBuilder.Entity("Entity.Concrete.Ticket", b =>
                {
                    b.Navigation("User")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
