using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TP_Proem.Migrations
{
    public partial class fixFacturasPagos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pagos_Clientes_ClienteId",
                table: "Pagos");

            migrationBuilder.RenameColumn(
                name: "ClienteId",
                table: "Pagos",
                newName: "FacturaId");

            migrationBuilder.RenameIndex(
                name: "IX_Pagos_ClienteId",
                table: "Pagos",
                newName: "IX_Pagos_FacturaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Pagos_Facturas_FacturaId",
                table: "Pagos",
                column: "FacturaId",
                principalTable: "Facturas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pagos_Facturas_FacturaId",
                table: "Pagos");

            migrationBuilder.RenameColumn(
                name: "FacturaId",
                table: "Pagos",
                newName: "ClienteId");

            migrationBuilder.RenameIndex(
                name: "IX_Pagos_FacturaId",
                table: "Pagos",
                newName: "IX_Pagos_ClienteId");

            migrationBuilder.AddForeignKey(
                name: "FK_Pagos_Clientes_ClienteId",
                table: "Pagos",
                column: "ClienteId",
                principalTable: "Clientes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
