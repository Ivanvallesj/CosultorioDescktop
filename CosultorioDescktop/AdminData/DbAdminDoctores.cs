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
    class DbAdminDoctores : IDbAdmin
    {
        public IEnumerable<object> ObtenerTodos()
        {
            using ConsultorioContext db = new ConsultorioContext();
            return db.Doctores.Include(u=> u.Usuario).IgnoreQueryFilters().Where(c => c.Eliminado == false).ToList();
        }

        public void Eliminar(int idSeleccionado)
        {
            using ConsultorioContext db = new ConsultorioContext();
            var doctores = db.Doctores.Find(idSeleccionado);
                //db.Tutores.Remove(Tutor);
                //REALIZAMOS TODA LA MECANICA PARA QUE MODIFIQUE EN LA BASE DE DATOS AL CALENDARIO
                doctores.Eliminado = true;
                doctores.FechaHoraEliminacion = DateTime.Now;
                doctores.Usuario = FrmMenuPrincipal.Usuario;
            db.Entry(doctores).State = EntityState.Modified;
            db.SaveChanges();

        }

        public object Obtener(int? idObtener)
        {
            //instanciamos un objeto DbContext
            using ConsultorioContext db = new ConsultorioContext();
            return db.Doctores.Find(idObtener);
        }

        public void Agregar(object doctor)
        {
            using ConsultorioContext db = new ConsultorioContext();
            db.Doctores.Add((Doctor)doctor);
            db.SaveChanges();
        }

        public void Actualizar(object doctor)
        {
            using ConsultorioContext db = new ConsultorioContext();
            db.Entry(doctor).State = EntityState.Modified;
            db.SaveChanges();
        }

        public IEnumerable<object> ObtenerTodos(string cadenaBuscada)
        {
            //instanciamos nuestro objeto db Context
            using ConsultorioContext db = new ConsultorioContext();
            return db.Doctores.Where(c => c.Nombre.Contains(cadenaBuscada)).Include(u => u.Usuario).IgnoreQueryFilters().Where(c => c.Eliminado == false).ToList();
        }

            public IEnumerable<object> ObtenerEliminados()
            {
                using ConsultorioContext db = new ConsultorioContext();
                return db.Doctores.Include(u => u.Usuario).IgnoreQueryFilters().Where(c => c.Eliminado == true).ToList();
            }
            public void Restaurar(int idSeleccionado)
            {
                using ConsultorioContext db = new ConsultorioContext();
                var doctores = db.Doctores.IgnoreQueryFilters().FirstOrDefault(c => c.Id == idSeleccionado);
                //db.Calendarios.Remove(Calendario);
                //REALIZAMOS TODA LA MECANICA PARA QUE MODIFIQUE EN LA BASE DE DATOS AL CALENDARIO
                doctores.Eliminado = false;
                db.Entry(doctores).State = EntityState.Modified;
                db.SaveChanges();
            }
    }
}
