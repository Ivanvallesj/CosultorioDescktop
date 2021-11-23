using CosultorioDescktop.Core;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CosultorioDescktop.Models
{
    public class ConsultorioContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer(@"Server=.\SQLEXPRESS; Database = ConsultorioContext; User Id = sa; Password = 123; MultipleActiveResultSets = True; ");
            optionsBuilder.UseSqlServer(HelperConsultorio.ObtenerCadenaDeConexion());
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region SemillaDoctores
            modelBuilder.Entity<Doctor>().HasData(
                new Doctor { Id = 1, Nombre = "Ivan", Apellido = "Valle", Dni = 37454714, FechaNacimiento = new DateTime(1993, 6, 29), Telefono = 3498459297, Sexo = SexoEnum.Masculino, Email = "ivanvallesj@gmail.com", Especializacion = EspecializacionEnum.Administrador, Localidad = "San Justo" }
            );
            #endregion
            #region SemillaPacientes
            modelBuilder.Entity<Paciente>().HasData(
                new Paciente { Id = 1, Nombre = "Julian", Apellido = "Parra", Direccion = "Juan Peron Y urquiza", Dni = 36196259, FechaNacimiento = new DateTime(1992, 1, 10), Telefono = 3498526969, Sexo = SexoEnum.Masculino, Email = "inmobiliariajuliandaniel@gmail.com", Localidad = "San Justo", ObraSocial = ObraSocialEnum.Medife, DoctorId = 1 }
           );
            #endregion
            #region SemillaTurnodetalle
            modelBuilder.Entity<TurnoDetalles>().HasData(
             new TurnoDetalles { Id = 1, DoctorId = 1, PacienteId = 1, FechaTurno = new DateTime(2023, 12, 2), Hora = DateTime.Now, Precio = 300, Bonos = 2, TipoTurno = TipoTurnoEnum.Consulta }
             );
            modelBuilder.Entity<TurnoDetalles>()
               .HasOne(p => p.Doctor)
               .WithMany()
               .OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<TurnoDetalles>()
                .HasOne(p => p.Paciente)
                .WithMany()
                .OnDelete(DeleteBehavior.Restrict);
            #endregion
            #region SemillaUsuarios
            modelBuilder.Entity<Usuario>().HasData(
           new Usuario { Id = 1, Nombre = "Ivan Valle", User = "Ivan", Password = "a665a45920422f9d417e4867efdc4fb8a04a1f3fff1fa07e998e86f7f7a27ae3", TipoUsuario = TipoUsuarioEnum.Administrador }
           );
            #endregion
        }
        public DbSet<Doctor> Doctores { get; set; }
        public DbSet<Paciente> Pacientes { get; set; }
        public DbSet<TurnoDetalles> TurnoDetalles { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }

        public ConsultorioContext()
        {
        }
    }
}
