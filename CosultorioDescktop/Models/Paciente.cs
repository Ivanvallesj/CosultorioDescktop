using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ConsultorioDesktop.Models
{
    public class Paciente : ModeloBase
    {
        public int Id { get; set; }
        [Required]
        public string Nombre { get; set; }
        [Required]
        public string Apellido { get; set; }
        [Required]
        public string Direccion { get; set; }
        [Required]
        public double Dni { get; set; }
        [Required]
        public DateTime FechaNacimiento { get; set; }
        [Required]
        public double Telefono { get; set; }

        public SexoEnum Sexo { get; set; }

        public string Email { get; set; }
        [Required]
        public string Localidad { get; set; }
        [Required]
        public ObraSocialEnum ObraSocial { get; set; }
        public int DoctorId { get; set; }
        public Doctor Doctor { get; set; }
        public byte[] Imagen { get; set; }
        

    }
}
