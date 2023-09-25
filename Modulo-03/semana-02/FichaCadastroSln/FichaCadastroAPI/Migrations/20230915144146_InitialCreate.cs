using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FichaCadastroAPI.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Ficha",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(type: "VARCHAR", maxLength: 120, nullable: false),
                    Email = table.Column<string>(type: "VARCHAR", maxLength: 120, nullable: false),
                    DataNascimento = table.Column<DateTime>(type: "TEXT", nullable: false),
                    DataCadastro = table.Column<DateTime>(type: "TEXT", nullable: false, defaultValue: new DateTime(2023, 9, 15, 11, 41, 46, 98, DateTimeKind.Local).AddTicks(8150))
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ficha", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Detalhe",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Feedback = table.Column<string>(type: "VARCHAR", maxLength: 500, nullable: false),
                    Nota = table.Column<int>(type: "INTEGER", nullable: false),
                    Ativo = table.Column<bool>(type: "INTEGER", nullable: false),
                    FichaId = table.Column<int>(type: "INTEGER", nullable: false),
                    DataCadastro = table.Column<DateTime>(type: "TEXT", nullable: false, defaultValue: new DateTime(2023, 9, 15, 11, 41, 46, 98, DateTimeKind.Local).AddTicks(7100))
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Detalhe", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Detalhe_Ficha_FichaId",
                        column: x => x.FichaId,
                        principalTable: "Ficha",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Telefone",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    DDD = table.Column<string>(type: "TEXT", nullable: false),
                    Numero = table.Column<string>(type: "TEXT", nullable: false),
                    Ativo = table.Column<bool>(type: "INTEGER", nullable: false),
                    FichaId = table.Column<int>(type: "INTEGER", nullable: false),
                    DataCadastro = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Telefone", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Telefone_Ficha_FichaId",
                        column: x => x.FichaId,
                        principalTable: "Ficha",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Ficha",
                columns: new[] { "Id", "DataNascimento", "Email", "Nome" },
                values: new object[,]
                {
                    { 1, new DateTime(1997, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "testes@email.com.br", "Teste" },
                    { 2, new DateTime(1997, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "testes2@email.com.br", "Teste2" },
                    { 3, new DateTime(1997, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "testes3@email.com.br", "Teste3" },
                    { 4, new DateTime(1997, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "testes4@email.com.br", "Teste4" },
                    { 5, new DateTime(1997, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "testes5@email.com.br", "Teste5" },
                    { 6, new DateTime(1997, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "testes6@email.com.br", "Teste6" },
                    { 7, new DateTime(1997, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "testes7@email.com.br", "Teste7" },
                    { 8, new DateTime(1997, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "testes8@email.com.br", "Teste8" },
                    { 9, new DateTime(1997, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "testes9@email.com.br", "Teste9" },
                    { 10, new DateTime(1997, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "testes10@email.com.br", "Teste10" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Detalhe_FichaId",
                table: "Detalhe",
                column: "FichaId");

            migrationBuilder.CreateIndex(
                name: "IX_Telefone_FichaId",
                table: "Telefone",
                column: "FichaId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Detalhe");

            migrationBuilder.DropTable(
                name: "Telefone");

            migrationBuilder.DropTable(
                name: "Ficha");
        }
    }
}
