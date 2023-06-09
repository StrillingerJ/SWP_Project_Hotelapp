﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebAPI.Models.DB;

#nullable disable

namespace WebAPI.Migrations
{
    [DbContext(typeof(HotelContext))]
    [Migration("20230309101153_room")]
    partial class room
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Hotel.Room", b =>
                {
                    b.Property<int>("RoomID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("BedCount")
                        .HasColumnType("int");

                    b.Property<bool>("HasBalcony")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("HasKitchen")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("HasTerrace")
                        .HasColumnType("tinyint(1)");

                    b.Property<decimal>("PricePerNight")
                        .HasColumnType("decimal(65,30)");

                    b.HasKey("RoomID");

                    b.ToTable("Rooms");
                });
#pragma warning restore 612, 618
        }
    }
}
