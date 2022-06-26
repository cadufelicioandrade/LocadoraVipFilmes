using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LocadoraVipFilmes.Auth.API.Migrations
{
    public partial class user_admin : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { 99999, "1dc0086b-46f7-44e5-84c4-5c5a38548109", "admin", "ADMIN'" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { 99999, 0, "7392fd63-9e64-4d75-aaea-ce89e474569f", "admin@admin.com", true, false, null, "ADMIN@ADMIN.COM", "ADMIN", "AQAAAAEAACcQAAAAENXEiYgyEViVu0/V7OLLA0+lotm25qpfKyoVDCljA+2ajtH48xGz8oAhOZtCTwMaeA==", null, false, "14c8f9d6-401e-4398-80c6-bd2119a8f591", false, "admin" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { 99999, 99999 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 99999, 99999 });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 99999);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 99999);
        }
    }
}
