using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjetoVillaBeach.Migrations
{
    public partial class UpdatePessoa : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Pessoas_NumeroCpf",
                table: "Pessoas");

            migrationBuilder.RenameColumn(
                name: "IdPessoa",
                table: "Pessoas",
                newName: "Id");

            migrationBuilder.AlterColumn<ulong>(
                name: "NumeroCpf",
                table: "Pessoas",
                type: "bigint unsigned",
                nullable: true,
                oldClrType: typeof(ulong),
                oldType: "bigint unsigned");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeCadastro",
                table: "Pessoas",
                type: "datetime(6)",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Pessoas",
                newName: "IdPessoa");

            migrationBuilder.AlterColumn<ulong>(
                name: "NumeroCpf",
                table: "Pessoas",
                type: "bigint unsigned",
                nullable: false,
                defaultValue: 0ul,
                oldClrType: typeof(ulong),
                oldType: "bigint unsigned",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeCadastro",
                table: "Pessoas",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Pessoas_NumeroCpf",
                table: "Pessoas",
                column: "NumeroCpf",
                unique: true);
        }
    }
}
