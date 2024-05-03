using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MayTheFourth.Infra.Migrations
{
    /// <inheritdoc />
    public partial class AdicionaDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Filmes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Titulo = table.Column<string>(type: "TEXT", nullable: false),
                    Episodio = table.Column<int>(type: "INTEGER", nullable: false),
                    TextoAbertura = table.Column<string>(type: "TEXT", nullable: false),
                    Diretor = table.Column<string>(type: "TEXT", nullable: false),
                    Produtor = table.Column<string>(type: "TEXT", nullable: false),
                    DataLancamento = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Filmes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "NavesEstelares",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(type: "TEXT", nullable: false),
                    Modelo = table.Column<string>(type: "TEXT", nullable: false),
                    Fabricante = table.Column<string>(type: "TEXT", nullable: false),
                    CustoEmCreditos = table.Column<string>(type: "TEXT", nullable: false),
                    Comprimento = table.Column<string>(type: "TEXT", nullable: false),
                    VelocidadeMaxima = table.Column<string>(type: "TEXT", nullable: false),
                    Tripulacao = table.Column<string>(type: "TEXT", nullable: false),
                    Passageiros = table.Column<string>(type: "TEXT", nullable: false),
                    CapacidadeCarga = table.Column<string>(type: "TEXT", nullable: false),
                    ClassificacaoHiperdrive = table.Column<string>(type: "TEXT", nullable: false),
                    Mglt = table.Column<string>(type: "TEXT", nullable: false),
                    Consumiveis = table.Column<string>(type: "TEXT", nullable: false),
                    Classe = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NavesEstelares", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Planetas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(type: "TEXT", nullable: false),
                    PeriodoRotacao = table.Column<string>(type: "TEXT", nullable: false),
                    PeriodoOrbital = table.Column<string>(type: "TEXT", nullable: false),
                    Diametro = table.Column<string>(type: "TEXT", nullable: false),
                    Clima = table.Column<string>(type: "TEXT", nullable: false),
                    Gravidade = table.Column<string>(type: "TEXT", nullable: false),
                    Terreno = table.Column<string>(type: "TEXT", nullable: false),
                    SuperficieAquatica = table.Column<string>(type: "TEXT", nullable: false),
                    Populacao = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Planetas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Veiculos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(type: "TEXT", nullable: false),
                    Modelo = table.Column<string>(type: "TEXT", nullable: false),
                    Fabricante = table.Column<string>(type: "TEXT", nullable: false),
                    CustoEmCreditos = table.Column<string>(type: "TEXT", nullable: false),
                    Comprimento = table.Column<string>(type: "TEXT", nullable: false),
                    VelocidadeMaxima = table.Column<string>(type: "TEXT", nullable: false),
                    Tripulacao = table.Column<string>(type: "TEXT", nullable: false),
                    Passageiros = table.Column<string>(type: "TEXT", nullable: false),
                    CapacidadeCarga = table.Column<string>(type: "TEXT", nullable: false),
                    Consumiveis = table.Column<string>(type: "TEXT", nullable: false),
                    Classe = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Veiculos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FilmeNavesEstelares",
                columns: table => new
                {
                    FilmesId = table.Column<int>(type: "INTEGER", nullable: false),
                    NavesId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FilmeNavesEstelares", x => new { x.FilmesId, x.NavesId });
                    table.ForeignKey(
                        name: "FK_FilmeNavesEstelares_Filmes_FilmesId",
                        column: x => x.FilmesId,
                        principalTable: "Filmes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FilmeNavesEstelares_NavesEstelares_NavesId",
                        column: x => x.NavesId,
                        principalTable: "NavesEstelares",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FilmePlaneta",
                columns: table => new
                {
                    FilmesId = table.Column<int>(type: "INTEGER", nullable: false),
                    PlanetasId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FilmePlaneta", x => new { x.FilmesId, x.PlanetasId });
                    table.ForeignKey(
                        name: "FK_FilmePlaneta_Filmes_FilmesId",
                        column: x => x.FilmesId,
                        principalTable: "Filmes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FilmePlaneta_Planetas_PlanetasId",
                        column: x => x.PlanetasId,
                        principalTable: "Planetas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Personagens",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(type: "TEXT", nullable: false),
                    Altura = table.Column<string>(type: "TEXT", nullable: false),
                    Peso = table.Column<string>(type: "TEXT", nullable: false),
                    CorCabelo = table.Column<string>(type: "TEXT", nullable: false),
                    CorPele = table.Column<string>(type: "TEXT", nullable: false),
                    CorOlhos = table.Column<string>(type: "TEXT", nullable: false),
                    AnoNascimento = table.Column<string>(type: "TEXT", nullable: false),
                    Genero = table.Column<string>(type: "TEXT", nullable: false),
                    PlanetaId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personagens", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Personagens_Planetas_PlanetaId",
                        column: x => x.PlanetaId,
                        principalTable: "Planetas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FilmeVeiculo",
                columns: table => new
                {
                    FilmesId = table.Column<int>(type: "INTEGER", nullable: false),
                    VeiculosId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FilmeVeiculo", x => new { x.FilmesId, x.VeiculosId });
                    table.ForeignKey(
                        name: "FK_FilmeVeiculo_Filmes_FilmesId",
                        column: x => x.FilmesId,
                        principalTable: "Filmes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FilmeVeiculo_Veiculos_VeiculosId",
                        column: x => x.VeiculosId,
                        principalTable: "Veiculos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FilmePersonagem",
                columns: table => new
                {
                    FilmesId = table.Column<int>(type: "INTEGER", nullable: false),
                    PersonagensId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FilmePersonagem", x => new { x.FilmesId, x.PersonagensId });
                    table.ForeignKey(
                        name: "FK_FilmePersonagem_Filmes_FilmesId",
                        column: x => x.FilmesId,
                        principalTable: "Filmes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FilmePersonagem_Personagens_PersonagensId",
                        column: x => x.PersonagensId,
                        principalTable: "Personagens",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_FilmeNavesEstelares_NavesId",
                table: "FilmeNavesEstelares",
                column: "NavesId");

            migrationBuilder.CreateIndex(
                name: "IX_FilmePersonagem_PersonagensId",
                table: "FilmePersonagem",
                column: "PersonagensId");

            migrationBuilder.CreateIndex(
                name: "IX_FilmePlaneta_PlanetasId",
                table: "FilmePlaneta",
                column: "PlanetasId");

            migrationBuilder.CreateIndex(
                name: "IX_FilmeVeiculo_VeiculosId",
                table: "FilmeVeiculo",
                column: "VeiculosId");

            migrationBuilder.CreateIndex(
                name: "IX_Personagens_PlanetaId",
                table: "Personagens",
                column: "PlanetaId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FilmeNavesEstelares");

            migrationBuilder.DropTable(
                name: "FilmePersonagem");

            migrationBuilder.DropTable(
                name: "FilmePlaneta");

            migrationBuilder.DropTable(
                name: "FilmeVeiculo");

            migrationBuilder.DropTable(
                name: "NavesEstelares");

            migrationBuilder.DropTable(
                name: "Personagens");

            migrationBuilder.DropTable(
                name: "Filmes");

            migrationBuilder.DropTable(
                name: "Veiculos");

            migrationBuilder.DropTable(
                name: "Planetas");
        }
    }
}
