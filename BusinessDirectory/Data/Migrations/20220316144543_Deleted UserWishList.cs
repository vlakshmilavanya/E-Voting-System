using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BusinessDirectory.Data.Migrations
{
    public partial class DeletedUserWishList : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tblAppconfig_tblUsers_UserId",
                table: "tblAppconfig");

            migrationBuilder.DropForeignKey(
                name: "FK_tblReviews_tblServices_ServiceID1",
                table: "tblReviews");

            migrationBuilder.DropForeignKey(
                name: "FK_tblUsers_tblUserWishLists_UserWishListId",
                table: "tblUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_tblWishLists_tblServices_ServiceId",
                table: "tblWishLists");

            migrationBuilder.DropForeignKey(
                name: "FK_tblWishLists_tblUserWishLists_UserWishListId",
                table: "tblWishLists");

            migrationBuilder.DropTable(
                name: "tblUserWishLists");

            migrationBuilder.DropIndex(
                name: "IX_tblUsers_UserWishListId",
                table: "tblUsers");

            migrationBuilder.DropIndex(
                name: "IX_tblReviews_ServiceID1",
                table: "tblReviews");

            migrationBuilder.DropColumn(
                name: "ServicesServiceID",
                table: "tblWishLists");

            migrationBuilder.DropColumn(
                name: "UserWishListId",
                table: "tblUsers");

            migrationBuilder.DropColumn(
                name: "BsnServiceDetailsID",
                table: "tblServices");

            migrationBuilder.DropColumn(
                name: "CategoryID",
                table: "tblServices");

            migrationBuilder.DropColumn(
                name: "SubCategoryId",
                table: "tblServices");

            migrationBuilder.DropColumn(
                name: "ServiceID",
                table: "tblReviews");

            migrationBuilder.RenameColumn(
                name: "ServiceId",
                table: "tblWishLists",
                newName: "ServiceID");

            migrationBuilder.RenameColumn(
                name: "UserWishListId",
                table: "tblWishLists",
                newName: "UserId");

            migrationBuilder.RenameIndex(
                name: "IX_tblWishLists_ServiceId",
                table: "tblWishLists",
                newName: "IX_tblWishLists_ServiceID");

            migrationBuilder.RenameIndex(
                name: "IX_tblWishLists_UserWishListId",
                table: "tblWishLists",
                newName: "IX_tblWishLists_UserId");

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "tblAppconfig",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.CreateIndex(
                name: "IX_tblServices_ReviewID",
                table: "tblServices",
                column: "ReviewID",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_tblAppconfig_tblUsers_UserId",
                table: "tblAppconfig",
                column: "UserId",
                principalTable: "tblUsers",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_tblServices_tblReviews_ReviewID",
                table: "tblServices",
                column: "ReviewID",
                principalTable: "tblReviews",
                principalColumn: "ReviewId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tblWishLists_tblServices_ServiceID",
                table: "tblWishLists",
                column: "ServiceID",
                principalTable: "tblServices",
                principalColumn: "ServiceID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tblWishLists_tblUsers_UserId",
                table: "tblWishLists",
                column: "UserId",
                principalTable: "tblUsers",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tblAppconfig_tblUsers_UserId",
                table: "tblAppconfig");

            migrationBuilder.DropForeignKey(
                name: "FK_tblServices_tblReviews_ReviewID",
                table: "tblServices");

            migrationBuilder.DropForeignKey(
                name: "FK_tblWishLists_tblServices_ServiceID",
                table: "tblWishLists");

            migrationBuilder.DropForeignKey(
                name: "FK_tblWishLists_tblUsers_UserId",
                table: "tblWishLists");

            migrationBuilder.DropIndex(
                name: "IX_tblServices_ReviewID",
                table: "tblServices");

            migrationBuilder.RenameColumn(
                name: "ServiceID",
                table: "tblWishLists",
                newName: "ServiceId");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "tblWishLists",
                newName: "UserWishListId");

            migrationBuilder.RenameIndex(
                name: "IX_tblWishLists_ServiceID",
                table: "tblWishLists",
                newName: "IX_tblWishLists_ServiceId");

            migrationBuilder.RenameIndex(
                name: "IX_tblWishLists_UserId",
                table: "tblWishLists",
                newName: "IX_tblWishLists_UserWishListId");

            migrationBuilder.AddColumn<int>(
                name: "ServicesServiceID",
                table: "tblWishLists",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UserWishListId",
                table: "tblUsers",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "BsnServiceDetailsID",
                table: "tblServices",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CategoryID",
                table: "tblServices",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SubCategoryId",
                table: "tblServices",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ServiceID",
                table: "tblReviews",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "tblAppconfig",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "tblUserWishLists",
                columns: table => new
                {
                    UserWishListId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UpdatedTimeStamp = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UserWishListTimeStamp = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblUserWishLists", x => x.UserWishListId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_tblUsers_UserWishListId",
                table: "tblUsers",
                column: "UserWishListId");

            migrationBuilder.CreateIndex(
                name: "IX_tblReviews_ServiceID1",
                table: "tblReviews",
                column: "ServiceID1");

            migrationBuilder.AddForeignKey(
                name: "FK_tblAppconfig_tblUsers_UserId",
                table: "tblAppconfig",
                column: "UserId",
                principalTable: "tblUsers",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tblReviews_tblServices_ServiceID1",
                table: "tblReviews",
                column: "ServiceID1",
                principalTable: "tblServices",
                principalColumn: "ServiceID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tblUsers_tblUserWishLists_UserWishListId",
                table: "tblUsers",
                column: "UserWishListId",
                principalTable: "tblUserWishLists",
                principalColumn: "UserWishListId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tblWishLists_tblServices_ServiceId",
                table: "tblWishLists",
                column: "ServiceId",
                principalTable: "tblServices",
                principalColumn: "ServiceID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tblWishLists_tblUserWishLists_UserWishListId",
                table: "tblWishLists",
                column: "UserWishListId",
                principalTable: "tblUserWishLists",
                principalColumn: "UserWishListId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
