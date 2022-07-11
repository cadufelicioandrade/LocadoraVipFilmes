using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LocadoraVipFilmes.Data.Migrations
{
    public partial class colunanumeroPedido : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "NumeroPedido",
                table: "Pedidos",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NumeroPedido",
                table: "Pedidos");
        }
    }
}
