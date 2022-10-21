using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace dddPrg.Infrastructure.Migrations
{
    public partial class customIdentityUserTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "OrderItem");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.CreateTable(
                name: "CustomIdentityUsers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(32)", maxLength: 32, nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(32)", maxLength: 32, nullable: true),
                    Mobile = table.Column<long>(type: "bigint", nullable: false),
                    PhotoFileName = table.Column<string>(type: "nvarchar(32)", maxLength: 32, nullable: true),
                    BirthDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LastVisitDateTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    IsEmailPublic = table.Column<bool>(type: "bit", nullable: false),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LoginCount = table.Column<int>(type: "int", nullable: false),
                    PurchaseNumber = table.Column<int>(type: "int", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomIdentityUsers", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "CustomIdentityUsers",
                columns: new[] { "Id", "AccessFailedCount", "BirthDate", "ConcurrencyStamp", "CreatedAt", "Email", "EmailConfirmed", "FirstName", "IsActive", "IsEmailPublic", "LastName", "LastVisitDateTime", "Location", "LockoutEnabled", "LockoutEnd", "LoginCount", "Mobile", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "PhotoFileName", "PurchaseNumber", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { 1, 0, null, "9acaaad7-f831-4b95-b4d6-59e06e7920ec", new DateTime(2022, 10, 21, 23, 39, 4, 492, DateTimeKind.Local).AddTicks(5206), "mohebi.hadi1996@gmail.com", false, null, true, true, null, null, null, false, null, 0, 9034456L, null, null, null, "12345666", true, null, 0, null, false, "hadiMhb" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Body", "CreatedAt", "FilePath", "ImagePath", "IsDeleted", "IsSellable", "IsVisible", "Price", "ProductCategoryId", "Title" },
                values: new object[] { 3, "body 2", new DateTime(2022, 10, 21, 23, 39, 4, 491, DateTimeKind.Local).AddTicks(3178), "file path", "image path", false, false, true, 1000m, (short)1, "title 2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Body", "CreatedAt", "FilePath", "ImagePath", "IsDeleted", "IsSellable", "IsVisible", "Price", "ProductCategoryId", "Title" },
                values: new object[] { 2, "body", new DateTime(2022, 10, 21, 23, 39, 4, 488, DateTimeKind.Local).AddTicks(2987), "file path", "image path", false, true, true, 1000m, (short)1, "title" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CustomIdentityUsers");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Orders");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "OrderItem",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
