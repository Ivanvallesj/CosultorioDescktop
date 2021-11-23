using CosultorioDescktop.Forms;
using CosultorioDescktop.Interfaces;
using CosultorioDescktop.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CosultorioDescktop.AdminData
{
    class DbAdminTurnos : IDbAdmin
    {
        public void Actualizar(object turnoDetalles)
        {
            using ConsultorioContext db = new ConsultorioContext();
            db.Entry(turnoDetalles).State = EntityState.Modified;
            db.SaveChanges();
        }

        public void Agregar(object turnoDetalles)
        {
            using ConsultorioContext db = new ConsultorioContext();
            db.TurnoDetalles.Add((TurnoDetalles)turnoDetalles);
            db.SaveChanges();
        }

        public void Eliminar(int idSeleccionado)
        {
            using ConsultorioContext db = new ConsultorioContext();
            var turno = db.TurnoDetalles.Find(idSeleccionado);
            //db.Tutores.Remove(Tutor);
            //REALIZAMOS TODA LA MECANICA PARA QUE MODIFIQUE EN LA BASE DE DATOS AL CALENDARIO
            turno.Eliminado = true;
            turno.FechaHoraEliminacion = DateTime.Now;
            turno.Usuario = FrmMenuPrincipal.Usuario;
            db.Entry(turno).State = EntityState.Modified;
            db.SaveChanges();
        }

        public object Obtener(int? idObtener)
        {
            //instanciamos un objeto DbContext
            using ConsultorioContext db = new ConsultorioContext();
            return db.TurnoDetalles.Find(idObtener);
        }

        public IEnumerable<object> ObtenerEliminados()
        {
            using ConsultorioContext db = new ConsultorioContext();
            return db.TurnoDetalles.Include(u => u.Usuario).IgnoreQueryFilters().Where(c => c.Eliminado == true).ToList();
        }

        public IEnumerable<object> ObtenerTodos()
        {
            using ConsultorioContext db = new ConsultorioContext();
            return db.TurnoDetalles.Include(u => u.Usuario).IgnoreQueryFilters().Where(c => c.Eliminado == false).ToList();
        }

        public IEnumerable<object> ObtenerTodos(string cadenaBuscada)
        {
            using ConsultorioContext db = new ConsultorioContext();
            return db.TurnoDetalles.Where(c => c.PacienteId.ToString().Contains(cadenaBuscada)).ToList();
        }

        public void Restaurar(int idSeleccionado)
        {
            using ConsultorioContext db = new ConsultorioContext();
            var turnos = db.TurnoDetalles.IgnoreQueryFilters().FirstOrDefault(c => c.Id == idSeleccionado);
            //db.Calendarios.Remove(Calendario);
            //REALIZAMOS TODA LA MECANICA PARA QUE MODIFIQUE EN LA BASE DE DATOS AL CALENDARIO
            turnos.Eliminado = false;
            db.Entry(turnos).State = EntityState.Modified;
            db.SaveChanges();
        }
    }
}
