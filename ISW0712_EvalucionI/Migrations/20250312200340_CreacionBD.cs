using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace ISW0712_EvalucionI.Migrations
{
    /// <inheritdoc />
    public partial class CreacionBD : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "evaluacion1");

            migrationBuilder.CreateTable(
                name: "estudiante",
                schema: "evaluacion1",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    cedula = table.Column<string>(type: "text", nullable: false),
                    nombre = table.Column<string>(type: "text", nullable: false),
                    apellido1 = table.Column<string>(type: "text", nullable: false),
                    apellido2 = table.Column<string>(type: "text", nullable: false),
                    sexo = table.Column<string>(type: "text", nullable: false),
                    estado = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_estudiante", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "matricula",
                schema: "evaluacion1",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    fecha = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    estudiante_id = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_matricula", x => x.id);
                    table.ForeignKey(
                        name: "fk_matricula_estudiante",
                        column: x => x.estudiante_id,
                        principalSchema: "evaluacion1",
                        principalTable: "estudiante",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_matricula_estudiante_id",
                schema: "evaluacion1",
                table: "matricula",
                column: "estudiante_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "matricula",
                schema: "evaluacion1");

            migrationBuilder.DropTable(
                name: "estudiante",
                schema: "evaluacion1");
        }
    }
}
