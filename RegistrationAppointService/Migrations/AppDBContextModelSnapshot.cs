﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RegistrationAppointService.Models;

namespace RegistrationAppointService.Migrations
{
    [DbContext(typeof(AppDBContext))]
    partial class AppDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("DocumentService", b =>
                {
                    b.Property<int>("DocumentsId")
                        .HasColumnType("int");

                    b.Property<int>("ServicesId")
                        .HasColumnType("int");

                    b.HasKey("DocumentsId", "ServicesId");

                    b.HasIndex("ServicesId");

                    b.ToTable("DocumentService");
                });

            modelBuilder.Entity("RegistrationAppointService.Models.Document", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Documents");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Test"
                        });
                });

            modelBuilder.Entity("RegistrationAppointService.Models.GibddOffice", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<double>("Lat")
                        .HasColumnType("float");

                    b.Property<double>("Lon")
                        .HasColumnType("float");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RegionId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RegionId");

                    b.ToTable("GibddOffices");
                });

            modelBuilder.Entity("RegistrationAppointService.Models.Region", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Regions");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Владимирская область"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Московская область"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Ивановская область"
                        });
                });

            modelBuilder.Entity("RegistrationAppointService.Models.RegistrationService", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("CarOwnerId")
                        .HasColumnType("int");

                    b.Property<int>("GibddOfficeId")
                        .HasColumnType("int");

                    b.Property<int>("ServiceDateTimeId")
                        .HasColumnType("int");

                    b.Property<int>("ServiceId")
                        .HasColumnType("int");

                    b.Property<string>("Status")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("GibddOfficeId");

                    b.HasIndex("ServiceDateTimeId")
                        .IsUnique();

                    b.HasIndex("ServiceId");

                    b.ToTable("RegistrationServices");
                });

            modelBuilder.Entity("RegistrationAppointService.Models.Service", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TypeOfService")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Services");
                });

            modelBuilder.Entity("RegistrationAppointService.Models.ServiceDateTime", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsFree")
                        .HasColumnType("bit");

                    b.Property<DateTime>("Time")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("ServiceDateTimes");
                });

            modelBuilder.Entity("DocumentService", b =>
                {
                    b.HasOne("RegistrationAppointService.Models.Document", null)
                        .WithMany()
                        .HasForeignKey("DocumentsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RegistrationAppointService.Models.Service", null)
                        .WithMany()
                        .HasForeignKey("ServicesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("RegistrationAppointService.Models.GibddOffice", b =>
                {
                    b.HasOne("RegistrationAppointService.Models.Region", "Region")
                        .WithMany("GibddOffices")
                        .HasForeignKey("RegionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Region");
                });

            modelBuilder.Entity("RegistrationAppointService.Models.RegistrationService", b =>
                {
                    b.HasOne("RegistrationAppointService.Models.GibddOffice", "GibddOffice")
                        .WithMany("RegistrationServices")
                        .HasForeignKey("GibddOfficeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RegistrationAppointService.Models.ServiceDateTime", "ServiceDateTime")
                        .WithOne("RegistrationService")
                        .HasForeignKey("RegistrationAppointService.Models.RegistrationService", "ServiceDateTimeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RegistrationAppointService.Models.Service", "Service")
                        .WithMany()
                        .HasForeignKey("ServiceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("GibddOffice");

                    b.Navigation("Service");

                    b.Navigation("ServiceDateTime");
                });

            modelBuilder.Entity("RegistrationAppointService.Models.GibddOffice", b =>
                {
                    b.Navigation("RegistrationServices");
                });

            modelBuilder.Entity("RegistrationAppointService.Models.Region", b =>
                {
                    b.Navigation("GibddOffices");
                });

            modelBuilder.Entity("RegistrationAppointService.Models.ServiceDateTime", b =>
                {
                    b.Navigation("RegistrationService");
                });
#pragma warning restore 612, 618
        }
    }
}
