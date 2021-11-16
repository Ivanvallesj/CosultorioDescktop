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
    public class DbAdminDoctores : IDbAdmin
{
    public IEnumerable<object> ObtenerTodos()
    {
        using ConsultorioContext db = new ConsultorioContext();
        return db.Doctores.ToList();
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
        //var listaTutores = from Tutor in db.Tutores
        //                       select new { Id = Tutor.Id, Nombre = Tutor.Nombre.Trim(), Sexo = Tutor.SexoPaciente };
        ////consultamos en el txtBusqueda si el nombre apellido o email contiene la expresion escrita en la grilla.
        //return listaTutores.Where(c => c.Nombre.Contains(cadenaBuscada)).ToList();
        return db.Doctores.Where(c => c.Nombre.Contains(cadenaBuscada)).ToList();
    }

        IEnumerable<object> IDbAdmin.ObtenerEliminados()
        {
            throw new NotImplementedException();
        }
    }
}
