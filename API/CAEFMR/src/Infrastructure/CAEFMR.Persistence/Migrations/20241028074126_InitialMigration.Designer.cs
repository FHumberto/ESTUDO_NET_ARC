﻿// <auto-generated />
using System;
using CAEFMR.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CAEFMR.Persistence.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20241028074126_InitialMigration")]
    partial class InitialMigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CAEFMR.Domain.Entities.Example", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<decimal>("Preco")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Examples");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedDate = new DateTime(2024, 10, 28, 4, 41, 25, 921, DateTimeKind.Local).AddTicks(9898),
                            Nome = "Exemplo 1",
                            Preco = 10.99m,
                            UpdatedDate = new DateTime(2024, 10, 28, 4, 41, 25, 921, DateTimeKind.Local).AddTicks(9913)
                        },
                        new
                        {
                            Id = 2,
                            CreatedDate = new DateTime(2024, 10, 28, 4, 41, 25, 921, DateTimeKind.Local).AddTicks(9916),
                            Nome = "Exemplo 2",
                            Preco = 20.99m,
                            UpdatedDate = new DateTime(2024, 10, 28, 4, 41, 25, 921, DateTimeKind.Local).AddTicks(9916)
                        },
                        new
                        {
                            Id = 3,
                            CreatedDate = new DateTime(2024, 10, 28, 4, 41, 25, 921, DateTimeKind.Local).AddTicks(9918),
                            Nome = "Exemplo 3",
                            Preco = 15.99m,
                            UpdatedDate = new DateTime(2024, 10, 28, 4, 41, 25, 921, DateTimeKind.Local).AddTicks(9918)
                        },
                        new
                        {
                            Id = 4,
                            CreatedDate = new DateTime(2024, 10, 28, 4, 41, 25, 921, DateTimeKind.Local).AddTicks(9920),
                            Nome = "Exemplo 4",
                            Preco = 25.99m,
                            UpdatedDate = new DateTime(2024, 10, 28, 4, 41, 25, 921, DateTimeKind.Local).AddTicks(9920)
                        },
                        new
                        {
                            Id = 5,
                            CreatedDate = new DateTime(2024, 10, 28, 4, 41, 25, 921, DateTimeKind.Local).AddTicks(9921),
                            Nome = "Exemplo 5",
                            Preco = 30.99m,
                            UpdatedDate = new DateTime(2024, 10, 28, 4, 41, 25, 921, DateTimeKind.Local).AddTicks(9922)
                        },
                        new
                        {
                            Id = 6,
                            CreatedDate = new DateTime(2024, 10, 28, 4, 41, 25, 921, DateTimeKind.Local).AddTicks(9923),
                            Nome = "Exemplo 6",
                            Preco = 40.99m,
                            UpdatedDate = new DateTime(2024, 10, 28, 4, 41, 25, 921, DateTimeKind.Local).AddTicks(9923)
                        },
                        new
                        {
                            Id = 7,
                            CreatedDate = new DateTime(2024, 10, 28, 4, 41, 25, 921, DateTimeKind.Local).AddTicks(9925),
                            Nome = "Exemplo 7",
                            Preco = 50.99m,
                            UpdatedDate = new DateTime(2024, 10, 28, 4, 41, 25, 921, DateTimeKind.Local).AddTicks(9925)
                        },
                        new
                        {
                            Id = 8,
                            CreatedDate = new DateTime(2024, 10, 28, 4, 41, 25, 921, DateTimeKind.Local).AddTicks(9926),
                            Nome = "Exemplo 8",
                            Preco = 60.99m,
                            UpdatedDate = new DateTime(2024, 10, 28, 4, 41, 25, 921, DateTimeKind.Local).AddTicks(9927)
                        },
                        new
                        {
                            Id = 9,
                            CreatedDate = new DateTime(2024, 10, 28, 4, 41, 25, 921, DateTimeKind.Local).AddTicks(9928),
                            Nome = "Exemplo 9",
                            Preco = 70.99m,
                            UpdatedDate = new DateTime(2024, 10, 28, 4, 41, 25, 921, DateTimeKind.Local).AddTicks(9928)
                        },
                        new
                        {
                            Id = 10,
                            CreatedDate = new DateTime(2024, 10, 28, 4, 41, 25, 921, DateTimeKind.Local).AddTicks(9929),
                            Nome = "Exemplo 10",
                            Preco = 80.99m,
                            UpdatedDate = new DateTime(2024, 10, 28, 4, 41, 25, 921, DateTimeKind.Local).AddTicks(9930)
                        },
                        new
                        {
                            Id = 11,
                            CreatedDate = new DateTime(2024, 10, 28, 4, 41, 25, 921, DateTimeKind.Local).AddTicks(9931),
                            Nome = "Exemplo 11",
                            Preco = 90.99m,
                            UpdatedDate = new DateTime(2024, 10, 28, 4, 41, 25, 921, DateTimeKind.Local).AddTicks(9931)
                        },
                        new
                        {
                            Id = 12,
                            CreatedDate = new DateTime(2024, 10, 28, 4, 41, 25, 921, DateTimeKind.Local).AddTicks(9932),
                            Nome = "Exemplo 12",
                            Preco = 100.99m,
                            UpdatedDate = new DateTime(2024, 10, 28, 4, 41, 25, 921, DateTimeKind.Local).AddTicks(9933)
                        },
                        new
                        {
                            Id = 13,
                            CreatedDate = new DateTime(2024, 10, 28, 4, 41, 25, 921, DateTimeKind.Local).AddTicks(9934),
                            Nome = "Exemplo 13",
                            Preco = 110.99m,
                            UpdatedDate = new DateTime(2024, 10, 28, 4, 41, 25, 921, DateTimeKind.Local).AddTicks(9934)
                        },
                        new
                        {
                            Id = 14,
                            CreatedDate = new DateTime(2024, 10, 28, 4, 41, 25, 921, DateTimeKind.Local).AddTicks(9936),
                            Nome = "Exemplo 14",
                            Preco = 120.99m,
                            UpdatedDate = new DateTime(2024, 10, 28, 4, 41, 25, 921, DateTimeKind.Local).AddTicks(9936)
                        },
                        new
                        {
                            Id = 15,
                            CreatedDate = new DateTime(2024, 10, 28, 4, 41, 25, 921, DateTimeKind.Local).AddTicks(9937),
                            Nome = "Exemplo 15",
                            Preco = 130.99m,
                            UpdatedDate = new DateTime(2024, 10, 28, 4, 41, 25, 921, DateTimeKind.Local).AddTicks(9938)
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
