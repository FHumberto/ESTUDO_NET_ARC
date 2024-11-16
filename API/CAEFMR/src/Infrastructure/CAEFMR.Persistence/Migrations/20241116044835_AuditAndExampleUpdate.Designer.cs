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
    [Migration("20241116044835_AuditAndExampleUpdate")]
    partial class AuditAndExampleUpdate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CAEFMR.Domain.Entities.Example", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<decimal>("Preco")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("Nome")
                        .IsUnique();

                    b.ToTable("Examples");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedDate = new DateTime(2024, 11, 16, 1, 48, 34, 833, DateTimeKind.Local).AddTicks(2083),
                            Nome = "Exemplo 1",
                            Preco = 10.99m,
                            UpdatedDate = new DateTime(2024, 11, 16, 1, 48, 34, 833, DateTimeKind.Local).AddTicks(2095)
                        },
                        new
                        {
                            Id = 2,
                            CreatedDate = new DateTime(2024, 11, 16, 1, 48, 34, 833, DateTimeKind.Local).AddTicks(2098),
                            Nome = "Exemplo 2",
                            Preco = 20.99m,
                            UpdatedDate = new DateTime(2024, 11, 16, 1, 48, 34, 833, DateTimeKind.Local).AddTicks(2098)
                        },
                        new
                        {
                            Id = 3,
                            CreatedDate = new DateTime(2024, 11, 16, 1, 48, 34, 833, DateTimeKind.Local).AddTicks(2100),
                            Nome = "Exemplo 3",
                            Preco = 15.99m,
                            UpdatedDate = new DateTime(2024, 11, 16, 1, 48, 34, 833, DateTimeKind.Local).AddTicks(2100)
                        },
                        new
                        {
                            Id = 4,
                            CreatedDate = new DateTime(2024, 11, 16, 1, 48, 34, 833, DateTimeKind.Local).AddTicks(2101),
                            Nome = "Exemplo 4",
                            Preco = 25.99m,
                            UpdatedDate = new DateTime(2024, 11, 16, 1, 48, 34, 833, DateTimeKind.Local).AddTicks(2102)
                        },
                        new
                        {
                            Id = 5,
                            CreatedDate = new DateTime(2024, 11, 16, 1, 48, 34, 833, DateTimeKind.Local).AddTicks(2103),
                            Nome = "Exemplo 5",
                            Preco = 30.99m,
                            UpdatedDate = new DateTime(2024, 11, 16, 1, 48, 34, 833, DateTimeKind.Local).AddTicks(2104)
                        },
                        new
                        {
                            Id = 6,
                            CreatedDate = new DateTime(2024, 11, 16, 1, 48, 34, 833, DateTimeKind.Local).AddTicks(2105),
                            Nome = "Exemplo 6",
                            Preco = 40.99m,
                            UpdatedDate = new DateTime(2024, 11, 16, 1, 48, 34, 833, DateTimeKind.Local).AddTicks(2105)
                        },
                        new
                        {
                            Id = 7,
                            CreatedDate = new DateTime(2024, 11, 16, 1, 48, 34, 833, DateTimeKind.Local).AddTicks(2107),
                            Nome = "Exemplo 7",
                            Preco = 50.99m,
                            UpdatedDate = new DateTime(2024, 11, 16, 1, 48, 34, 833, DateTimeKind.Local).AddTicks(2107)
                        },
                        new
                        {
                            Id = 8,
                            CreatedDate = new DateTime(2024, 11, 16, 1, 48, 34, 833, DateTimeKind.Local).AddTicks(2108),
                            Nome = "Exemplo 8",
                            Preco = 60.99m,
                            UpdatedDate = new DateTime(2024, 11, 16, 1, 48, 34, 833, DateTimeKind.Local).AddTicks(2109)
                        },
                        new
                        {
                            Id = 9,
                            CreatedDate = new DateTime(2024, 11, 16, 1, 48, 34, 833, DateTimeKind.Local).AddTicks(2110),
                            Nome = "Exemplo 9",
                            Preco = 70.99m,
                            UpdatedDate = new DateTime(2024, 11, 16, 1, 48, 34, 833, DateTimeKind.Local).AddTicks(2110)
                        },
                        new
                        {
                            Id = 10,
                            CreatedDate = new DateTime(2024, 11, 16, 1, 48, 34, 833, DateTimeKind.Local).AddTicks(2112),
                            Nome = "Exemplo 10",
                            Preco = 80.99m,
                            UpdatedDate = new DateTime(2024, 11, 16, 1, 48, 34, 833, DateTimeKind.Local).AddTicks(2112)
                        },
                        new
                        {
                            Id = 11,
                            CreatedDate = new DateTime(2024, 11, 16, 1, 48, 34, 833, DateTimeKind.Local).AddTicks(2113),
                            Nome = "Exemplo 11",
                            Preco = 90.99m,
                            UpdatedDate = new DateTime(2024, 11, 16, 1, 48, 34, 833, DateTimeKind.Local).AddTicks(2114)
                        },
                        new
                        {
                            Id = 12,
                            CreatedDate = new DateTime(2024, 11, 16, 1, 48, 34, 833, DateTimeKind.Local).AddTicks(2115),
                            Nome = "Exemplo 12",
                            Preco = 100.99m,
                            UpdatedDate = new DateTime(2024, 11, 16, 1, 48, 34, 833, DateTimeKind.Local).AddTicks(2115)
                        },
                        new
                        {
                            Id = 13,
                            CreatedDate = new DateTime(2024, 11, 16, 1, 48, 34, 833, DateTimeKind.Local).AddTicks(2116),
                            Nome = "Exemplo 13",
                            Preco = 110.99m,
                            UpdatedDate = new DateTime(2024, 11, 16, 1, 48, 34, 833, DateTimeKind.Local).AddTicks(2117)
                        },
                        new
                        {
                            Id = 14,
                            CreatedDate = new DateTime(2024, 11, 16, 1, 48, 34, 833, DateTimeKind.Local).AddTicks(2118),
                            Nome = "Exemplo 14",
                            Preco = 120.99m,
                            UpdatedDate = new DateTime(2024, 11, 16, 1, 48, 34, 833, DateTimeKind.Local).AddTicks(2119)
                        },
                        new
                        {
                            Id = 15,
                            CreatedDate = new DateTime(2024, 11, 16, 1, 48, 34, 833, DateTimeKind.Local).AddTicks(2120),
                            Nome = "Exemplo 15",
                            Preco = 130.99m,
                            UpdatedDate = new DateTime(2024, 11, 16, 1, 48, 34, 833, DateTimeKind.Local).AddTicks(2121)
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
