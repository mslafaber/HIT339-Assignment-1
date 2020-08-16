using Microsoft.EntityFrameworkCore.Migrations;

namespace Assignment_1_Web_Application_MVC.Migrations
{
    public partial class Changedfieldnameandtype : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Salesname",
                table: "Sales");

            migrationBuilder.AddColumn<int>(
                name: "Item",
                table: "Sales",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Item",
                table: "Sales");

            migrationBuilder.AddColumn<string>(
                name: "Salesname",
                table: "Sales",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
