using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjetoVillaBeach.Migrations
{
    public partial class UpdateMensalidadeMatricula : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IdMensalidade",
                table: "Mensalidades",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "IdMatricula",
                table: "Matriculas",
                newName: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Mensalidades",
                newName: "IdMensalidade");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Matriculas",
                newName: "IdMatricula");
        }
    }
}
