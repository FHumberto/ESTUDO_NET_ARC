using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CAEFMR.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class AuditAndExampleUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "Examples",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ModifiedBy",
                table: "Examples",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Examples",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedBy", "CreatedDate", "ModifiedBy", "UpdatedDate" },
                values: new object[] { null, new DateTime(2024, 11, 16, 1, 48, 34, 833, DateTimeKind.Local).AddTicks(2083), null, new DateTime(2024, 11, 16, 1, 48, 34, 833, DateTimeKind.Local).AddTicks(2095) });

            migrationBuilder.UpdateData(
                table: "Examples",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedBy", "CreatedDate", "ModifiedBy", "UpdatedDate" },
                values: new object[] { null, new DateTime(2024, 11, 16, 1, 48, 34, 833, DateTimeKind.Local).AddTicks(2098), null, new DateTime(2024, 11, 16, 1, 48, 34, 833, DateTimeKind.Local).AddTicks(2098) });

            migrationBuilder.UpdateData(
                table: "Examples",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedBy", "CreatedDate", "ModifiedBy", "UpdatedDate" },
                values: new object[] { null, new DateTime(2024, 11, 16, 1, 48, 34, 833, DateTimeKind.Local).AddTicks(2100), null, new DateTime(2024, 11, 16, 1, 48, 34, 833, DateTimeKind.Local).AddTicks(2100) });

            migrationBuilder.UpdateData(
                table: "Examples",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedBy", "CreatedDate", "ModifiedBy", "UpdatedDate" },
                values: new object[] { null, new DateTime(2024, 11, 16, 1, 48, 34, 833, DateTimeKind.Local).AddTicks(2101), null, new DateTime(2024, 11, 16, 1, 48, 34, 833, DateTimeKind.Local).AddTicks(2102) });

            migrationBuilder.UpdateData(
                table: "Examples",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedBy", "CreatedDate", "ModifiedBy", "UpdatedDate" },
                values: new object[] { null, new DateTime(2024, 11, 16, 1, 48, 34, 833, DateTimeKind.Local).AddTicks(2103), null, new DateTime(2024, 11, 16, 1, 48, 34, 833, DateTimeKind.Local).AddTicks(2104) });

            migrationBuilder.UpdateData(
                table: "Examples",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedBy", "CreatedDate", "ModifiedBy", "UpdatedDate" },
                values: new object[] { null, new DateTime(2024, 11, 16, 1, 48, 34, 833, DateTimeKind.Local).AddTicks(2105), null, new DateTime(2024, 11, 16, 1, 48, 34, 833, DateTimeKind.Local).AddTicks(2105) });

            migrationBuilder.UpdateData(
                table: "Examples",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedBy", "CreatedDate", "ModifiedBy", "UpdatedDate" },
                values: new object[] { null, new DateTime(2024, 11, 16, 1, 48, 34, 833, DateTimeKind.Local).AddTicks(2107), null, new DateTime(2024, 11, 16, 1, 48, 34, 833, DateTimeKind.Local).AddTicks(2107) });

            migrationBuilder.UpdateData(
                table: "Examples",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedBy", "CreatedDate", "ModifiedBy", "UpdatedDate" },
                values: new object[] { null, new DateTime(2024, 11, 16, 1, 48, 34, 833, DateTimeKind.Local).AddTicks(2108), null, new DateTime(2024, 11, 16, 1, 48, 34, 833, DateTimeKind.Local).AddTicks(2109) });

            migrationBuilder.UpdateData(
                table: "Examples",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedBy", "CreatedDate", "ModifiedBy", "UpdatedDate" },
                values: new object[] { null, new DateTime(2024, 11, 16, 1, 48, 34, 833, DateTimeKind.Local).AddTicks(2110), null, new DateTime(2024, 11, 16, 1, 48, 34, 833, DateTimeKind.Local).AddTicks(2110) });

            migrationBuilder.UpdateData(
                table: "Examples",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedBy", "CreatedDate", "ModifiedBy", "UpdatedDate" },
                values: new object[] { null, new DateTime(2024, 11, 16, 1, 48, 34, 833, DateTimeKind.Local).AddTicks(2112), null, new DateTime(2024, 11, 16, 1, 48, 34, 833, DateTimeKind.Local).AddTicks(2112) });

            migrationBuilder.UpdateData(
                table: "Examples",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedBy", "CreatedDate", "ModifiedBy", "UpdatedDate" },
                values: new object[] { null, new DateTime(2024, 11, 16, 1, 48, 34, 833, DateTimeKind.Local).AddTicks(2113), null, new DateTime(2024, 11, 16, 1, 48, 34, 833, DateTimeKind.Local).AddTicks(2114) });

            migrationBuilder.UpdateData(
                table: "Examples",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedBy", "CreatedDate", "ModifiedBy", "UpdatedDate" },
                values: new object[] { null, new DateTime(2024, 11, 16, 1, 48, 34, 833, DateTimeKind.Local).AddTicks(2115), null, new DateTime(2024, 11, 16, 1, 48, 34, 833, DateTimeKind.Local).AddTicks(2115) });

            migrationBuilder.UpdateData(
                table: "Examples",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedBy", "CreatedDate", "ModifiedBy", "UpdatedDate" },
                values: new object[] { null, new DateTime(2024, 11, 16, 1, 48, 34, 833, DateTimeKind.Local).AddTicks(2116), null, new DateTime(2024, 11, 16, 1, 48, 34, 833, DateTimeKind.Local).AddTicks(2117) });

            migrationBuilder.UpdateData(
                table: "Examples",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedBy", "CreatedDate", "ModifiedBy", "UpdatedDate" },
                values: new object[] { null, new DateTime(2024, 11, 16, 1, 48, 34, 833, DateTimeKind.Local).AddTicks(2118), null, new DateTime(2024, 11, 16, 1, 48, 34, 833, DateTimeKind.Local).AddTicks(2119) });

            migrationBuilder.UpdateData(
                table: "Examples",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedBy", "CreatedDate", "ModifiedBy", "UpdatedDate" },
                values: new object[] { null, new DateTime(2024, 11, 16, 1, 48, 34, 833, DateTimeKind.Local).AddTicks(2120), null, new DateTime(2024, 11, 16, 1, 48, 34, 833, DateTimeKind.Local).AddTicks(2121) });

            migrationBuilder.CreateIndex(
                name: "IX_Examples_Nome",
                table: "Examples",
                column: "Nome",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Examples_Nome",
                table: "Examples");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Examples");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                table: "Examples");

            migrationBuilder.UpdateData(
                table: "Examples",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 10, 28, 4, 41, 25, 921, DateTimeKind.Local).AddTicks(9898), new DateTime(2024, 10, 28, 4, 41, 25, 921, DateTimeKind.Local).AddTicks(9913) });

            migrationBuilder.UpdateData(
                table: "Examples",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 10, 28, 4, 41, 25, 921, DateTimeKind.Local).AddTicks(9916), new DateTime(2024, 10, 28, 4, 41, 25, 921, DateTimeKind.Local).AddTicks(9916) });

            migrationBuilder.UpdateData(
                table: "Examples",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 10, 28, 4, 41, 25, 921, DateTimeKind.Local).AddTicks(9918), new DateTime(2024, 10, 28, 4, 41, 25, 921, DateTimeKind.Local).AddTicks(9918) });

            migrationBuilder.UpdateData(
                table: "Examples",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 10, 28, 4, 41, 25, 921, DateTimeKind.Local).AddTicks(9920), new DateTime(2024, 10, 28, 4, 41, 25, 921, DateTimeKind.Local).AddTicks(9920) });

            migrationBuilder.UpdateData(
                table: "Examples",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 10, 28, 4, 41, 25, 921, DateTimeKind.Local).AddTicks(9921), new DateTime(2024, 10, 28, 4, 41, 25, 921, DateTimeKind.Local).AddTicks(9922) });

            migrationBuilder.UpdateData(
                table: "Examples",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 10, 28, 4, 41, 25, 921, DateTimeKind.Local).AddTicks(9923), new DateTime(2024, 10, 28, 4, 41, 25, 921, DateTimeKind.Local).AddTicks(9923) });

            migrationBuilder.UpdateData(
                table: "Examples",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 10, 28, 4, 41, 25, 921, DateTimeKind.Local).AddTicks(9925), new DateTime(2024, 10, 28, 4, 41, 25, 921, DateTimeKind.Local).AddTicks(9925) });

            migrationBuilder.UpdateData(
                table: "Examples",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 10, 28, 4, 41, 25, 921, DateTimeKind.Local).AddTicks(9926), new DateTime(2024, 10, 28, 4, 41, 25, 921, DateTimeKind.Local).AddTicks(9927) });

            migrationBuilder.UpdateData(
                table: "Examples",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 10, 28, 4, 41, 25, 921, DateTimeKind.Local).AddTicks(9928), new DateTime(2024, 10, 28, 4, 41, 25, 921, DateTimeKind.Local).AddTicks(9928) });

            migrationBuilder.UpdateData(
                table: "Examples",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 10, 28, 4, 41, 25, 921, DateTimeKind.Local).AddTicks(9929), new DateTime(2024, 10, 28, 4, 41, 25, 921, DateTimeKind.Local).AddTicks(9930) });

            migrationBuilder.UpdateData(
                table: "Examples",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 10, 28, 4, 41, 25, 921, DateTimeKind.Local).AddTicks(9931), new DateTime(2024, 10, 28, 4, 41, 25, 921, DateTimeKind.Local).AddTicks(9931) });

            migrationBuilder.UpdateData(
                table: "Examples",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 10, 28, 4, 41, 25, 921, DateTimeKind.Local).AddTicks(9932), new DateTime(2024, 10, 28, 4, 41, 25, 921, DateTimeKind.Local).AddTicks(9933) });

            migrationBuilder.UpdateData(
                table: "Examples",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 10, 28, 4, 41, 25, 921, DateTimeKind.Local).AddTicks(9934), new DateTime(2024, 10, 28, 4, 41, 25, 921, DateTimeKind.Local).AddTicks(9934) });

            migrationBuilder.UpdateData(
                table: "Examples",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 10, 28, 4, 41, 25, 921, DateTimeKind.Local).AddTicks(9936), new DateTime(2024, 10, 28, 4, 41, 25, 921, DateTimeKind.Local).AddTicks(9936) });

            migrationBuilder.UpdateData(
                table: "Examples",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 10, 28, 4, 41, 25, 921, DateTimeKind.Local).AddTicks(9937), new DateTime(2024, 10, 28, 4, 41, 25, 921, DateTimeKind.Local).AddTicks(9938) });
        }
    }
}
