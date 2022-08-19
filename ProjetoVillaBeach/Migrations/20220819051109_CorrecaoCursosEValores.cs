using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjetoVillaBeach.Migrations
{
    public partial class CorrecaoCursosEValores : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Matriculas_Modalidades_IdModalidade",
                table: "Matriculas");

            migrationBuilder.DropForeignKey(
                name: "FK_Mensalidades_ValoresModalidades_IdValorModalidade",
                table: "Mensalidades");

            migrationBuilder.DropTable(
                name: "ValoresModalidades");

            migrationBuilder.DropTable(
                name: "Modalidades");

            migrationBuilder.DropIndex(
                name: "IX_Mensalidades_IdValorModalidade",
                table: "Mensalidades");

            migrationBuilder.AddColumn<int>(
                name: "ValoresModalidadeId",
                table: "Mensalidades",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Courses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    DataInicio = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    DataFim = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    Name = table.Column<string>(type: "varchar(150)", maxLength: 150, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Description = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Courses", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Prices",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Value = table.Column<decimal>(type: "decimal(10,2)", precision: 10, scale: 2, nullable: false),
                    CourseId = table.Column<int>(type: "int", nullable: true),
                    DataInicio = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    DataFim = table.Column<DateTime>(type: "datetime(6)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Prices", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Prices_Courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Courses",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_Mensalidades_ValoresModalidadeId",
                table: "Mensalidades",
                column: "ValoresModalidadeId");

            migrationBuilder.CreateIndex(
                name: "IX_Prices_CourseId",
                table: "Prices",
                column: "CourseId");

            migrationBuilder.AddForeignKey(
                name: "FK_Matriculas_Courses_IdModalidade",
                table: "Matriculas",
                column: "IdModalidade",
                principalTable: "Courses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Mensalidades_Prices_ValoresModalidadeId",
                table: "Mensalidades",
                column: "ValoresModalidadeId",
                principalTable: "Prices",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Matriculas_Courses_IdModalidade",
                table: "Matriculas");

            migrationBuilder.DropForeignKey(
                name: "FK_Mensalidades_Prices_ValoresModalidadeId",
                table: "Mensalidades");

            migrationBuilder.DropTable(
                name: "Prices");

            migrationBuilder.DropTable(
                name: "Courses");

            migrationBuilder.DropIndex(
                name: "IX_Mensalidades_ValoresModalidadeId",
                table: "Mensalidades");

            migrationBuilder.DropColumn(
                name: "ValoresModalidadeId",
                table: "Mensalidades");

            migrationBuilder.CreateTable(
                name: "Modalidades",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    DataFinal = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    DataInicial = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Nome = table.Column<string>(type: "varchar(150)", maxLength: 150, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Observacao = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Modalidades", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ValoresModalidades",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    IdModalidade = table.Column<int>(type: "int", nullable: false),
                    DataFim = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    DataInicio = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Valor = table.Column<decimal>(type: "decimal(10,2)", precision: 10, scale: 2, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ValoresModalidades", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ValoresModalidades_Modalidades_IdModalidade",
                        column: x => x.IdModalidade,
                        principalTable: "Modalidades",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_Mensalidades_IdValorModalidade",
                table: "Mensalidades",
                column: "IdValorModalidade");

            migrationBuilder.CreateIndex(
                name: "IX_ValoresModalidades_IdModalidade",
                table: "ValoresModalidades",
                column: "IdModalidade");

            migrationBuilder.AddForeignKey(
                name: "FK_Matriculas_Modalidades_IdModalidade",
                table: "Matriculas",
                column: "IdModalidade",
                principalTable: "Modalidades",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Mensalidades_ValoresModalidades_IdValorModalidade",
                table: "Mensalidades",
                column: "IdValorModalidade",
                principalTable: "ValoresModalidades",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
