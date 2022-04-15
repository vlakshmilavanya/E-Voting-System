using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BusinessDirectory.Data.Migrations
{
    public partial class aadhar : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AadharAuthAadharId",
                table: "tblUsers",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AadharId",
                table: "tblUsers",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "tblAadhar",
                columns: table => new
                {
                    AadharId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    AadharNumber = table.Column<string>(type: "TEXT", nullable: false),
                    VoterId = table.Column<string>(type: "TEXT", nullable: false),
                    Age = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblAadhar", x => x.AadharId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_tblUsers_AadharAuthAadharId",
                table: "tblUsers",
                column: "AadharAuthAadharId");

            migrationBuilder.AddForeignKey(
                name: "FK_tblUsers_tblAadhar_AadharAuthAadharId",
                table: "tblUsers",
                column: "AadharAuthAadharId",
                principalTable: "tblAadhar",
                principalColumn: "AadharId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tblUsers_tblAadhar_AadharAuthAadharId",
                table: "tblUsers");

            migrationBuilder.DropTable(
                name: "tblAadhar");

            migrationBuilder.DropIndex(
                name: "IX_tblUsers_AadharAuthAadharId",
                table: "tblUsers");

            migrationBuilder.DropColumn(
                name: "AadharAuthAadharId",
                table: "tblUsers");

            migrationBuilder.DropColumn(
                name: "AadharId",
                table: "tblUsers");
        }
    }
}
