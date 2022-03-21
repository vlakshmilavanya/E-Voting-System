using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BusinessDirectory.Data.Migrations
{
    public partial class Modelscreated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tblAcitvityTypes",
                columns: table => new
                {
                    ActivityTypeId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ActivityTypeName = table.Column<string>(type: "TEXT", nullable: false),
                    ActivityTypeTimestamp = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblAcitvityTypes", x => x.ActivityTypeId);
                });

            migrationBuilder.CreateTable(
                name: "tblCategories",
                columns: table => new
                {
                    CategoryId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CategoryName = table.Column<string>(type: "TEXT", nullable: false),
                    CategoryTimestamp = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblCategories", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "tblCountries",
                columns: table => new
                {
                    CountryId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CountryName = table.Column<string>(type: "TEXT", nullable: false),
                    COuntryTimeStamp = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblCountries", x => x.CountryId);
                });

            migrationBuilder.CreateTable(
                name: "tblErrorTypes",
                columns: table => new
                {
                    ErrorTypeId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ErrorTypeTitle = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false),
                    ErrorTypeTimestamp = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblErrorTypes", x => x.ErrorTypeId);
                });

            migrationBuilder.CreateTable(
                name: "tblMembershipTypes",
                columns: table => new
                {
                    MemberShipId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    MembershipName = table.Column<string>(type: "TEXT", nullable: false),
                    MembershipCost = table.Column<double>(type: "REAL", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblMembershipTypes", x => x.MemberShipId);
                });

            migrationBuilder.CreateTable(
                name: "tblRoleTypes",
                columns: table => new
                {
                    RoleTypeId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    RoleTitle = table.Column<string>(type: "TEXT", nullable: false),
                    IsActive = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblRoleTypes", x => x.RoleTypeId);
                });

            migrationBuilder.CreateTable(
                name: "tblStates",
                columns: table => new
                {
                    StateId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    StateName = table.Column<string>(type: "TEXT", nullable: false),
                    StateTimestamp = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblStates", x => x.StateId);
                });

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

            migrationBuilder.CreateTable(
                name: "tblSubCategories",
                columns: table => new
                {
                    SubCategoryId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CategoryId = table.Column<int>(type: "INTEGER", nullable: false),
                    SubCategoryName = table.Column<string>(type: "TEXT", nullable: false),
                    SubCategoryTimestamp = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblSubCategories", x => x.SubCategoryId);
                    table.ForeignKey(
                        name: "FK_tblSubCategories_tblCategories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "tblCategories",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tblAddress",
                columns: table => new
                {
                    AddressID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Building = table.Column<string>(type: "TEXT", nullable: false),
                    Street = table.Column<string>(type: "TEXT", nullable: false),
                    Landmark = table.Column<string>(type: "TEXT", nullable: false),
                    Area = table.Column<string>(type: "TEXT", nullable: false),
                    City = table.Column<string>(type: "TEXT", nullable: false),
                    Pincode = table.Column<long>(type: "INTEGER", nullable: false),
                    StateId = table.Column<int>(type: "INTEGER", nullable: false),
                    CountryId = table.Column<int>(type: "INTEGER", nullable: false),
                    AddressTimestamp = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblAddress", x => x.AddressID);
                    table.ForeignKey(
                        name: "FK_tblAddress_tblCountries_CountryId",
                        column: x => x.CountryId,
                        principalTable: "tblCountries",
                        principalColumn: "CountryId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tblAddress_tblStates_StateId",
                        column: x => x.StateId,
                        principalTable: "tblStates",
                        principalColumn: "StateId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tblUsers",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FirstName = table.Column<string>(type: "TEXT", nullable: false),
                    LastName = table.Column<string>(type: "TEXT", nullable: false),
                    EmailAddress = table.Column<string>(type: "TEXT", nullable: false),
                    MobileNumber = table.Column<long>(type: "INTEGER", nullable: false),
                    AddressID = table.Column<int>(type: "INTEGER", nullable: false),
                    IsActive = table.Column<bool>(type: "INTEGER", nullable: false),
                    UserTimestamp = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UpdateTimestamp = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UpdatedBy = table.Column<int>(type: "INTEGER", nullable: false),
                    UserWishListId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblUsers", x => x.UserId);
                    table.ForeignKey(
                        name: "FK_tblUsers_tblAddress_AddressID",
                        column: x => x.AddressID,
                        principalTable: "tblAddress",
                        principalColumn: "AddressID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tblUsers_tblUserWishLists_UserWishListId",
                        column: x => x.UserWishListId,
                        principalTable: "tblUserWishLists",
                        principalColumn: "UserWishListId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tblActivityLogs",
                columns: table => new
                {
                    ActivityId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Description = table.Column<string>(type: "TEXT", nullable: false),
                    UrlOrModule = table.Column<string>(type: "TEXT", nullable: false),
                    ActivityTypeId = table.Column<int>(type: "INTEGER", nullable: false),
                    ActivityTimeStamp = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UserId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblActivityLogs", x => x.ActivityId);
                    table.ForeignKey(
                        name: "FK_tblActivityLogs_tblAcitvityTypes_ActivityTypeId",
                        column: x => x.ActivityTypeId,
                        principalTable: "tblAcitvityTypes",
                        principalColumn: "ActivityTypeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tblActivityLogs_tblUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "tblUsers",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tblAppconfig",
                columns: table => new
                {
                    configId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    configName = table.Column<string>(type: "TEXT", nullable: false),
                    description = table.Column<string>(type: "TEXT", nullable: false),
                    configValue = table.Column<string>(type: "TEXT", nullable: false),
                    createdDateTime = table.Column<DateTime>(type: "TEXT", nullable: false),
                    updatedDateTime = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UserId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblAppconfig", x => x.configId);
                    table.ForeignKey(
                        name: "FK_tblAppconfig_tblUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "tblUsers",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tblErrorLogs",
                columns: table => new
                {
                    ErrorId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Description = table.Column<string>(type: "TEXT", nullable: false),
                    UrlOrModule = table.Column<string>(type: "TEXT", nullable: false),
                    ErrorTypeId = table.Column<int>(type: "INTEGER", nullable: false),
                    ErrorTimeStamp = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UserId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblErrorLogs", x => x.ErrorId);
                    table.ForeignKey(
                        name: "FK_tblErrorLogs_tblErrorTypes_ErrorTypeId",
                        column: x => x.ErrorTypeId,
                        principalTable: "tblErrorTypes",
                        principalColumn: "ErrorTypeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tblErrorLogs_tblUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "tblUsers",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tblPreListingDetails",
                columns: table => new
                {
                    PreListingDetailID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UserId = table.Column<int>(type: "INTEGER", nullable: false),
                    CompanyName = table.Column<string>(type: "TEXT", nullable: false),
                    Place = table.Column<string>(type: "TEXT", nullable: false),
                    Email = table.Column<string>(type: "TEXT", nullable: false),
                    PreListTimestamp = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblPreListingDetails", x => x.PreListingDetailID);
                    table.ForeignKey(
                        name: "FK_tblPreListingDetails_tblUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "tblUsers",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tblQueries",
                columns: table => new
                {
                    QueryId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UserId = table.Column<int>(type: "INTEGER", nullable: false),
                    QueryDescription = table.Column<string>(type: "TEXT", nullable: false),
                    QueryTimestamp = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblQueries", x => x.QueryId);
                    table.ForeignKey(
                        name: "FK_tblQueries_tblUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "tblUsers",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tblRoles",
                columns: table => new
                {
                    RoleID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UserID = table.Column<int>(type: "INTEGER", nullable: false),
                    RoleTypeID = table.Column<int>(type: "INTEGER", nullable: false),
                    IsActive = table.Column<bool>(type: "INTEGER", nullable: false),
                    CreatedBy = table.Column<int>(type: "INTEGER", nullable: false),
                    RolesTimestamp = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblRoles", x => x.RoleID);
                    table.ForeignKey(
                        name: "FK_tblRoles_tblRoleTypes_RoleTypeID",
                        column: x => x.RoleTypeID,
                        principalTable: "tblRoleTypes",
                        principalColumn: "RoleTypeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tblRoles_tblUsers_UserID",
                        column: x => x.UserID,
                        principalTable: "tblUsers",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tblShareYourViews",
                columns: table => new
                {
                    ShareYourViewsId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UserId = table.Column<int>(type: "INTEGER", nullable: false),
                    View = table.Column<string>(type: "TEXT", nullable: false),
                    ViewsTimestamp = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblShareYourViews", x => x.ShareYourViewsId);
                    table.ForeignKey(
                        name: "FK_tblShareYourViews_tblUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "tblUsers",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tblBusinessDetailsForm",
                columns: table => new
                {
                    BsnServiceDetailsID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    LegalBusinessName = table.Column<string>(type: "TEXT", nullable: false),
                    AddressId = table.Column<int>(type: "INTEGER", nullable: false),
                    TollFreeNo = table.Column<int>(type: "INTEGER", nullable: false),
                    FaxNo = table.Column<int>(type: "INTEGER", nullable: false),
                    Website = table.Column<string>(type: "TEXT", nullable: false),
                    CoverImage = table.Column<string>(type: "TEXT", nullable: false),
                    Twitter = table.Column<string>(type: "TEXT", nullable: false),
                    Instagram = table.Column<string>(type: "TEXT", nullable: false),
                    UserId = table.Column<int>(type: "INTEGER", nullable: false),
                    BsnDetailTimestamp = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    PreListingDetailsID = table.Column<int>(type: "INTEGER", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblBusinessDetailsForm", x => x.BsnServiceDetailsID);
                    table.ForeignKey(
                        name: "FK_tblBusinessDetailsForm_tblAddress_AddressId",
                        column: x => x.AddressId,
                        principalTable: "tblAddress",
                        principalColumn: "AddressID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tblBusinessDetailsForm_tblPreListingDetails_PreListingDetailsID",
                        column: x => x.PreListingDetailsID,
                        principalTable: "tblPreListingDetails",
                        principalColumn: "PreListingDetailID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tblBusinessDetailsForm_tblUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "tblUsers",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tblFAQs",
                columns: table => new
                {
                    FaqID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Question = table.Column<string>(type: "TEXT", nullable: false),
                    Answer = table.Column<string>(type: "TEXT", nullable: false),
                    BsnServiceDetailsID = table.Column<int>(type: "INTEGER", nullable: false),
                    FaqTimestamp = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblFAQs", x => x.FaqID);
                    table.ForeignKey(
                        name: "FK_tblFAQs_tblBusinessDetailsForm_BsnServiceDetailsID",
                        column: x => x.BsnServiceDetailsID,
                        principalTable: "tblBusinessDetailsForm",
                        principalColumn: "BsnServiceDetailsID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tblImages",
                columns: table => new
                {
                    ImageId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ImageUrl = table.Column<string>(type: "TEXT", nullable: false),
                    BusinessDetailsFormBsnServiceDetailsID = table.Column<int>(type: "INTEGER", nullable: false),
                    ImageTimeStamp = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblImages", x => x.ImageId);
                    table.ForeignKey(
                        name: "FK_tblImages_tblBusinessDetailsForm_BusinessDetailsFormBsnServiceDetailsID",
                        column: x => x.BusinessDetailsFormBsnServiceDetailsID,
                        principalTable: "tblBusinessDetailsForm",
                        principalColumn: "BsnServiceDetailsID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tblServices",
                columns: table => new
                {
                    ServiceID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ServicesType = table.Column<string>(type: "TEXT", nullable: false),
                    ServiceName = table.Column<string>(type: "TEXT", nullable: false),
                    AddressID = table.Column<int>(type: "INTEGER", nullable: false),
                    ServiceTimestamp = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    CategoryID = table.Column<int>(type: "INTEGER", nullable: false),
                    CategorgoiesCategoryId = table.Column<int>(type: "INTEGER", nullable: false),
                    SubCategoryId = table.Column<int>(type: "INTEGER", nullable: false),
                    SubCategoriesSubCategoryId = table.Column<int>(type: "INTEGER", nullable: false),
                    UserID = table.Column<int>(type: "INTEGER", nullable: false),
                    ReviewID = table.Column<int>(type: "INTEGER", nullable: false),
                    BsnServiceDetailsID = table.Column<int>(type: "INTEGER", nullable: false),
                    BusinessDetailsFormBsnServiceDetailsID = table.Column<int>(type: "INTEGER", nullable: false),
                    Verified = table.Column<bool>(type: "INTEGER", nullable: false),
                    VerifiedById = table.Column<int>(type: "INTEGER", nullable: false),
                    TimesofAvail = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblServices", x => x.ServiceID);
                    table.ForeignKey(
                        name: "FK_tblServices_tblAddress_AddressID",
                        column: x => x.AddressID,
                        principalTable: "tblAddress",
                        principalColumn: "AddressID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tblServices_tblBusinessDetailsForm_BusinessDetailsFormBsnServiceDetailsID",
                        column: x => x.BusinessDetailsFormBsnServiceDetailsID,
                        principalTable: "tblBusinessDetailsForm",
                        principalColumn: "BsnServiceDetailsID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tblServices_tblCategories_CategorgoiesCategoryId",
                        column: x => x.CategorgoiesCategoryId,
                        principalTable: "tblCategories",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tblServices_tblSubCategories_SubCategoriesSubCategoryId",
                        column: x => x.SubCategoriesSubCategoryId,
                        principalTable: "tblSubCategories",
                        principalColumn: "SubCategoryId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tblServices_tblUsers_UserID",
                        column: x => x.UserID,
                        principalTable: "tblUsers",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tblMemberships",
                columns: table => new
                {
                    MembershipId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    MembershipTypeID = table.Column<int>(type: "INTEGER", nullable: false),
                    ServiceID = table.Column<int>(type: "INTEGER", nullable: false),
                    MerbershipTimestamp = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    IsActive = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblMemberships", x => x.MembershipId);
                    table.ForeignKey(
                        name: "FK_tblMemberships_tblMembershipTypes_MembershipTypeID",
                        column: x => x.MembershipTypeID,
                        principalTable: "tblMembershipTypes",
                        principalColumn: "MemberShipId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tblMemberships_tblServices_ServiceID",
                        column: x => x.ServiceID,
                        principalTable: "tblServices",
                        principalColumn: "ServiceID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tblOrders",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ServiceID = table.Column<int>(type: "INTEGER", nullable: false),
                    UserID = table.Column<int>(type: "INTEGER", nullable: false),
                    OrderTimestamp = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblOrders", x => x.ID);
                    table.ForeignKey(
                        name: "FK_tblOrders_tblServices_ServiceID",
                        column: x => x.ServiceID,
                        principalTable: "tblServices",
                        principalColumn: "ServiceID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tblOrders_tblUsers_UserID",
                        column: x => x.UserID,
                        principalTable: "tblUsers",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tblReviews",
                columns: table => new
                {
                    ReviewId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ReviewText = table.Column<string>(type: "TEXT", nullable: false),
                    UserId = table.Column<int>(type: "INTEGER", nullable: false),
                    Rating = table.Column<int>(type: "INTEGER", nullable: false),
                    ReviewTimestamp = table.Column<DateTime>(type: "TEXT", nullable: false),
                    CreatedBy = table.Column<int>(type: "INTEGER", nullable: false),
                    ServiceID = table.Column<int>(type: "INTEGER", nullable: false),
                    ServiceID1 = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblReviews", x => x.ReviewId);
                    table.ForeignKey(
                        name: "FK_tblReviews_tblServices_ServiceID1",
                        column: x => x.ServiceID1,
                        principalTable: "tblServices",
                        principalColumn: "ServiceID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tblReviews_tblUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "tblUsers",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tblWishLists",
                columns: table => new
                {
                    WishListId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UserWishListId = table.Column<int>(type: "INTEGER", nullable: false),
                    ServicesServiceID = table.Column<int>(type: "INTEGER", nullable: false),
                    ServiceId = table.Column<int>(type: "INTEGER", nullable: false),
                    UserWishListTimeStamp = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblWishLists", x => x.WishListId);
                    table.ForeignKey(
                        name: "FK_tblWishLists_tblServices_ServiceId",
                        column: x => x.ServiceId,
                        principalTable: "tblServices",
                        principalColumn: "ServiceID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tblWishLists_tblUserWishLists_UserWishListId",
                        column: x => x.UserWishListId,
                        principalTable: "tblUserWishLists",
                        principalColumn: "UserWishListId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_tblActivityLogs_ActivityTypeId",
                table: "tblActivityLogs",
                column: "ActivityTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_tblActivityLogs_UserId",
                table: "tblActivityLogs",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_tblAddress_CountryId",
                table: "tblAddress",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_tblAddress_StateId",
                table: "tblAddress",
                column: "StateId");

            migrationBuilder.CreateIndex(
                name: "IX_tblAppconfig_UserId",
                table: "tblAppconfig",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_tblBusinessDetailsForm_AddressId",
                table: "tblBusinessDetailsForm",
                column: "AddressId");

            migrationBuilder.CreateIndex(
                name: "IX_tblBusinessDetailsForm_PreListingDetailsID",
                table: "tblBusinessDetailsForm",
                column: "PreListingDetailsID");

            migrationBuilder.CreateIndex(
                name: "IX_tblBusinessDetailsForm_UserId",
                table: "tblBusinessDetailsForm",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_tblErrorLogs_ErrorTypeId",
                table: "tblErrorLogs",
                column: "ErrorTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_tblErrorLogs_UserId",
                table: "tblErrorLogs",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_tblFAQs_BsnServiceDetailsID",
                table: "tblFAQs",
                column: "BsnServiceDetailsID");

            migrationBuilder.CreateIndex(
                name: "IX_tblImages_BusinessDetailsFormBsnServiceDetailsID",
                table: "tblImages",
                column: "BusinessDetailsFormBsnServiceDetailsID");

            migrationBuilder.CreateIndex(
                name: "IX_tblMemberships_MembershipTypeID",
                table: "tblMemberships",
                column: "MembershipTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_tblMemberships_ServiceID",
                table: "tblMemberships",
                column: "ServiceID");

            migrationBuilder.CreateIndex(
                name: "IX_tblOrders_ServiceID",
                table: "tblOrders",
                column: "ServiceID");

            migrationBuilder.CreateIndex(
                name: "IX_tblOrders_UserID",
                table: "tblOrders",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_tblPreListingDetails_UserId",
                table: "tblPreListingDetails",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_tblQueries_UserId",
                table: "tblQueries",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_tblReviews_ServiceID1",
                table: "tblReviews",
                column: "ServiceID1");

            migrationBuilder.CreateIndex(
                name: "IX_tblReviews_UserId",
                table: "tblReviews",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_tblRoles_RoleTypeID",
                table: "tblRoles",
                column: "RoleTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_tblRoles_UserID",
                table: "tblRoles",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_tblServices_AddressID",
                table: "tblServices",
                column: "AddressID");

            migrationBuilder.CreateIndex(
                name: "IX_tblServices_BusinessDetailsFormBsnServiceDetailsID",
                table: "tblServices",
                column: "BusinessDetailsFormBsnServiceDetailsID");

            migrationBuilder.CreateIndex(
                name: "IX_tblServices_CategorgoiesCategoryId",
                table: "tblServices",
                column: "CategorgoiesCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_tblServices_SubCategoriesSubCategoryId",
                table: "tblServices",
                column: "SubCategoriesSubCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_tblServices_UserID",
                table: "tblServices",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_tblShareYourViews_UserId",
                table: "tblShareYourViews",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_tblSubCategories_CategoryId",
                table: "tblSubCategories",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_tblUsers_AddressID",
                table: "tblUsers",
                column: "AddressID");

            migrationBuilder.CreateIndex(
                name: "IX_tblUsers_UserWishListId",
                table: "tblUsers",
                column: "UserWishListId");

            migrationBuilder.CreateIndex(
                name: "IX_tblWishLists_ServiceId",
                table: "tblWishLists",
                column: "ServiceId");

            migrationBuilder.CreateIndex(
                name: "IX_tblWishLists_UserWishListId",
                table: "tblWishLists",
                column: "UserWishListId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tblActivityLogs");

            migrationBuilder.DropTable(
                name: "tblAppconfig");

            migrationBuilder.DropTable(
                name: "tblErrorLogs");

            migrationBuilder.DropTable(
                name: "tblFAQs");

            migrationBuilder.DropTable(
                name: "tblImages");

            migrationBuilder.DropTable(
                name: "tblMemberships");

            migrationBuilder.DropTable(
                name: "tblOrders");

            migrationBuilder.DropTable(
                name: "tblQueries");

            migrationBuilder.DropTable(
                name: "tblReviews");

            migrationBuilder.DropTable(
                name: "tblRoles");

            migrationBuilder.DropTable(
                name: "tblShareYourViews");

            migrationBuilder.DropTable(
                name: "tblWishLists");

            migrationBuilder.DropTable(
                name: "tblAcitvityTypes");

            migrationBuilder.DropTable(
                name: "tblErrorTypes");

            migrationBuilder.DropTable(
                name: "tblMembershipTypes");

            migrationBuilder.DropTable(
                name: "tblRoleTypes");

            migrationBuilder.DropTable(
                name: "tblServices");

            migrationBuilder.DropTable(
                name: "tblBusinessDetailsForm");

            migrationBuilder.DropTable(
                name: "tblSubCategories");

            migrationBuilder.DropTable(
                name: "tblPreListingDetails");

            migrationBuilder.DropTable(
                name: "tblCategories");

            migrationBuilder.DropTable(
                name: "tblUsers");

            migrationBuilder.DropTable(
                name: "tblAddress");

            migrationBuilder.DropTable(
                name: "tblUserWishLists");

            migrationBuilder.DropTable(
                name: "tblCountries");

            migrationBuilder.DropTable(
                name: "tblStates");
        }
    }
}
