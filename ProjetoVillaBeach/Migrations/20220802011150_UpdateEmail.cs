using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjetoVillaBeach.Migrations
{
    public partial class UpdateEmail : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Endereco",
                table: "Emails");

            migrationBuilder.RenameColumn(
                name: "Observacao",
                table: "Emails",
                newName: "EmailAddress");

            migrationBuilder.RenameColumn(
                name: "IdEmail",
                table: "Emails",
                newName: "Id");

            migrationBuilder.AddColumn<string>(
                name: "Obs",
                table: "Emails",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Obs",
                table: "Emails");

            migrationBuilder.RenameColumn(
                name: "EmailAddress",
                table: "Emails",
                newName: "Observacao");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Emails",
                newName: "IdEmail");

            migrationBuilder.AddColumn<string>(
                name: "Endereco",
                table: "Emails",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");
        }
    }
}
