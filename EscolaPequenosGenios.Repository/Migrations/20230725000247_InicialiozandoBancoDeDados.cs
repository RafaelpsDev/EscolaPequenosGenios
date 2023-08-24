using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EscolaPequenosGenios.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class InicialiozandoBancoDeDados : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TB_USUARIOS",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CPF = table.Column<string>(type: "VARCHAR(20)", maxLength: 20, nullable: false),
                    USUARIO = table.Column<string>(type: "VARCHAR(20)", maxLength: 20, nullable: false),
                    NOME = table.Column<string>(type: "VARCHAR(100)", maxLength: 100, nullable: false),
                    SENHA = table.Column<string>(type: "VARCHAR(150)", nullable: false),
                    SETOR = table.Column<string>(type: "VARCHAR(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_USUARIOS", x => x.ID);
                    table.CheckConstraint("CK_Setor_ValidValues", "[Setor] IN ('Secretaria', 'Adm')");
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TB_USUARIOS");
        }
    }
}
