using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CosultorioDescktop.Migrations
{
    public partial class migracion2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TurnoDetalles",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Pacientes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Doctores",
                keyColumn: "Id",
                keyValue: 1);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Doctores",
                columns: new[] { "Id", "Apellido", "Dni", "Eliminado", "Email", "Especializacion", "FechaHoraEliminacion", "FechaNacimiento", "Localidad", "Nombre", "Sexo", "Telefono", "UsuarioId" },
                values: new object[] { 1, "Valle", 37454714, false, "ivanvallesj@gmail.com", 1, null, new DateTime(1993, 6, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "San Justo", "Ivan", 1, 3498459297.0, null });

            migrationBuilder.InsertData(
                table: "Usuarios",
                columns: new[] { "Id", "Eliminado", "FechaHoraEliminacion", "Nombre", "Password", "TipoUsuario", "User", "UsuarioId", "UsuarioId1" },
                values: new object[] { 1, false, null, "Ivan Valle", "a665a45920422f9d417e4867efdc4fb8a04a1f3fff1fa07e998e86f7f7a27ae3", 1, "Ivan", null, null });

            migrationBuilder.InsertData(
                table: "Pacientes",
                columns: new[] { "Id", "Apellido", "Direccion", "Dni", "DoctorId", "Email", "FechaNacimiento", "Localidad", "Nombre", "ObraSocial", "Sexo", "Telefono" },
                values: new object[] { 1, "Parra", "Juan Peron Y urquiza", 36196259.0, 1, "inmobiliariajuliandaniel@gmail.com", new DateTime(1992, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "San Justo", "Julian", 4, 1, 3498526969.0 });

            migrationBuilder.InsertData(
                table: "TurnoDetalles",
                columns: new[] { "Id", "Bonos", "DoctorId", "FechaTurno", "Hora", "PacienteId", "Precio", "TipoTurno" },
                values: new object[] { 1, 2, 1, new DateTime(2023, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 11, 14, 18, 48, 31, 153, DateTimeKind.Local).AddTicks(4210), 1, 300, 1 });
        }
    }
}
