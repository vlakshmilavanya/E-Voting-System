using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BusinessDirectory.Data.Migrations
{
    public partial class addedaadharemail : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "tblAadhar",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Email",
                table: "tblAadhar");
        }
    }
}
