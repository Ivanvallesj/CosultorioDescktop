using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ConsultorioDesktop.Migrations
{
    public partial class ImagenAlModeloPacientesWebCam : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte[]>(
                name: "Imagen",
                table: "Pacientes",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "TurnoDetalles",
                keyColumn: "Id",
                keyValue: 1,
                column: "Hora",
                value: new DateTime(2021, 11, 24, 22, 58, 59, 919, DateTimeKind.Local).AddTicks(8702));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Imagen",
                table: "Pacientes");

            migrationBuilder.UpdateData(
                table: "TurnoDetalles",
                keyColumn: "Id",
                keyValue: 1,
                column: "Hora",
                value: new DateTime(2021, 11, 17, 14, 37, 38, 84, DateTimeKind.Local).AddTicks(2111));
        }
    }
}
