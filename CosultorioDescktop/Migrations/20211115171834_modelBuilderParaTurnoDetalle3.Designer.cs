﻿// <auto-generated />
using System;
using CosultorioDescktop.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CosultorioDescktop.Migrations
{
    [DbContext(typeof(ConsultorioContext))]
    [Migration("20211115171834_modelBuilderParaTurnoDetalle3")]
    partial class modelBuilderParaTurnoDetalle3
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CosultorioDescktop.Models.Doctor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Apellido")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Dni")
                        .HasColumnType("int");

                    b.Property<bool>("Eliminado")
                        .HasColumnType("bit");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Especializacion")
                        .HasColumnType("int");

                    b.Property<DateTime?>("FechaHoraEliminacion")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("FechaNacimiento")
                        .HasColumnType("datetime2");

                    b.Property<string>("Localidad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Sexo")
                        .HasColumnType("int");

                    b.Property<double>("Telefono")
                        .HasColumnType("float");

                    b.Property<int?>("UsuarioId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UsuarioId");

                    b.ToTable("Doctores");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Apellido = "Valle",
                            Dni = 37454714,
                            Eliminado = false,
                            Email = "ivanvallesj@gmail.com",
                            Especializacion = 1,
                            FechaNacimiento = new DateTime(1993, 6, 29, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Localidad = "San Justo",
                            Nombre = "Ivan",
                            Sexo = 1,
                            Telefono = 3498459297.0
                        });
                });

            modelBuilder.Entity("CosultorioDescktop.Models.Paciente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Apellido")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Direccion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Dni")
                        .HasColumnType("float");

                    b.Property<int>("DoctorId")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("FechaNacimiento")
                        .HasColumnType("datetime2");

                    b.Property<string>("Localidad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ObraSocial")
                        .HasColumnType("int");

                    b.Property<int>("Sexo")
                        .HasColumnType("int");

                    b.Property<double>("Telefono")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("DoctorId");

                    b.ToTable("Pacientes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Apellido = "Parra",
                            Direccion = "Juan Peron Y urquiza",
                            Dni = 36196259.0,
                            DoctorId = 1,
                            Email = "inmobiliariajuliandaniel@gmail.com",
                            FechaNacimiento = new DateTime(1992, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Localidad = "San Justo",
                            Nombre = "Julian",
                            ObraSocial = 4,
                            Sexo = 1,
                            Telefono = 3498526969.0
                        });
                });

            modelBuilder.Entity("CosultorioDescktop.Models.TurnoDetalles", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Bonos")
                        .HasColumnType("int");

                    b.Property<int>("DoctorId")
                        .HasColumnType("int");

                    b.Property<DateTime>("FechaTurno")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Hora")
                        .HasColumnType("datetime2");

                    b.Property<int>("PacienteId")
                        .HasColumnType("int");

                    b.Property<int>("Precio")
                        .HasColumnType("int");

                    b.Property<int>("TipoTurno")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("DoctorId");

                    b.HasIndex("PacienteId");

                    b.ToTable("TurnoDetalles");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Bonos = 2,
                            DoctorId = 1,
                            FechaTurno = new DateTime(2023, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Hora = new DateTime(2021, 11, 15, 14, 18, 34, 112, DateTimeKind.Local).AddTicks(1519),
                            PacienteId = 1,
                            Precio = 300,
                            TipoTurno = 1
                        });
                });

            modelBuilder.Entity("CosultorioDescktop.Models.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Eliminado")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("FechaHoraEliminacion")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TipoUsuario")
                        .HasColumnType("int");

                    b.Property<string>("User")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("UsuarioId")
                        .HasColumnType("int");

                    b.Property<int?>("UsuarioId1")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UsuarioId1");

                    b.ToTable("Usuarios");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Eliminado = false,
                            Nombre = "Ivan Valle",
                            Password = "a665a45920422f9d417e4867efdc4fb8a04a1f3fff1fa07e998e86f7f7a27ae3",
                            TipoUsuario = 1,
                            User = "Ivan"
                        });
                });

            modelBuilder.Entity("CosultorioDescktop.Models.Doctor", b =>
                {
                    b.HasOne("CosultorioDescktop.Models.Usuario", "Usuario")
                        .WithMany()
                        .HasForeignKey("UsuarioId");
                });

            modelBuilder.Entity("CosultorioDescktop.Models.Paciente", b =>
                {
                    b.HasOne("CosultorioDescktop.Models.Doctor", "Doctor")
                        .WithMany("Pacientes")
                        .HasForeignKey("DoctorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CosultorioDescktop.Models.TurnoDetalles", b =>
                {
                    b.HasOne("CosultorioDescktop.Models.Doctor", "Doctor")
                        .WithMany()
                        .HasForeignKey("DoctorId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("CosultorioDescktop.Models.Paciente", "Paciente")
                        .WithMany()
                        .HasForeignKey("PacienteId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("CosultorioDescktop.Models.Usuario", b =>
                {
                    b.HasOne("CosultorioDescktop.Models.Usuario", "Usuario")
                        .WithMany()
                        .HasForeignKey("UsuarioId1");
                });
#pragma warning restore 612, 618
        }
    }
}
