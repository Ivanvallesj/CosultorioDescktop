using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CosultorioDescktop.Models
{
    public class TurnoDetalles
    {
        public int Id { get; set; }
        [Required]
        public DateTime FechaTurno { get; set; }
        [Required]
        public DateTime Hora { get; set; }
        [Required]
        public TipoTurnoEnum TipoTurno { get; set; }
        [Required]
        public int Precio { get; set; }
        public int Bonos { get; set; }
        [Required]
        public int DoctorId { get; set; }
        public Doctor Doctor { get; set; }
        [Required]
        public int PacienteId { get; set; }
        public Paciente Paciente { get; set; }
    }
}
