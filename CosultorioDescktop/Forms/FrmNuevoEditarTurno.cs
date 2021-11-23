using CosultorioDescktop.AdminData;
using CosultorioDescktop.Interfaces;
using CosultorioDescktop.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace CosultorioDescktop.Forms
{
    public partial class FrmNuevoEditarTurno : Form, IFormBase
{
        DbAdminTurnos dbAdmin = new DbAdminTurnos();
        public int? IdEditar { get; set; }
        public TurnoDetalles turnoDetalle = new TurnoDetalles();

        public FrmNuevoEditarTurno()
        {
            InitializeComponent();
            CargarComboTipoTurno();
            CargarComboDoctor();
            CargarComboPaciente();
        }

        private void CargarComboPaciente()
        {
            using (var db = new ConsultorioContext())
            {
                //columna que queiro que se muestre en pantalla 
                CboPaciente.DisplayMember = "nombre";
                //columna que quiere seleccionar para que obtenga el valor
                CboPaciente.ValueMember = "id";
                var listaPacientes = from paciente in db.Pacientes
                                   select new { id = paciente.Id, nombre = paciente.Nombre };
                //cargamos el combo de tutores con los existentes en la base de datos
                CboPaciente.DataSource = listaPacientes.ToList();
                CboPaciente.SelectedValue = 0;
            }
        }

        private void CargarComboDoctor()
        {
            using (var db = new ConsultorioContext())
            {
                //columna que queiro que se muestre en pantalla 
                CboDoctor.DisplayMember = "nombre";
                //columna que quiere seleccionar para que obtenga el valor
                CboDoctor.ValueMember = "id";
                var listaDoctores = from doctor in db.Doctores
                                     select new { id = doctor.Id, nombre = doctor.Nombre };
                //cargamos el combo de tutores con los existentes en la base de datos
                CboDoctor.DataSource = listaDoctores.ToList();
                CboDoctor.SelectedValue = 0;
                 
            }
        }

        private void CargarComboTipoTurno()
        {
            CboTipoTurno.DataSource = Enum.GetValues(typeof(TipoTurnoEnum));
        }

        public FrmNuevoEditarTurno(int? idTurnoSeleccionado)
        {
            InitializeComponent();
            CargarDatosEnPantalla();
            LimpiarDatosDeLaPantalla();
            CargarComboTipoTurno();
            CargarComboDoctor();
            CargarComboPaciente();
        }

        public void CargarDatosEnPantalla()
        {
            //a traves del IdCalendarioEditar buscamos los datos del Calendario en el repositorio 
            turnoDetalle = (TurnoDetalles)dbAdmin.Obtener(IdEditar);
            DtpFechaTurno.Value = turnoDetalle.FechaTurno;
            DtpHora.Value = turnoDetalle.Hora;
            CboTipoTurno.SelectedItem = (int)turnoDetalle.TipoTurno;
            NumUpDownPrecio.Value = turnoDetalle.Precio;
            NumUpDownBonos.Value = turnoDetalle.Bonos;
            CboDoctor.SelectedValue = turnoDetalle.DoctorId;
            CboPaciente.SelectedValue = turnoDetalle.PacienteId;
        }

        public void LimpiarDatosDeLaPantalla()
        {
            turnoDetalle = new TurnoDetalles();
            DtpFechaTurno.Value = DateTime.Now ;
            DtpHora.Value = DateTime.Now;
            CboTipoTurno.SelectedIndex = 0;
            NumUpDownPrecio.Value = 0;
            NumUpDownBonos.Value = 0;
            CboDoctor.SelectedItem = 0;
            CboPaciente.SelectedItem = 0;
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            using (var db = new ConsultorioContext())
            {

                //le asignamos a sus propiedades el valor de cada uno de los cuadros de texto
                turnoDetalle.FechaTurno = DtpFechaTurno.Value.Date;
                turnoDetalle.Hora = DtpHora.Value.Date;
                turnoDetalle.TipoTurno = (TipoTurnoEnum)CboTipoTurno.SelectedValue;
                turnoDetalle.Precio = (int)NumUpDownPrecio.Value;
                turnoDetalle.Bonos = (int)NumUpDownBonos.Value;
                turnoDetalle.DoctorId = (int)CboDoctor.SelectedValue;
                turnoDetalle.PacienteId = (int)CboDoctor.SelectedValue;

                //si el id del Paciente a editar es nulo agregamos un Calendario a la tabla
                if (IdEditar == null)
                    //lo agregamos al objeto Paciente al objeto DbCOntext
                    db.TurnoDetalles.Add(turnoDetalle);
                else //configuramos el almacenamiento de la modificacion si el id de Paciente es distinto de nulo
                {
                    db.Entry(turnoDetalle).State = EntityState.Modified;
                }

                //guardamos los cambios
                db.SaveChanges();
            }
            //cerramos el formulario
            this.Close();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
