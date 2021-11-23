using ConsultorioDesktop.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using ConsultorioDesktop.AdminData;
using ConsultorioDesktop.ExtensionMethods;
using Microsoft.EntityFrameworkCore;
using ConsultorioDesktop.Interfaces;

namespace ConsultorioDesktop.Forms
{
    public partial class FrmDoctores : Form, IFormBase
    {
        IDbAdmin dbAdmin;
        Doctor doctor = new Doctor();
        public int? IdEditar { get ; set ; }

        public FrmDoctores(IDbAdmin objetoDbAdmin)
        {
            dbAdmin = objetoDbAdmin;
            InitializeComponent();
            ActualizarGrilla();
        }

        private void ActualizarGrillaPacientes()
        {
            if (GridDoctores.CurrentRow != null)
            {
                var idDoctorSeleccionado = GridDoctores.ObtenerIdSeleccionado();
                if (idDoctorSeleccionado > 0)
                {
                    using var db = new ConsultorioContext();
                    doctor = (Doctor)db.Doctores.Where(t => t.Id == idDoctorSeleccionado).Include(p => p.Pacientes).FirstOrDefault();
                    var pacientesAListar = from paciente in doctor.Pacientes
                                           select new
                                           {
                                               id = paciente.Id,
                                               nombre = paciente.Nombre + " " + paciente.Apellido,
                                               FechaNacimiento = paciente.FechaNacimiento,
                                               Sexo = paciente.Sexo
                                           };

                    GridPacientes.DataSource = pacientesAListar.ToList();
                }
            }
        }

        private void ActualizarGrilla()
        {
            if (chkVerEliminados.Checked)
            {
                GridDoctores.DataSource = dbAdmin.ObtenerEliminados();
                GridDoctores.OcultarColumnas(ocultarMostrar: false);
            }
            else
            {
                GridDoctores.DataSource = dbAdmin.ObtenerTodos();
                GridDoctores.OcultarColumnas();
            }
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            var frmNuevoEditarDoctor = new FrmNuevoEditarDoctor();
            frmNuevoEditarDoctor.ShowDialog();
            ActualizarGrilla();
            GridDoctores.CurrentCell = GridDoctores.Rows[GridDoctores.RowCount - 1].Cells[0];
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            //creamos la variable para saber que id de tutor tenemos seleccionado
            var idDoctorSeleccionado = GridDoctores.ObtenerIdSeleccionado();
            var filaAEditar = GridDoctores.CurrentRow.Index;

            //abrimos el formulario para la edicion de un  tutor
            var FrmNuevoEditarDoctor = new FrmNuevoEditarDoctor(idDoctorSeleccionado);
            FrmNuevoEditarDoctor.ShowDialog();

            //actualizamos la grilla
            ActualizarGrilla();

            //seleccionamos el registro editado
            GridDoctores.CurrentCell = GridDoctores.Rows[filaAEditar].Cells[0];
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            //obtenemos el id y el nombre del tutor seleccionado en la grilla
            var idDoctorSeleccionado = GridDoctores.ObtenerIdSeleccionado();

            //guardamos en la variable el nombre y el apellido del tutor seleccionado
            var nombreDoctorSeleccionado = GridDoctores.CurrentRow.Cells[1].Value.ToString() + " " + GridDoctores.CurrentRow.Cells[2].Value.ToString();

            // preguntar si realmente desea eliminar al tutor [nombre_doctor_seleccionado]
            //colocamos el signo $ para crear la interpolacion de cadenas
            DialogResult respuesta = MessageBox.Show($"¿Estas seguro que desea {BtnEliminar.Text} a {nombreDoctorSeleccionado}?", BtnEliminar.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            //si responde que si, instanciamos al objeto dbContext y eliminamos el tutor a traves del id que obtuvimos.
            if (respuesta == DialogResult.Yes && BtnEliminar.Text == "Eliminar")
            {
                dbAdmin.Eliminar(idDoctorSeleccionado);
                ActualizarGrilla();
            }
            if (respuesta == DialogResult.Yes && BtnEliminar.Text == "Restaurar")
            {
                dbAdmin.Restaurar(idDoctorSeleccionado);
                ActualizarGrilla();
            }

        }

        private void BtnAgregarPaciente_Click(object sender, EventArgs e)
        {
            var frmNuevoEditarPaciente = new FrmNuevoEditarPaciente(doctor);
            frmNuevoEditarPaciente.ShowDialog();
            ActualizarGrillaPacientes();
            GridPacientes.CurrentCell = GridPacientes.Rows[GridPacientes.RowCount - 1].Cells[0];
        }

        private void BtnEditarPaciente_Click(object sender, EventArgs e)
        {
            //creamos la variable para saber que id de paciente tenemos seleccionado
            var idPacienteSeleccionado = GridPacientes.ObtenerIdSeleccionado();
            var filaAEditar = GridPacientes.CurrentRow.Index;

            //abrimos el formulario para la edicion de un  tutor
            var FrmNuevoEditarPaciente = new FrmNuevoEditarPaciente(doctor, idPacienteSeleccionado);
            FrmNuevoEditarPaciente.ShowDialog();

            //actualizamos la grilla
            ActualizarGrilla();

            //seleccionamos el registro editado
            GridPacientes.CurrentCell = GridPacientes.Rows[filaAEditar].Cells[0];
        }

        private void GridDoctores_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            ActualizarGrillaPacientes();
        }

        void IFormBase.CargarDatosEnPantalla()
        {
            throw new NotImplementedException();
        }

        void IFormBase.LimpiarDatosDeLaPantalla()
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

        private void BtnEliminarPaciente_Click(object sender, EventArgs e)
        {
            //obtenemos el id y nombre de la vacuna seleccionada en la grilla detalle
            var idSeleccionado = GridPacientes.ObtenerIdSeleccionado();
            var nombreSeleccionado = GridPacientes.CurrentRow.Cells[1].Value.ToString();
            var nombreDoctor = GridDoctores.CurrentRow.Cells[1].Value.ToString();
            var idDoctor = GridDoctores.ObtenerIdSeleccionado();
            //preguntar si realmente desea eliminar a la vacuna seleccionada
            DialogResult respuesta = MessageBox.Show($"¿Está seguro que desea quitar el paciente {nombreSeleccionado} de su doctor {nombreDoctor}?", "Quitar vacuna ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //si responde que si, instanciamos al objeto dbcontext, y eliminamos el Calendario a través del id que obtuvimos
            if (respuesta == DialogResult.Yes)
            {
                using (var db = new ConsultorioContext())
                {
                    var detalle = db.Pacientes.Find(idSeleccionado);
                    db.Pacientes.Remove(detalle);
                    db.SaveChanges();
                }
                ActualizarGrillaPacientes();
            }

        }

        private void TxtBusqueda_TextChanged(object sender, EventArgs e)
        {
            GridDoctores.DataSource = dbAdmin.ObtenerTodos(TxtBusqueda.Text);
        }
    }
}
