using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ETicaret.Persistance.Migrations
{
    public partial class mig_2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CreatedTime00",
                table: "Products",
                newName: "CreatedTime");

            migrationBuilder.RenameColumn(
                name: "CreatedTime00",
                table: "Orders",
                newName: "CreatedTime");

            migrationBuilder.RenameColumn(
                name: "CreatedTime00",
                table: "Customers",
                newName: "CreatedTime");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CreatedTime",
                table: "Products",
                newName: "CreatedTime00");

            migrationBuilder.RenameColumn(
                name: "CreatedTime",
                table: "Orders",
                newName: "CreatedTime00");

            migrationBuilder.RenameColumn(
                name: "CreatedTime",
                table: "Customers",
                newName: "CreatedTime00");
        }
    }
}
