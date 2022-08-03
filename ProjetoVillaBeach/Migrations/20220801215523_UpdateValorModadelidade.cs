using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjetoVillaBeach.Migrations
{
    public partial class UpdateValorModadelidade : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IdValoresModalidades",
                table: "ValoresModalidades",
                newName: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "ValoresModalidades",
                newName: "IdValoresModalidades");
        }
    }
}
