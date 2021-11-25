using ConsultorioDesktop.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using ConsultorioDesktop.ExtensionMethods;
using ConsultorioDesktop.AdminData;
using ConsultorioDesktop.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace ConsultorioDesktop.Forms
{
    public partial class FrmPacientes : Form, IFormBase
    {
        IDbAdmin dbAdmin;
        Paciente paciente { get; set; }
        public int? IdEditar { get; set; }

        public FrmPacientes(IDbAdmin objetoDbAdmin)
        {
            dbAdmin = objetoDbAdmin;
            InitializeComponent();
            ActualizarGrilla();

        }
        private void ActualizarGrilla()
        {
            if (chkVerEliminados.Checked)
            {
                Grid.DataSource = dbAdmin.ObtenerEliminados();
                Grid.OcultarColumnas(ocultarMostrar: false);
            }
            else
            {
                using (var db = new ConsultorioContext())
                {
                    //creamos una coleccion para seleccionar los datos que queremos mostrar en la grilla 
                    var pacientesAListar = from paciente in db.Pacientes
                                           select new
                                           {
                                               Id = paciente.Id,
                                               Nombre = paciente.Nombre + " " + paciente.Apellido,
                                               FechaNacimiento = paciente.FechaNacimiento,
                                               Sexo = paciente.Sexo,
                                               DoctorCabecera = paciente.Doctor.Apellido + " " + paciente.Doctor.Nombre,
                                               Eliminado = paciente.Eliminado
                                           };
                    Grid.DataSource = pacientesAListar.IgnoreQueryFilters().Where(c=> c.Eliminado == false).ToList();
                    Grid.OcultarColumnas();
                }
            }
        }
        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            var frmNuevoEditarPaciente = new FrmNuevoEditarPaciente();
            frmNuevoEditarPaciente.ShowDialog();
            ActualizarGrilla();
            Grid.CurrentCell = Grid.Rows[Grid.RowCount - 1].Cells[0];
        }
        private void BtnEditar_Click(object sender, EventArgs e)
        {
            //creamos la variable para saber que id de Paciente tenemos seleccionado
            var idSeleccionado = Grid.ObtenerIdSeleccionado();
            var filaAEditar = Grid.CurrentRow.Index;

            //abrimos el formulario para la edicion de un  Paciente
            var FrmNuevoEditarPaciente = new FrmNuevoEditarPaciente(idSeleccionado);
            FrmNuevoEditarPaciente.ShowDialog();

            //actualizamos la grilla
            ActualizarGrilla();

            //seleccionamos el registro editado
            Grid.CurrentCell = Grid.Rows[filaAEditar].Cells[0];
        }

        private void Grid_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            //tomamos el id paciente
                    //var idPaciente = int.Parse(Grid.CurrentRow.Cells[0].Value.ToString());
                    //using var db = new ConsultorioContext();
                    //this.pacienteSeleccionado = db.Pacientes.Find(idPaciente);
            //CargarCboVacunas(this.pacienteSeleccionado.CalendarioId);
            //CargarCboVacunasColocadas(idPaciente);
            ActualizarGrillaTurnos();
        }

        private void ActualizarGrillaTurnos()
        {
            if (Grid.CurrentRow != null)
            {
                var idPacienteSeleccionado = Grid.ObtenerIdSeleccionado();
                if (idPacienteSeleccionado > 0)
                {
                    using var db = new ConsultorioContext();
                    var TurnosAListar = from turno in db.TurnoDetalles
                                        join paciente in db.Pacientes
                                        on turno.PacienteId equals paciente.Id
                                        where paciente.Id == idPacienteSeleccionado
                                        select new
                                        {
                                            Id = turno.Id,
                                            Fecha = turno.FechaTurno,
                                            Hora = turno.Hora.ToString("t"),
                                            Tipo = turno.TipoTurno,
                                            Doctor = turno.Doctor.Apellido + " " + turno.Doctor.Nombre,
                                            Eliminado = turno.Eliminado
                                        };
                        GridTurnos.DataSource = TurnosAListar.IgnoreQueryFilters().Where(c => c.Eliminado == false).ToList();
                    GridTurnos.OcultarColumnas();
                }
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            //obtenemos el id y el nombre del tutor seleccionado en la grilla
            var idPacienteSeleccionado = Grid.ObtenerIdSeleccionado();

            //guardamos en la variable el nombre y el apellido del tutor seleccionado
            var nombrePacienteSeleccionado = Grid.CurrentRow.Cells[1].Value.ToString() + " " + Grid.CurrentRow.Cells[2].Value.ToString();

            // preguntar si realmente desea eliminar al tutor [nombre_doctor_seleccionado]
            //colocamos el signo $ para crear la interpolacion de cadenas
            DialogResult respuesta = MessageBox.Show($"¿Estas seguro que desea {BtnEliminar.Text} a {nombrePacienteSeleccionado}?", BtnEliminar.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            //si responde que si, instanciamos al objeto dbContext y eliminamos el tutor a traves del id que obtuvimos.
            if (respuesta == DialogResult.Yes)
            {
                dbAdmin.Eliminar(idPacienteSeleccionado);
                ActualizarGrilla();
            }
            if (respuesta == DialogResult.Yes && BtnEliminar.Text == "Restaurar")
            {
                dbAdmin.Restaurar(idPacienteSeleccionado);
                ActualizarGrilla();
            }
        }

        public void CargarDatosEnPantalla()
        {
            throw new NotImplementedException();
        }

        public void LimpiarDatosDeLaPantalla()
        {
            throw new NotImplementedException();
        }

        private void chkVerEliminados_CheckedChanged(object sender, EventArgs e)
        {
            if (chkVerEliminados.Checked)
                BtnEliminar.Text = "Restaurar";
            else
                BtnEliminar.Text = "Eliminar";
            ActualizarGrilla();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            var idSeleccionado = Grid.ObtenerIdSeleccionado();
            var frmNuevoEditarTruno = new FrmNuevoEditarTurno(idSeleccionado);
            frmNuevoEditarTruno.ShowDialog();
            ActualizarGrillaTurnos();
            GridTurnos.CurrentCell = GridTurnos.Rows[GridTurnos.RowCount -1].Cells[0];
        }

        private void TxtBusqueda_TextChanged(object sender, EventArgs e)
        {
            ActualizarGrilla(TxtBusqueda.Text);
        }

        private void ActualizarGrilla(string textoAbuscar)
        {
            using (var db = new ConsultorioContext())
            {
                //creamos una coleccion para seleccionar los datos que queremos mostrar en la grilla 
                var pacientesAListar = from paciente in db.Pacientes
                                       select new
                                       {
                                           Id = paciente.Id,
                                           Nombre = paciente.Nombre + " " + paciente.Apellido,
                                           FechaNacimiento = paciente.FechaNacimiento,
                                           Sexo = paciente.Sexo,
                                           DoctorCabecera = paciente.Doctor.Apellido + " " + paciente.Doctor.Nombre,
                                           Eliminado = paciente.Eliminado
                                       };
                Grid.DataSource = pacientesAListar.IgnoreQueryFilters().Where(c => c.Eliminado == false).Where(t => t.Nombre.Contains(textoAbuscar)).ToList();
                Grid.OcultarColumnas();
            }
        }
    }
}
