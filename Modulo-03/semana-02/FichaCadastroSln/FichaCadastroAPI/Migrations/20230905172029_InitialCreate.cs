using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

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
                    DataCadastro = table.Column<DateTime>(type: "TEXT", nullable: false)
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
                    Ativado = table.Column<bool>(type: "INTEGER", nullable: false),
                    FichaId = table.Column<int>(type: "INTEGER", nullable: false),
                    DataCadastro = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Detalhe", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Detalhe_Ficha_FichaId",
                        column: x => x.FichaId,
                        principalTable: "Ficha",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Detalhe_FichaId",
                table: "Detalhe",
                column: "FichaId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Detalhe");

            migrationBuilder.DropTable(
                name: "Ficha");
        }
    }
}
