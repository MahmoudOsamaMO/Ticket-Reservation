﻿// <auto-generated />
using System;
using Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Infrastructure.Migrations
{
    [DbContext(typeof(WakeCapContext))]
    [Migration("20220906000015_rowVersion")]
    partial class rowVersion
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Infrastructure.Models.Seat", b =>
                {
                    b.Property<int>("seatId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("seatId"), 1L, 1);

                    b.Property<byte[]>("Timestamp")
                        .IsConcurrencyToken()
                        .IsRequired()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("rowversion");

                    b.Property<string>("busId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("isReserved")
                        .HasColumnType("bit");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("tripId")
                        .HasColumnType("int");

                    b.HasKey("seatId");

                    b.HasIndex("tripId");

                    b.ToTable("Seat");

                    b.HasData(
                        new
                        {
                            seatId = 1,
                            busId = "bus1",
                            isReserved = true,
                            name = "A01",
                            tripId = 1
                        },
                        new
                        {
                            seatId = 2,
                            busId = "bus1",
                            isReserved = true,
                            name = "A02",
                            tripId = 1
                        },
                        new
                        {
                            seatId = 3,
                            busId = "bus1",
                            isReserved = true,
                            name = "A03",
                            tripId = 2
                        },
                        new
                        {
                            seatId = 4,
                            busId = "bus1",
                            isReserved = true,
                            name = "A04",
                            tripId = 2
                        },
                        new
                        {
                            seatId = 5,
                            busId = "bus1",
                            isReserved = true,
                            name = "A05",
                            tripId = 2
                        },
                        new
                        {
                            seatId = 6,
                            busId = "bus1",
                            isReserved = true,
                            name = "A06",
                            tripId = 2
                        },
                        new
                        {
                            seatId = 7,
                            busId = "bus1",
                            isReserved = true,
                            name = "A07",
                            tripId = 2
                        },
                        new
                        {
                            seatId = 8,
                            busId = "bus1",
                            isReserved = true,
                            name = "A08",
                            tripId = 2
                        },
                        new
                        {
                            seatId = 9,
                            busId = "bus1",
                            isReserved = true,
                            name = "A09",
                            tripId = 2
                        },
                        new
                        {
                            seatId = 10,
                            busId = "bus1",
                            isReserved = false,
                            name = "A10"
                        },
                        new
                        {
                            seatId = 11,
                            busId = "bus1",
                            isReserved = false,
                            name = "A11"
                        },
                        new
                        {
                            seatId = 12,
                            busId = "bus1",
                            isReserved = false,
                            name = "A12"
                        },
                        new
                        {
                            seatId = 13,
                            busId = "bus1",
                            isReserved = false,
                            name = "A13"
                        },
                        new
                        {
                            seatId = 14,
                            busId = "bus1",
                            isReserved = false,
                            name = "A14"
                        },
                        new
                        {
                            seatId = 15,
                            busId = "bus1",
                            isReserved = false,
                            name = "A15"
                        },
                        new
                        {
                            seatId = 16,
                            busId = "bus1",
                            isReserved = false,
                            name = "A16"
                        },
                        new
                        {
                            seatId = 17,
                            busId = "bus1",
                            isReserved = false,
                            name = "A17"
                        },
                        new
                        {
                            seatId = 18,
                            busId = "bus1",
                            isReserved = false,
                            name = "A18"
                        },
                        new
                        {
                            seatId = 19,
                            busId = "bus1",
                            isReserved = false,
                            name = "A19"
                        },
                        new
                        {
                            seatId = 20,
                            busId = "bus1",
                            isReserved = false,
                            name = "A20"
                        },
                        new
                        {
                            seatId = 21,
                            busId = "bus2",
                            isReserved = false,
                            name = "A00"
                        },
                        new
                        {
                            seatId = 22,
                            busId = "bus2",
                            isReserved = false,
                            name = "A01"
                        },
                        new
                        {
                            seatId = 23,
                            busId = "bus2",
                            isReserved = false,
                            name = "A02"
                        },
                        new
                        {
                            seatId = 24,
                            busId = "bus2",
                            isReserved = false,
                            name = "A03"
                        },
                        new
                        {
                            seatId = 25,
                            busId = "bus2",
                            isReserved = false,
                            name = "A04"
                        },
                        new
                        {
                            seatId = 26,
                            busId = "bus2",
                            isReserved = false,
                            name = "A05"
                        },
                        new
                        {
                            seatId = 27,
                            busId = "bus2",
                            isReserved = false,
                            name = "A06"
                        },
                        new
                        {
                            seatId = 28,
                            busId = "bus2",
                            isReserved = false,
                            name = "A07"
                        },
                        new
                        {
                            seatId = 29,
                            busId = "bus2",
                            isReserved = false,
                            name = "A08"
                        },
                        new
                        {
                            seatId = 30,
                            busId = "bus2",
                            isReserved = false,
                            name = "A09"
                        },
                        new
                        {
                            seatId = 31,
                            busId = "bus2",
                            isReserved = false,
                            name = "A10"
                        },
                        new
                        {
                            seatId = 32,
                            busId = "bus2",
                            isReserved = false,
                            name = "A11"
                        },
                        new
                        {
                            seatId = 33,
                            busId = "bus2",
                            isReserved = false,
                            name = "A12"
                        },
                        new
                        {
                            seatId = 34,
                            busId = "bus2",
                            isReserved = false,
                            name = "A13"
                        },
                        new
                        {
                            seatId = 35,
                            busId = "bus2",
                            isReserved = false,
                            name = "A14"
                        },
                        new
                        {
                            seatId = 36,
                            busId = "bus2",
                            isReserved = false,
                            name = "A15"
                        },
                        new
                        {
                            seatId = 37,
                            busId = "bus2",
                            isReserved = false,
                            name = "A16"
                        },
                        new
                        {
                            seatId = 38,
                            busId = "bus2",
                            isReserved = false,
                            name = "A17"
                        },
                        new
                        {
                            seatId = 39,
                            busId = "bus2",
                            isReserved = false,
                            name = "A18"
                        },
                        new
                        {
                            seatId = 40,
                            busId = "bus2",
                            isReserved = false,
                            name = "A19"
                        },
                        new
                        {
                            seatId = 41,
                            busId = "bus2",
                            isReserved = false,
                            name = "A20"
                        });
                });

            modelBuilder.Entity("Infrastructure.Models.Trip", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("busId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("price")
                        .HasColumnType("int");

                    b.Property<int>("tripType")
                        .HasColumnType("int");

                    b.Property<string>("userEmail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Trips");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            busId = "bus1",
                            price = 10,
                            tripType = 0,
                            userEmail = "mahmoud@gmail.com"
                        },
                        new
                        {
                            ID = 2,
                            busId = "bus1",
                            price = 10,
                            tripType = 0,
                            userEmail = "mahmoud@gmail.com"
                        },
                        new
                        {
                            ID = 3,
                            busId = "bus2",
                            price = 10,
                            tripType = 1,
                            userEmail = "mahmoud@gmail.com"
                        },
                        new
                        {
                            ID = 4,
                            busId = "bus2",
                            price = 10,
                            tripType = 1,
                            userEmail = "Yehia@gmail.com"
                        },
                        new
                        {
                            ID = 5,
                            busId = "bus2",
                            price = 10,
                            tripType = 1,
                            userEmail = "Yehia@gmail.com"
                        });
                });

            modelBuilder.Entity("Infrastructure.Models.Seat", b =>
                {
                    b.HasOne("Infrastructure.Models.Trip", null)
                        .WithMany("seats")
                        .HasForeignKey("tripId");
                });

            modelBuilder.Entity("Infrastructure.Models.Trip", b =>
                {
                    b.Navigation("seats");
                });
#pragma warning restore 612, 618
        }
    }
}
