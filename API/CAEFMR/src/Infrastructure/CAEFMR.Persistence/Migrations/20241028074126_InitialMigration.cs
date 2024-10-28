using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CAEFMR.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Examples",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Preco = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Examples", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Examples",
                columns: new[] { "Id", "CreatedDate", "Nome", "Preco", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 10, 28, 4, 41, 25, 921, DateTimeKind.Local).AddTicks(9898), "Exemplo 1", 10.99m, new DateTime(2024, 10, 28, 4, 41, 25, 921, DateTimeKind.Local).AddTicks(9913) },
                    { 2, new DateTime(2024, 10, 28, 4, 41, 25, 921, DateTimeKind.Local).AddTicks(9916), "Exemplo 2", 20.99m, new DateTime(2024, 10, 28, 4, 41, 25, 921, DateTimeKind.Local).AddTicks(9916) },
                    { 3, new DateTime(2024, 10, 28, 4, 41, 25, 921, DateTimeKind.Local).AddTicks(9918), "Exemplo 3", 15.99m, new DateTime(2024, 10, 28, 4, 41, 25, 921, DateTimeKind.Local).AddTicks(9918) },
                    { 4, new DateTime(2024, 10, 28, 4, 41, 25, 921, DateTimeKind.Local).AddTicks(9920), "Exemplo 4", 25.99m, new DateTime(2024, 10, 28, 4, 41, 25, 921, DateTimeKind.Local).AddTicks(9920) },
                    { 5, new DateTime(2024, 10, 28, 4, 41, 25, 921, DateTimeKind.Local).AddTicks(9921), "Exemplo 5", 30.99m, new DateTime(2024, 10, 28, 4, 41, 25, 921, DateTimeKind.Local).AddTicks(9922) },
                    { 6, new DateTime(2024, 10, 28, 4, 41, 25, 921, DateTimeKind.Local).AddTicks(9923), "Exemplo 6", 40.99m, new DateTime(2024, 10, 28, 4, 41, 25, 921, DateTimeKind.Local).AddTicks(9923) },
                    { 7, new DateTime(2024, 10, 28, 4, 41, 25, 921, DateTimeKind.Local).AddTicks(9925), "Exemplo 7", 50.99m, new DateTime(2024, 10, 28, 4, 41, 25, 921, DateTimeKind.Local).AddTicks(9925) },
                    { 8, new DateTime(2024, 10, 28, 4, 41, 25, 921, DateTimeKind.Local).AddTicks(9926), "Exemplo 8", 60.99m, new DateTime(2024, 10, 28, 4, 41, 25, 921, DateTimeKind.Local).AddTicks(9927) },
                    { 9, new DateTime(2024, 10, 28, 4, 41, 25, 921, DateTimeKind.Local).AddTicks(9928), "Exemplo 9", 70.99m, new DateTime(2024, 10, 28, 4, 41, 25, 921, DateTimeKind.Local).AddTicks(9928) },
                    { 10, new DateTime(2024, 10, 28, 4, 41, 25, 921, DateTimeKind.Local).AddTicks(9929), "Exemplo 10", 80.99m, new DateTime(2024, 10, 28, 4, 41, 25, 921, DateTimeKind.Local).AddTicks(9930) },
                    { 11, new DateTime(2024, 10, 28, 4, 41, 25, 921, DateTimeKind.Local).AddTicks(9931), "Exemplo 11", 90.99m, new DateTime(2024, 10, 28, 4, 41, 25, 921, DateTimeKind.Local).AddTicks(9931) },
                    { 12, new DateTime(2024, 10, 28, 4, 41, 25, 921, DateTimeKind.Local).AddTicks(9932), "Exemplo 12", 100.99m, new DateTime(2024, 10, 28, 4, 41, 25, 921, DateTimeKind.Local).AddTicks(9933) },
                    { 13, new DateTime(2024, 10, 28, 4, 41, 25, 921, DateTimeKind.Local).AddTicks(9934), "Exemplo 13", 110.99m, new DateTime(2024, 10, 28, 4, 41, 25, 921, DateTimeKind.Local).AddTicks(9934) },
                    { 14, new DateTime(2024, 10, 28, 4, 41, 25, 921, DateTimeKind.Local).AddTicks(9936), "Exemplo 14", 120.99m, new DateTime(2024, 10, 28, 4, 41, 25, 921, DateTimeKind.Local).AddTicks(9936) },
                    { 15, new DateTime(2024, 10, 28, 4, 41, 25, 921, DateTimeKind.Local).AddTicks(9937), "Exemplo 15", 130.99m, new DateTime(2024, 10, 28, 4, 41, 25, 921, DateTimeKind.Local).AddTicks(9938) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Examples");
        }
    }
}
