using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ConsultorioDesktop.Models
{
    public class Doctor:ModeloBase
    {
        public int Id { get; set; }
        [Required]
        public string Nombre { get; set; }
        [Required]
        public string Apellido { get; set; }
        public int Dni { get; set; }
        [Required]
        public DateTime FechaNacimiento { get; set; }
        [Required]
        public double Telefono { get; set; }
  
        public SexoEnum Sexo { get; set; }
        
        public string Email { get; set; }
        [Required]
        public string Localidad { get; set; }
        [Required]
        public EspecializacionEnum Especializacion { get; set; }
        public ICollection<Paciente> Pacientes { get; set; }
        //public ICollection<TurnoDetalles> TurnoDetalles { get; set; }
    }
}
