using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GerenciamentoMensalidade.Migrations
{
    /// <inheritdoc />
    public partial class Plano : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropUniqueConstraint(
                name: "AK_Plano_TempId",
                table: "Plano");

            migrationBuilder.RenameColumn(
                name: "TempId",
                table: "Plano",
                newName: "Id");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Plano",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<string>(
                name: "DiasPorSemana",
                table: "Plano",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Nome",
                table: "Plano",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Plano",
                table: "Plano",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Plano",
                table: "Plano");

            migrationBuilder.DropColumn(
                name: "DiasPorSemana",
                table: "Plano");

            migrationBuilder.DropColumn(
                name: "Nome",
                table: "Plano");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Plano",
                newName: "TempId");

            migrationBuilder.AlterColumn<int>(
                name: "TempId",
                table: "Plano",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddUniqueConstraint(
                name: "AK_Plano_TempId",
                table: "Plano",
                column: "TempId");
        }
    }
}
