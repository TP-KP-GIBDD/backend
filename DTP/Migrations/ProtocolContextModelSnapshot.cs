﻿// <auto-generated />
using System;
using DTP.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DTP.Migrations
{
    [DbContext(typeof(ProtocolContext))]
    partial class ProtocolContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.13")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AvtoAPI.Entities.Avto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BodyTypeId")
                        .HasColumnType("int")
                        .HasColumnName("body_type_id");

                    b.Property<int>("BrandModelId")
                        .HasColumnType("int")
                        .HasColumnName("brand_model_id");

                    b.Property<int>("ColorId")
                        .HasColumnType("int")
                        .HasColumnName("color_id");

                    b.Property<int>("NumberAvto")
                        .HasColumnType("int")
                        .HasColumnName("number_avto");

                    b.Property<int>("Power")
                        .HasColumnType("int")
                        .HasColumnName("power");

                    b.Property<int>("RudderId")
                        .HasColumnType("int")
                        .HasColumnName("rudder_id");

                    b.Property<string>("Vin")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("vin");

                    b.Property<int>("Year")
                        .HasColumnType("int")
                        .HasColumnName("year");

                    b.HasKey("Id");

                    b.HasIndex("BodyTypeId");

                    b.HasIndex("BrandModelId");

                    b.HasIndex("ColorId");

                    b.HasIndex("RudderId");

                    b.ToTable("avto");
                });

            modelBuilder.Entity("AvtoAPI.Entities.BodyType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("name");

                    b.HasKey("Id");

                    b.ToTable("body_type");
                });

            modelBuilder.Entity("AvtoAPI.Entities.Brand", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("name");

                    b.HasKey("Id");

                    b.ToTable("brand");
                });

            modelBuilder.Entity("AvtoAPI.Entities.BrandModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BrandId")
                        .HasColumnType("int")
                        .HasColumnName("BrandId");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Name");

                    b.HasKey("Id");

                    b.HasIndex("BrandId");

                    b.ToTable("brand_model");
                });

            modelBuilder.Entity("AvtoAPI.Entities.ColorAvto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("name");

                    b.HasKey("Id");

                    b.ToTable("color");
                });

            modelBuilder.Entity("AvtoAPI.Entities.Rudder", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("name");

                    b.HasKey("Id");

                    b.ToTable("rudder");
                });

            modelBuilder.Entity("DTP.Entities.Coordinates", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Latitube")
                        .HasColumnType("int")
                        .HasColumnName("Latitude");

                    b.Property<int>("Longitube")
                        .HasColumnType("int")
                        .HasColumnName("Longitube");

                    b.HasKey("Id");

                    b.ToTable("Coordinates");
                });

            modelBuilder.Entity("DTP.Entities.Participants", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AvtoId")
                        .HasColumnType("int")
                        .HasColumnName("avtoId");

                    b.Property<string>("Damage")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("damage");

                    b.Property<string>("FullName")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("fullname");

                    b.Property<string>("Login")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("login");

                    b.Property<string>("Status")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("status");

                    b.HasKey("Id");

                    b.HasIndex("AvtoId");

                    b.ToTable("Participants");
                });

            modelBuilder.Entity("DTP.Entities.PlaceViolation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CoordinatesId")
                        .HasColumnType("int")
                        .HasColumnName("CoordinatesId");

                    b.Property<string>("MethodTrafficRegulation")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("MethodTrafficRegulation");

                    b.Property<string>("RoadMarkup")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("RoadMarkup");

                    b.Property<string>("RoadSigns")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("RoadSigns");

                    b.Property<string>("TypeLighting")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("TypeLighting");

                    b.HasKey("Id");

                    b.HasIndex("CoordinatesId");

                    b.ToTable("PlaceViolation");
                });

            modelBuilder.Entity("DTP.Entities.Protocol", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("address");

                    b.Property<string>("Inspector")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("inspector");

                    b.Property<string>("LoginInspector")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("loginInspector");

                    b.Property<int>("ParticipantsId")
                        .HasColumnType("int")
                        .HasColumnName("participantsId");

                    b.Property<int>("PlaceViolationId")
                        .HasColumnType("int")
                        .HasColumnName("placeViolationId");

                    b.Property<int>("TypeViolationId")
                        .HasColumnType("int")
                        .HasColumnName("typeViolationId");

                    b.Property<string>("Violation")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("violation");

                    b.Property<DateTime>("dateTime")
                        .HasColumnType("datetime2")
                        .HasColumnName("dateTime");

                    b.Property<int>("identifier")
                        .HasColumnType("int")
                        .HasColumnName("identifier");

                    b.HasKey("Id");

                    b.HasIndex("ParticipantsId");

                    b.HasIndex("PlaceViolationId");

                    b.HasIndex("TypeViolationId");

                    b.ToTable("Protocols");
                });

            modelBuilder.Entity("DTP.Entities.TypeViolation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("name");

                    b.HasKey("Id");

                    b.ToTable("TypeViolations");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "столкновение транспортных средств"
                        },
                        new
                        {
                            Id = 2,
                            Name = "наезд на припятствие"
                        },
                        new
                        {
                            Id = 3,
                            Name = "опрокидывание/съезд в кювет"
                        },
                        new
                        {
                            Id = 4,
                            Name = "наезд на пешехода"
                        },
                        new
                        {
                            Id = 5,
                            Name = "наезд на животное"
                        },
                        new
                        {
                            Id = 6,
                            Name = "другое"
                        });
                });

            modelBuilder.Entity("AvtoAPI.Entities.Avto", b =>
                {
                    b.HasOne("AvtoAPI.Entities.BodyType", "BodyType")
                        .WithMany()
                        .HasForeignKey("BodyTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AvtoAPI.Entities.BrandModel", "BrandModel")
                        .WithMany()
                        .HasForeignKey("BrandModelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AvtoAPI.Entities.ColorAvto", "Color")
                        .WithMany()
                        .HasForeignKey("ColorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AvtoAPI.Entities.Rudder", "Rudder")
                        .WithMany()
                        .HasForeignKey("RudderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("BodyType");

                    b.Navigation("BrandModel");

                    b.Navigation("Color");

                    b.Navigation("Rudder");
                });

            modelBuilder.Entity("AvtoAPI.Entities.BrandModel", b =>
                {
                    b.HasOne("AvtoAPI.Entities.Brand", "Brand")
                        .WithMany()
                        .HasForeignKey("BrandId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Brand");
                });

            modelBuilder.Entity("DTP.Entities.Participants", b =>
                {
                    b.HasOne("AvtoAPI.Entities.Avto", "Avto")
                        .WithMany()
                        .HasForeignKey("AvtoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Avto");
                });

            modelBuilder.Entity("DTP.Entities.PlaceViolation", b =>
                {
                    b.HasOne("DTP.Entities.Coordinates", "Coordinates")
                        .WithMany()
                        .HasForeignKey("CoordinatesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Coordinates");
                });

            modelBuilder.Entity("DTP.Entities.Protocol", b =>
                {
                    b.HasOne("DTP.Entities.Participants", "Participants")
                        .WithMany()
                        .HasForeignKey("ParticipantsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DTP.Entities.PlaceViolation", "Place")
                        .WithMany()
                        .HasForeignKey("PlaceViolationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DTP.Entities.TypeViolation", "TypeViolation")
                        .WithMany()
                        .HasForeignKey("TypeViolationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Participants");

                    b.Navigation("Place");

                    b.Navigation("TypeViolation");
                });
#pragma warning restore 612, 618
        }
    }
}
