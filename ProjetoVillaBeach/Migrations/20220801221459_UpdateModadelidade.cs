using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjetoVillaBeach.Migrations
{
    public partial class UpdateModadelidade : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IdModalidade",
                table: "Modalidades",
                newName: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Modalidades",
                newName: "IdModalidade");
        }
    }
}
