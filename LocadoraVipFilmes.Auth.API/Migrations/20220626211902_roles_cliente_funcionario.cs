using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LocadoraVipFilmes.Auth.API.Migrations
{
    public partial class roles_cliente_funcionario : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 99999,
                columns: new[] { "ConcurrencyStamp", "NormalizedName" },
                values: new object[] { "0b47b872-9034-448d-88e2-61916f1ca702", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { 99997, "c262a782-a720-45d0-bd7e-4d1b4450621d", "cliente", "cliente" },
                    { 99998, "15ec9884-0ca1-47c2-9ea2-e7f110fc83ce", "funcionario", "funcionario" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 99999,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9410f607-e843-4461-b054-f3758cc9608b", "AQAAAAEAACcQAAAAENncAndiyylOyFiXIlUcgvYSz/m5xtjGbUIsswSEzyReWaYMU3slaJaI8TLbYaHOdg==", "8f94068f-782b-4b57-b788-81dee207f91b" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 99997);

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 99998);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 99999,
                columns: new[] { "ConcurrencyStamp", "NormalizedName" },
                values: new object[] { "1dc0086b-46f7-44e5-84c4-5c5a38548109", "ADMIN'" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 99999,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7392fd63-9e64-4d75-aaea-ce89e474569f", "AQAAAAEAACcQAAAAENXEiYgyEViVu0/V7OLLA0+lotm25qpfKyoVDCljA+2ajtH48xGz8oAhOZtCTwMaeA==", "14c8f9d6-401e-4398-80c6-bd2119a8f591" });
        }
    }
}
