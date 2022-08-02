using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjetoVillaBeach.Migrations
{
    public partial class UpdateTelefone : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Observacao",
                table: "Telefones");

            migrationBuilder.RenameColumn(
                name: "IdTelefone",
                table: "Telefones",
                newName: "Id");

            migrationBuilder.AddColumn<string>(
                name: "Obs",
                table: "Telefones",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Obs",
                table: "Telefones");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Telefones",
                newName: "IdTelefone");

            migrationBuilder.AddColumn<string>(
                name: "Observacao",
                table: "Telefones",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");
        }
    }
}
