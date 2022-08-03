using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjetoVillaBeach.Migrations
{
    public partial class Inicio : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Modalidades",
                columns: table => new
                {
                    IdModalidade = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(type: "varchar(150)", maxLength: 150, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Observacao = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DataInicial = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    DataFinal = table.Column<DateTime>(type: "datetime(6)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Modalidades", x => x.IdModalidade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Pessoas",
                columns: table => new
                {
                    IdPessoa = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    NumeroCpf = table.Column<ulong>(type: "bigint unsigned", nullable: false),
                    NumeroRg = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Nome = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Filiacao1 = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Filiacao2 = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DataDeNascimento = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    DataDeCadastro = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pessoas", x => x.IdPessoa);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ValoresModalidades",
                columns: table => new
                {
                    IdValoresModalidades = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Valor = table.Column<double>(type: "double", nullable: false),
                    DataInicio = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    DataFim = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    IdModalidade = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ValoresModalidades", x => x.IdValoresModalidades);
                    table.ForeignKey(
                        name: "FK_ValoresModalidades_Modalidades_IdModalidade",
                        column: x => x.IdModalidade,
                        principalTable: "Modalidades",
                        principalColumn: "IdModalidade",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Emails",
                columns: table => new
                {
                    IdEmail = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Endereco = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Observacao = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IdPessoa = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Emails", x => x.IdEmail);
                    table.ForeignKey(
                        name: "FK_Emails_Pessoas_IdPessoa",
                        column: x => x.IdPessoa,
                        principalTable: "Pessoas",
                        principalColumn: "IdPessoa",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Enderecos",
                columns: table => new
                {
                    IdEndereco = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Cep = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Logradouro = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Numero = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Bairro = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Localidade = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Uf = table.Column<string>(type: "varchar(2)", maxLength: 2, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Obs = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IdPessoa = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Enderecos", x => x.IdEndereco);
                    table.ForeignKey(
                        name: "FK_Enderecos_Pessoas_IdPessoa",
                        column: x => x.IdPessoa,
                        principalTable: "Pessoas",
                        principalColumn: "IdPessoa",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Matriculas",
                columns: table => new
                {
                    IdMatricula = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    DataInicio = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    DataFim = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    IdPessoa = table.Column<int>(type: "int", nullable: false),
                    IdModalidade = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Matriculas", x => x.IdMatricula);
                    table.ForeignKey(
                        name: "FK_Matriculas_Modalidades_IdModalidade",
                        column: x => x.IdModalidade,
                        principalTable: "Modalidades",
                        principalColumn: "IdModalidade",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Matriculas_Pessoas_IdPessoa",
                        column: x => x.IdPessoa,
                        principalTable: "Pessoas",
                        principalColumn: "IdPessoa",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Telefones",
                columns: table => new
                {
                    IdTelefone = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Numero = table.Column<int>(type: "int", nullable: false),
                    Observacao = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IdPessoa = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Telefones", x => x.IdTelefone);
                    table.ForeignKey(
                        name: "FK_Telefones_Pessoas_IdPessoa",
                        column: x => x.IdPessoa,
                        principalTable: "Pessoas",
                        principalColumn: "IdPessoa",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Mensalidades",
                columns: table => new
                {
                    IdMensalidade = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    DataGerada = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    DataVencimento = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    DataPagamento = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    IdMatricula = table.Column<int>(type: "int", nullable: false),
                    IdValorModalidade = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mensalidades", x => x.IdMensalidade);
                    table.ForeignKey(
                        name: "FK_Mensalidades_Matriculas_IdMatricula",
                        column: x => x.IdMatricula,
                        principalTable: "Matriculas",
                        principalColumn: "IdMatricula",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Mensalidades_ValoresModalidades_IdValorModalidade",
                        column: x => x.IdValorModalidade,
                        principalTable: "ValoresModalidades",
                        principalColumn: "IdValoresModalidades",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_Emails_IdPessoa",
                table: "Emails",
                column: "IdPessoa");

            migrationBuilder.CreateIndex(
                name: "IX_Enderecos_IdPessoa",
                table: "Enderecos",
                column: "IdPessoa");

            migrationBuilder.CreateIndex(
                name: "IX_Matriculas_IdModalidade",
                table: "Matriculas",
                column: "IdModalidade");

            migrationBuilder.CreateIndex(
                name: "IX_Matriculas_IdPessoa",
                table: "Matriculas",
                column: "IdPessoa");

            migrationBuilder.CreateIndex(
                name: "IX_Mensalidades_IdMatricula",
                table: "Mensalidades",
                column: "IdMatricula");

            migrationBuilder.CreateIndex(
                name: "IX_Mensalidades_IdValorModalidade",
                table: "Mensalidades",
                column: "IdValorModalidade");

            migrationBuilder.CreateIndex(
                name: "IX_Pessoas_NumeroCpf",
                table: "Pessoas",
                column: "NumeroCpf",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Telefones_IdPessoa",
                table: "Telefones",
                column: "IdPessoa");

            migrationBuilder.CreateIndex(
                name: "IX_ValoresModalidades_IdModalidade",
                table: "ValoresModalidades",
                column: "IdModalidade");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Emails");

            migrationBuilder.DropTable(
                name: "Enderecos");

            migrationBuilder.DropTable(
                name: "Mensalidades");

            migrationBuilder.DropTable(
                name: "Telefones");

            migrationBuilder.DropTable(
                name: "Matriculas");

            migrationBuilder.DropTable(
                name: "ValoresModalidades");

            migrationBuilder.DropTable(
                name: "Pessoas");

            migrationBuilder.DropTable(
                name: "Modalidades");
        }
    }
}
