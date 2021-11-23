using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ConsultorioDesktop.Migrations
{
    public partial class ImplementacionDeModeloBaseAlosModelosPacientesYTurnoDetalle : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Eliminado",
                table: "TurnoDetalles",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaHoraEliminacion",
                table: "TurnoDetalles",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UsuarioId",
                table: "TurnoDetalles",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Eliminado",
                table: "Pacientes",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaHoraEliminacion",
                table: "Pacientes",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UsuarioId",
                table: "Pacientes",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "TurnoDetalles",
                keyColumn: "Id",
                keyValue: 1,
                column: "Hora",
                value: new DateTime(2021, 11, 17, 14, 37, 38, 84, DateTimeKind.Local).AddTicks(2111));

            migrationBuilder.CreateIndex(
                name: "IX_TurnoDetalles_UsuarioId",
                table: "TurnoDetalles",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Pacientes_UsuarioId",
                table: "Pacientes",
                column: "UsuarioId");

            migrationBuilder.AddForeignKey(
                name: "FK_Pacientes_Usuarios_UsuarioId",
                table: "Pacientes",
                column: "UsuarioId",
                principalTable: "Usuarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TurnoDetalles_Usuarios_UsuarioId",
                table: "TurnoDetalles",
                column: "UsuarioId",
                principalTable: "Usuarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pacientes_Usuarios_UsuarioId",
                table: "Pacientes");

            migrationBuilder.DropForeignKey(
                name: "FK_TurnoDetalles_Usuarios_UsuarioId",
                table: "TurnoDetalles");

            migrationBuilder.DropIndex(
                name: "IX_TurnoDetalles_UsuarioId",
                table: "TurnoDetalles");

            migrationBuilder.DropIndex(
                name: "IX_Pacientes_UsuarioId",
                table: "Pacientes");

            migrationBuilder.DropColumn(
                name: "Eliminado",
                table: "TurnoDetalles");

            migrationBuilder.DropColumn(
                name: "FechaHoraEliminacion",
                table: "TurnoDetalles");

            migrationBuilder.DropColumn(
                name: "UsuarioId",
                table: "TurnoDetalles");

            migrationBuilder.DropColumn(
                name: "Eliminado",
                table: "Pacientes");

            migrationBuilder.DropColumn(
                name: "FechaHoraEliminacion",
                table: "Pacientes");

            migrationBuilder.DropColumn(
                name: "UsuarioId",
                table: "Pacientes");

            migrationBuilder.UpdateData(
                table: "TurnoDetalles",
                keyColumn: "Id",
                keyValue: 1,
                column: "Hora",
                value: new DateTime(2021, 11, 16, 9, 38, 0, 16, DateTimeKind.Local).AddTicks(6677));
        }
    }
}
