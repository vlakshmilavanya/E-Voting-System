using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BusinessDirectory.Data.Migrations
{
    public partial class AddC : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "numberOfVotes",
                table: "tblUsers",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "numberOfVotes",
                table: "tblUsers");
        }
    }
}
