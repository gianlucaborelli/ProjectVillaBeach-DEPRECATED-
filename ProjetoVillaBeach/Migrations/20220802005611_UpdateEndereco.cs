using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjetoVillaBeach.Migrations
{
    public partial class UpdateEndereco : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IdEndereco",
                table: "Enderecos",
                newName: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Enderecos",
                newName: "IdEndereco");
        }
    }
}
