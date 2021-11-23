using ConsultorioDesktop.Forms;
using ConsultorioDesktop.Interfaces;
using ConsultorioDesktop.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsultorioDesktop.AdminData
{
    public class DbAdminPacientes : IDbAdmin
    {
        public IEnumerable<object> ObtenerTodos()
        {
            using ConsultorioContext db = new ConsultorioContext();
            return db.Pacientes.Include(u => u.Usuario).IgnoreQueryFilters().Where(c => c.Eliminado == false).ToList();
        }

        public void Eliminar(int idSeleccionado)
        {
            using ConsultorioContext db = new ConsultorioContext();
            var pacientes = db.Pacientes.Find(idSeleccionado);
            //db.Tutores.Remove(Tutor);
            //REALIZAMOS TODA LA MECANICA PARA QUE MODIFIQUE EN LA BASE DE DATOS AL CALENDARIO
            pacientes.Eliminado = true;
            pacientes.FechaHoraEliminacion = DateTime.Now;
            pacientes.Usuario = FrmMenuPrincipal.Usuario;
            db.Entry(pacientes).State = EntityState.Modified;
            db.SaveChanges();
        }

        public object Obtener(int? idObtener)
        {
            //instanciamos un objeto DbContext
            using ConsultorioContext db = new ConsultorioContext();
            return db.Pacientes.Find(idObtener);
        }

        public void Agregar(object paciente)
        {
            using ConsultorioContext db = new ConsultorioContext();
            db.Pacientes.Add((Paciente)paciente);
            db.SaveChanges();
        }

        public void Actualizar(object paciente)
        {
            using ConsultorioContext db = new ConsultorioContext();
            db.Entry(paciente).State = EntityState.Modified;
            db.SaveChanges();
        }

        public IEnumerable<object> ObtenerTodos(string cadenaBuscada)
        {
            //instanciamos nuestro objeto db Context
            using ConsultorioContext db = new ConsultorioContext();
            return db.Pacientes.Where(c => c.Nombre.Contains(cadenaBuscada)).Include(u => u.Usuario).IgnoreQueryFilters().Where(c => c.Eliminado == false).ToList();
        }

        IEnumerable<object> IDbAdmin.ObtenerEliminados()
        {
            using ConsultorioContext db = new ConsultorioContext();
            return db.Pacientes.Include(u => u.Usuario).IgnoreQueryFilters().Where(c => c.Eliminado == true).ToList();
        }
        public void Restaurar(int idSeleccionado)
        {
            using ConsultorioContext db = new ConsultorioContext();
            var pacientes = db.Pacientes.IgnoreQueryFilters().FirstOrDefault(c => c.Id == idSeleccionado);
            //db.Calendarios.Remove(Calendario);
            //REALIZAMOS TODA LA MECANICA PARA QUE MODIFIQUE EN LA BASE DE DATOS AL CALENDARIO
            pacientes.Eliminado = false;
            db.Entry(pacientes).State = EntityState.Modified;
            db.SaveChanges();
        }
    }
}
