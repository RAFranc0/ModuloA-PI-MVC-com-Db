using Microsoft.EntityFrameworkCore.Migrations;

namespace Atv4.Migrations
{
    public partial class SegundaMigracao : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_eventos_usuarios_UsuarioId",
                table: "eventos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_usuarios",
                table: "usuarios");

            migrationBuilder.DropPrimaryKey(
                name: "PK_eventos",
                table: "eventos");

            migrationBuilder.DropIndex(
                name: "IX_eventos_UsuarioId",
                table: "eventos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_contatos",
                table: "contatos");

            migrationBuilder.RenameTable(
                name: "usuarios",
                newName: "Usuarios");

            migrationBuilder.RenameTable(
                name: "eventos",
                newName: "Eventos");

            migrationBuilder.RenameTable(
                name: "contatos",
                newName: "Contatos");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Usuarios",
                table: "Usuarios",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Eventos",
                table: "Eventos",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Contatos",
                table: "Contatos",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Usuarios",
                table: "Usuarios");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Eventos",
                table: "Eventos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Contatos",
                table: "Contatos");

            migrationBuilder.RenameTable(
                name: "Usuarios",
                newName: "usuarios");

            migrationBuilder.RenameTable(
                name: "Eventos",
                newName: "eventos");

            migrationBuilder.RenameTable(
                name: "Contatos",
                newName: "contatos");

            migrationBuilder.AddPrimaryKey(
                name: "PK_usuarios",
                table: "usuarios",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_eventos",
                table: "eventos",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_contatos",
                table: "contatos",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_eventos_UsuarioId",
                table: "eventos",
                column: "UsuarioId");

            migrationBuilder.AddForeignKey(
                name: "FK_eventos_usuarios_UsuarioId",
                table: "eventos",
                column: "UsuarioId",
                principalTable: "usuarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
