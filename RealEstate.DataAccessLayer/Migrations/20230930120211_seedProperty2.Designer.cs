﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RealEstate.DataAccessLayer.DbContexts;

#nullable disable

namespace RealEstate.DataAccessLayer.Migrations
{
    [DbContext(typeof(RealEstateContext))]
    [Migration("20230930120211_seedProperty2")]
    partial class seedProperty2
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("PropertyPropertyFeature", b =>
                {
                    b.Property<int>("PropertiesId")
                        .HasColumnType("int");

                    b.Property<int>("ProperyFeaturesId")
                        .HasColumnType("int");

                    b.HasKey("PropertiesId", "ProperyFeaturesId");

                    b.HasIndex("ProperyFeaturesId");

                    b.ToTable("PropertyPropertyFeature");

                    b.HasData(
                        new
                        {
                            PropertiesId = 1,
                            ProperyFeaturesId = 1
                        });
                });

            modelBuilder.Entity("RealEstate.DataAccessLayer.Entities.City", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CountryId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeleteTime")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Value")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("CountryId");

                    b.ToTable("Cities");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CountryId = 1,
                            CreateTime = new DateTime(2023, 9, 30, 15, 2, 11, 98, DateTimeKind.Local).AddTicks(5111),
                            IsDeleted = false,
                            Value = "İstanbul"
                        },
                        new
                        {
                            Id = 2,
                            CountryId = 1,
                            CreateTime = new DateTime(2023, 9, 30, 15, 2, 11, 98, DateTimeKind.Local).AddTicks(5112),
                            IsDeleted = false,
                            Value = "İzmir"
                        },
                        new
                        {
                            Id = 3,
                            CountryId = 1,
                            CreateTime = new DateTime(2023, 9, 30, 15, 2, 11, 98, DateTimeKind.Local).AddTicks(5112),
                            IsDeleted = false,
                            Value = "Antalya"
                        },
                        new
                        {
                            Id = 4,
                            CountryId = 2,
                            CreateTime = new DateTime(2023, 9, 30, 15, 2, 11, 98, DateTimeKind.Local).AddTicks(5113),
                            IsDeleted = false,
                            Value = "Utrecht"
                        },
                        new
                        {
                            Id = 5,
                            CountryId = 3,
                            CreateTime = new DateTime(2023, 9, 30, 15, 2, 11, 98, DateTimeKind.Local).AddTicks(5114),
                            IsDeleted = false,
                            Value = "Lyon"
                        });
                });

            modelBuilder.Entity("RealEstate.DataAccessLayer.Entities.Country", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeleteTime")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Value")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Countries");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreateTime = new DateTime(2023, 9, 30, 15, 2, 11, 98, DateTimeKind.Local).AddTicks(5028),
                            IsDeleted = false,
                            Value = "Türkiye"
                        },
                        new
                        {
                            Id = 2,
                            CreateTime = new DateTime(2023, 9, 30, 15, 2, 11, 98, DateTimeKind.Local).AddTicks(5037),
                            IsDeleted = false,
                            Value = "Holland"
                        },
                        new
                        {
                            Id = 3,
                            CreateTime = new DateTime(2023, 9, 30, 15, 2, 11, 98, DateTimeKind.Local).AddTicks(5038),
                            IsDeleted = false,
                            Value = "France"
                        });
                });

            modelBuilder.Entity("RealEstate.DataAccessLayer.Entities.District", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CityId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeleteTime")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Value")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("CityId");

                    b.ToTable("Districts");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CityId = 1,
                            CreateTime = new DateTime(2023, 9, 30, 15, 2, 11, 98, DateTimeKind.Local).AddTicks(5126),
                            IsDeleted = false,
                            Value = "Sarıyer"
                        },
                        new
                        {
                            Id = 2,
                            CityId = 1,
                            CreateTime = new DateTime(2023, 9, 30, 15, 2, 11, 98, DateTimeKind.Local).AddTicks(5127),
                            IsDeleted = false,
                            Value = "Beşiktaş"
                        },
                        new
                        {
                            Id = 3,
                            CityId = 1,
                            CreateTime = new DateTime(2023, 9, 30, 15, 2, 11, 98, DateTimeKind.Local).AddTicks(5128),
                            IsDeleted = false,
                            Value = "Levent"
                        },
                        new
                        {
                            Id = 4,
                            CityId = 2,
                            CreateTime = new DateTime(2023, 9, 30, 15, 2, 11, 98, DateTimeKind.Local).AddTicks(5128),
                            IsDeleted = false,
                            Value = "Aliağa"
                        },
                        new
                        {
                            Id = 5,
                            CityId = 2,
                            CreateTime = new DateTime(2023, 9, 30, 15, 2, 11, 98, DateTimeKind.Local).AddTicks(5129),
                            IsDeleted = false,
                            Value = "Balçova"
                        },
                        new
                        {
                            Id = 6,
                            CityId = 2,
                            CreateTime = new DateTime(2023, 9, 30, 15, 2, 11, 98, DateTimeKind.Local).AddTicks(5130),
                            IsDeleted = false,
                            Value = "Bayındır"
                        },
                        new
                        {
                            Id = 7,
                            CityId = 3,
                            CreateTime = new DateTime(2023, 9, 30, 15, 2, 11, 98, DateTimeKind.Local).AddTicks(5130),
                            IsDeleted = false,
                            Value = "Alanya"
                        },
                        new
                        {
                            Id = 8,
                            CityId = 3,
                            CreateTime = new DateTime(2023, 9, 30, 15, 2, 11, 98, DateTimeKind.Local).AddTicks(5131),
                            IsDeleted = false,
                            Value = "Korkuteli"
                        },
                        new
                        {
                            Id = 9,
                            CityId = 3,
                            CreateTime = new DateTime(2023, 9, 30, 15, 2, 11, 98, DateTimeKind.Local).AddTicks(5131),
                            IsDeleted = false,
                            Value = "Muratpaşa"
                        },
                        new
                        {
                            Id = 10,
                            CityId = 4,
                            CreateTime = new DateTime(2023, 9, 30, 15, 2, 11, 98, DateTimeKind.Local).AddTicks(5132),
                            IsDeleted = false,
                            Value = "Amersfoort"
                        },
                        new
                        {
                            Id = 11,
                            CityId = 5,
                            CreateTime = new DateTime(2023, 9, 30, 15, 2, 11, 98, DateTimeKind.Local).AddTicks(5133),
                            IsDeleted = false,
                            Value = "Corse"
                        });
                });

            modelBuilder.Entity("RealEstate.DataAccessLayer.Entities.Property", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeleteTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("DistrictId")
                        .HasColumnType("int");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<decimal>("Price")
                        .HasPrecision(18, 2)
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("PropertyType")
                        .HasColumnType("int");

                    b.Property<int>("RoomId")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("DistrictId");

                    b.HasIndex("RoomId");

                    b.ToTable("Properties");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreateTime = new DateTime(2023, 9, 30, 15, 2, 11, 98, DateTimeKind.Local).AddTicks(5171),
                            DistrictId = 1,
                            IsDeleted = false,
                            Price = 12000m,
                            PropertyType = 1,
                            RoomId = 3,
                            Title = "Test 1"
                        },
                        new
                        {
                            Id = 2,
                            CreateTime = new DateTime(2023, 9, 30, 15, 2, 11, 98, DateTimeKind.Local).AddTicks(5173),
                            DistrictId = 8,
                            IsDeleted = false,
                            Price = 5000m,
                            PropertyType = 1,
                            RoomId = 1,
                            Title = "Test 2"
                        },
                        new
                        {
                            Id = 3,
                            CreateTime = new DateTime(2023, 9, 30, 15, 2, 11, 98, DateTimeKind.Local).AddTicks(5174),
                            DistrictId = 10,
                            IsDeleted = false,
                            Price = 3000000m,
                            PropertyType = 0,
                            RoomId = 1,
                            Title = "Test 3"
                        },
                        new
                        {
                            Id = 4,
                            CreateTime = new DateTime(2023, 9, 30, 15, 2, 11, 98, DateTimeKind.Local).AddTicks(5175),
                            DistrictId = 1,
                            IsDeleted = false,
                            Price = 1000000m,
                            PropertyType = 0,
                            RoomId = 2,
                            Title = "Test 4"
                        });
                });

            modelBuilder.Entity("RealEstate.DataAccessLayer.Entities.PropertyFeature", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeleteTime")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Value")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("PropertyFeatures");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreateTime = new DateTime(2023, 9, 30, 15, 2, 11, 98, DateTimeKind.Local).AddTicks(5153),
                            IsDeleted = false,
                            Value = "Kombi"
                        },
                        new
                        {
                            Id = 2,
                            CreateTime = new DateTime(2023, 9, 30, 15, 2, 11, 98, DateTimeKind.Local).AddTicks(5156),
                            IsDeleted = false,
                            Value = "Parke"
                        },
                        new
                        {
                            Id = 3,
                            CreateTime = new DateTime(2023, 9, 30, 15, 2, 11, 98, DateTimeKind.Local).AddTicks(5156),
                            IsDeleted = false,
                            Value = "Eşyalı"
                        });
                });

            modelBuilder.Entity("RealEstate.DataAccessLayer.Entities.Room", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeleteTime")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Value")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("RoomTypes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreateTime = new DateTime(2023, 9, 30, 15, 2, 11, 98, DateTimeKind.Local).AddTicks(5146),
                            IsDeleted = false,
                            Value = "1+0"
                        },
                        new
                        {
                            Id = 2,
                            CreateTime = new DateTime(2023, 9, 30, 15, 2, 11, 98, DateTimeKind.Local).AddTicks(5147),
                            IsDeleted = false,
                            Value = "1+1"
                        },
                        new
                        {
                            Id = 3,
                            CreateTime = new DateTime(2023, 9, 30, 15, 2, 11, 98, DateTimeKind.Local).AddTicks(5147),
                            IsDeleted = false,
                            Value = "2+1"
                        },
                        new
                        {
                            Id = 4,
                            CreateTime = new DateTime(2023, 9, 30, 15, 2, 11, 98, DateTimeKind.Local).AddTicks(5148),
                            IsDeleted = false,
                            Value = "3+1"
                        });
                });

            modelBuilder.Entity("PropertyPropertyFeature", b =>
                {
                    b.HasOne("RealEstate.DataAccessLayer.Entities.Property", null)
                        .WithMany()
                        .HasForeignKey("PropertiesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RealEstate.DataAccessLayer.Entities.PropertyFeature", null)
                        .WithMany()
                        .HasForeignKey("ProperyFeaturesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("RealEstate.DataAccessLayer.Entities.City", b =>
                {
                    b.HasOne("RealEstate.DataAccessLayer.Entities.Country", "Country")
                        .WithMany("Cities")
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Country");
                });

            modelBuilder.Entity("RealEstate.DataAccessLayer.Entities.District", b =>
                {
                    b.HasOne("RealEstate.DataAccessLayer.Entities.City", "City")
                        .WithMany("Districts")
                        .HasForeignKey("CityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("City");
                });

            modelBuilder.Entity("RealEstate.DataAccessLayer.Entities.Property", b =>
                {
                    b.HasOne("RealEstate.DataAccessLayer.Entities.District", "District")
                        .WithMany("Properties")
                        .HasForeignKey("DistrictId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RealEstate.DataAccessLayer.Entities.Room", "Room")
                        .WithMany("Properties")
                        .HasForeignKey("RoomId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("District");

                    b.Navigation("Room");
                });

            modelBuilder.Entity("RealEstate.DataAccessLayer.Entities.City", b =>
                {
                    b.Navigation("Districts");
                });

            modelBuilder.Entity("RealEstate.DataAccessLayer.Entities.Country", b =>
                {
                    b.Navigation("Cities");
                });

            modelBuilder.Entity("RealEstate.DataAccessLayer.Entities.District", b =>
                {
                    b.Navigation("Properties");
                });

            modelBuilder.Entity("RealEstate.DataAccessLayer.Entities.Room", b =>
                {
                    b.Navigation("Properties");
                });
#pragma warning restore 612, 618
        }
    }
}
