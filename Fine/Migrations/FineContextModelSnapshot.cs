﻿// <auto-generated />
using FineAPI.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FineAPI.Migrations
{
    [DbContext(typeof(FineContext))]
    partial class FineContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.12")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("FineAPI.Entities.Fine", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AvtoId")
                        .HasColumnType("int")
                        .HasColumnName("avto_id");

                    b.Property<int>("PersonId")
                        .HasColumnType("int")
                        .HasColumnName("person_id");

                    b.Property<string>("StatusFine")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("status_fine");

                    b.Property<int>("SumaryFine")
                        .HasColumnType("int")
                        .HasColumnName("sumary_fine");

                    b.Property<int>("TypeFineId")
                        .HasColumnType("int")
                        .HasColumnName("type_id");

                    b.HasKey("Id");

                    b.HasIndex("TypeFineId");

                    b.ToTable("fine");
                });

            modelBuilder.Entity("FineAPI.Entities.TypeFine", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("name");

                    b.HasKey("id");

                    b.ToTable("type_fine");
                });

            modelBuilder.Entity("FineAPI.Entities.Fine", b =>
                {
                    b.HasOne("FineAPI.Entities.TypeFine", "TypeFine")
                        .WithMany()
                        .HasForeignKey("TypeFineId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TypeFine");
                });
#pragma warning restore 612, 618
        }
    }
}
