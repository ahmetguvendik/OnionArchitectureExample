using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ETicaret.Persistance.Migrations
{
    public partial class mig_3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CreatedTime", "Name", "Price", "Stock" },
                values: new object[] { 1, new DateTime(2022, 4, 29, 13, 0, 4, 743, DateTimeKind.Local).AddTicks(8167), "Bilgisayar", 10000L, 200 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CreatedTime", "Name", "Price", "Stock" },
                values: new object[] { 2, new DateTime(2022, 4, 29, 13, 0, 4, 743, DateTimeKind.Local).AddTicks(8180), "Telefon", 5000L, 500 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CreatedTime", "Name", "Price", "Stock" },
                values: new object[] { 3, new DateTime(2022, 4, 29, 13, 0, 4, 743, DateTimeKind.Local).AddTicks(8183), "Saat", 200L, 1000 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
