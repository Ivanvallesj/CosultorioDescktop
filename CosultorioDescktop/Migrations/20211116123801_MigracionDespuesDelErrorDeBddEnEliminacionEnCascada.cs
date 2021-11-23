using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ConsultorioDesktop.Migrations
{
    public partial class MigracionDespuesDelErrorDeBddEnEliminacionEnCascada : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UsuarioId = table.Column<int>(nullable: true),
                    UsuarioId1 = table.Column<int>(nullable: true),
                    FechaHoraEliminacion = table.Column<DateTime>(nullable: true),
                    Eliminado = table.Column<bool>(nullable: false),
                    Nombre = table.Column<string>(nullable: false),
                    User = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true),
                    TipoUsuario = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Usuarios_Usuarios_UsuarioId1",
                        column: x => x.UsuarioId1,
                        principalTable: "Usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Doctores",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UsuarioId = table.Column<int>(nullable: true),
                    FechaHoraEliminacion = table.Column<DateTime>(nullable: true),
                    Eliminado = table.Column<bool>(nullable: false),
                    Nombre = table.Column<string>(nullable: false),
                    Apellido = table.Column<string>(nullable: false),
                    Dni = table.Column<int>(nullable: false),
                    FechaNacimiento = table.Column<DateTime>(nullable: false),
                    Telefono = table.Column<double>(nullable: false),
                    Sexo = table.Column<int>(nullable: false),
                    Email = table.Column<string>(nullable: true),
                    Localidad = table.Column<string>(nullable: false),
                    Especializacion = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Doctores", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Doctores_Usuarios_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Pacientes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(nullable: false),
                    Apellido = table.Column<string>(nullable: false),
                    Direccion = table.Column<string>(nullable: false),
                    Dni = table.Column<double>(nullable: false),
                    FechaNacimiento = table.Column<DateTime>(nullable: false),
                    Telefono = table.Column<double>(nullable: false),
                    Sexo = table.Column<int>(nullable: false),
                    Email = table.Column<string>(nullable: true),
                    Localidad = table.Column<string>(nullable: false),
                    ObraSocial = table.Column<int>(nullable: false),
                    DoctorId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pacientes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Pacientes_Doctores_DoctorId",
                        column: x => x.DoctorId,
                        principalTable: "Doctores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TurnoDetalles",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FechaTurno = table.Column<DateTime>(nullable: false),
                    Hora = table.Column<DateTime>(nullable: false),
                    TipoTurno = table.Column<int>(nullable: false),
                    Precio = table.Column<int>(nullable: false),
                    Bonos = table.Column<int>(nullable: false),
                    DoctorId = table.Column<int>(nullable: false),
                    PacienteId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TurnoDetalles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TurnoDetalles_Doctores_DoctorId",
                        column: x => x.DoctorId,
                        principalTable: "Doctores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TurnoDetalles_Pacientes_PacienteId",
                        column: x => x.PacienteId,
                        principalTable: "Pacientes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

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
                values: new object[] { 1, 2, 1, new DateTime(2023, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 11, 16, 9, 38, 0, 16, DateTimeKind.Local).AddTicks(6677), 1, 300, 1 });

            migrationBuilder.CreateIndex(
                name: "IX_Doctores_UsuarioId",
                table: "Doctores",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Pacientes_DoctorId",
                table: "Pacientes",
                column: "DoctorId");

            migrationBuilder.CreateIndex(
                name: "IX_TurnoDetalles_DoctorId",
                table: "TurnoDetalles",
                column: "DoctorId");

            migrationBuilder.CreateIndex(
                name: "IX_TurnoDetalles_PacienteId",
                table: "TurnoDetalles",
                column: "PacienteId");

            migrationBuilder.CreateIndex(
                name: "IX_Usuarios_UsuarioId1",
                table: "Usuarios",
                column: "UsuarioId1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TurnoDetalles");

            migrationBuilder.DropTable(
                name: "Pacientes");

            migrationBuilder.DropTable(
                name: "Doctores");

            migrationBuilder.DropTable(
                name: "Usuarios");
        }
    }
}
