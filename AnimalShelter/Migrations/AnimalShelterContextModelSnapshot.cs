﻿// <auto-generated />
using AnimalShelter.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AnimalShelter.Migrations
{
    [DbContext(typeof(AnimalShelterContext))]
    partial class AnimalShelterContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("AnimalShelter.Models.Animal", b =>
                {
                    b.Property<int>("AnimalId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20) CHARACTER SET utf8mb4");

                    b.Property<string>("Species")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("AnimalId");

                    b.ToTable("Animals");

                    b.HasData(
                        new
                        {
                            AnimalId = 1,
                            Age = 1,
                            Gender = "Test Gender",
                            Name = "Test Name",
                            Species = "Test Species"
                        },
                        new
                        {
                            AnimalId = 2,
                            Age = 12,
                            Gender = "Female",
                            Name = "Vivian",
                            Species = "Cat"
                        },
                        new
                        {
                            AnimalId = 3,
                            Age = 4,
                            Gender = "Female",
                            Name = "Claire",
                            Species = "Dog"
                        },
                        new
                        {
                            AnimalId = 4,
                            Age = 1,
                            Gender = "Male",
                            Name = "Marshal",
                            Species = "Cat"
                        },
                        new
                        {
                            AnimalId = 5,
                            Age = 1,
                            Gender = "Female",
                            Name = "Bob",
                            Species = "Chicken"
                        },
                        new
                        {
                            AnimalId = 6,
                            Age = 1,
                            Gender = "Female",
                            Name = "Not Bob",
                            Species = "Chicken"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
