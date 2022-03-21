using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BusinessDirectory.Data.Migrations
{
    public partial class removedreviewIdinservice : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tblServices_tblReviews_ReviewID",
                table: "tblServices");

            migrationBuilder.DropIndex(
                name: "IX_tblServices_ReviewID",
                table: "tblServices");

            migrationBuilder.DropColumn(
                name: "ReviewID",
                table: "tblServices");

            migrationBuilder.AddColumn<int>(
                name: "ServiceID",
                table: "tblReviews",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_tblReviews_ServiceID",
                table: "tblReviews",
                column: "ServiceID");

            migrationBuilder.AddForeignKey(
                name: "FK_tblReviews_tblServices_ServiceID",
                table: "tblReviews",
                column: "ServiceID",
                principalTable: "tblServices",
                principalColumn: "ServiceID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tblReviews_tblServices_ServiceID",
                table: "tblReviews");

            migrationBuilder.DropIndex(
                name: "IX_tblReviews_ServiceID",
                table: "tblReviews");

            migrationBuilder.DropColumn(
                name: "ServiceID",
                table: "tblReviews");

            migrationBuilder.AddColumn<int>(
                name: "ReviewID",
                table: "tblServices",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_tblServices_ReviewID",
                table: "tblServices",
                column: "ReviewID",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_tblServices_tblReviews_ReviewID",
                table: "tblServices",
                column: "ReviewID",
                principalTable: "tblReviews",
                principalColumn: "ReviewId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
