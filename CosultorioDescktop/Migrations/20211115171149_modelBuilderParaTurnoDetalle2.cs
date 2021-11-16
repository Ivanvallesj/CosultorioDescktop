using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CosultorioDescktop.Migrations
{
    public partial class modelBuilderParaTurnoDetalle2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "TurnoDetalles",
                keyColumn: "Id",
                keyValue: 1,
                column: "Hora",
                value: new DateTime(2021, 11, 15, 14, 11, 48, 629, DateTimeKind.Local).AddTicks(9802));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "TurnoDetalles",
                keyColumn: "Id",
                keyValue: 1,
                column: "Hora",
                value: new DateTime(2021, 11, 15, 14, 6, 1, 31, DateTimeKind.Local).AddTicks(4078));
        }
    }
}
