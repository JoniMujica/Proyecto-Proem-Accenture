using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TP_Proem.Migrations
{
    public partial class fixFacturas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ClientId",
                table: "Facturas");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ClientId",
                table: "Facturas",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
