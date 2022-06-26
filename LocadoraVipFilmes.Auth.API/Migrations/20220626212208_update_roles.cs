using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LocadoraVipFilmes.Auth.API.Migrations
{
    public partial class update_roles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 99997,
                columns: new[] { "ConcurrencyStamp", "NormalizedName" },
                values: new object[] { "b4af667b-e4ca-43ef-a11f-0ea360719593", "CLIENTE" });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 99998,
                columns: new[] { "ConcurrencyStamp", "NormalizedName" },
                values: new object[] { "1c34fa43-e391-435b-bfa4-188ec8881518", "FUNCIONARIO" });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 99999,
                column: "ConcurrencyStamp",
                value: "d559aff5-355a-47dc-a747-5c761fbb0ce4");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 99999,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "99d06f71-48cd-4909-bce5-4c7f1b4acdf2", "AQAAAAEAACcQAAAAEFaoLinul7XWrKoBGphEyKkJh7f0PFmLl+sUhaF8MgV+lvQ3TXw1BU12CvL03uDeMA==", "3e23466c-8044-4348-b974-299d6841c4af" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 99997,
                columns: new[] { "ConcurrencyStamp", "NormalizedName" },
                values: new object[] { "c262a782-a720-45d0-bd7e-4d1b4450621d", "cliente" });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 99998,
                columns: new[] { "ConcurrencyStamp", "NormalizedName" },
                values: new object[] { "15ec9884-0ca1-47c2-9ea2-e7f110fc83ce", "funcionario" });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 99999,
                column: "ConcurrencyStamp",
                value: "0b47b872-9034-448d-88e2-61916f1ca702");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 99999,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9410f607-e843-4461-b054-f3758cc9608b", "AQAAAAEAACcQAAAAENncAndiyylOyFiXIlUcgvYSz/m5xtjGbUIsswSEzyReWaYMU3slaJaI8TLbYaHOdg==", "8f94068f-782b-4b57-b788-81dee207f91b" });
        }
    }
}
