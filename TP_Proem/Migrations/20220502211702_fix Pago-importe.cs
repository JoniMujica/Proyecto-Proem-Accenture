using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TP_Proem.Migrations
{
    public partial class fixPagoimporte : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "Importte",
                table: "Pagos",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Importte",
                table: "Pagos");
        }
    }
}
