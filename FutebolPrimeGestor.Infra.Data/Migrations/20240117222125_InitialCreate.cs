using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FutebolPrimeGestor.Infra.Data.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nome = table.Column<string>(type: "VARCHAR(200)", nullable: false),
                    CPF = table.Column<string>(type: "CHAR(11)", nullable: false),
                    Contato = table.Column<string>(type: "CHAR(11)", nullable: false),
                    DataCriacao = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Quadras",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TipoQuadra = table.Column<int>(type: "int", nullable: false),
                    Numero = table.Column<int>(type: "int", nullable: false),
                    Valor = table.Column<double>(type: "float", nullable: false),
                    Ativa = table.Column<bool>(type: "bit", nullable: false),
                    HorarioInicioFuncionamento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    HorarioFimFuncionamento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataCriacao = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Quadras", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AlugueisDeQuadras",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdCliente = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdQuadra = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    InicioAluguel = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FimAluguel = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ValorFinalAluguel = table.Column<double>(type: "float", nullable: true),
                    DataCriacao = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AlugueisDeQuadras", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AlugueisDeQuadras_Clientes_IdCliente",
                        column: x => x.IdCliente,
                        principalTable: "Clientes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AlugueisDeQuadras_Quadras_IdQuadra",
                        column: x => x.IdQuadra,
                        principalTable: "Quadras",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AlugueisDeQuadras_IdCliente",
                table: "AlugueisDeQuadras",
                column: "IdCliente");

            migrationBuilder.CreateIndex(
                name: "IX_AlugueisDeQuadras_IdQuadra",
                table: "AlugueisDeQuadras",
                column: "IdQuadra");

            migrationBuilder.CreateIndex(
                name: "idx_cliente_cpf",
                table: "Clientes",
                column: "CPF");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AlugueisDeQuadras");

            migrationBuilder.DropTable(
                name: "Clientes");

            migrationBuilder.DropTable(
                name: "Quadras");
        }
    }
}
