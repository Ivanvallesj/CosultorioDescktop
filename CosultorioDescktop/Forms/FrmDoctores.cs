using CosultorioDescktop.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using CosultorioDescktop.AdminData;
using CosultorioDescktop.ExtensionMethods;

namespace CosultorioDescktop.Forms
{
    public partial class FrmDoctores : Form
    {
        DbAdminDoctores dbAdminDoctores = new DbAdminDoctores();
        Doctor doctor { get; set; }
        public FrmDoctores()
        {
            InitializeComponent();
            ActualizarGrilla();
        }
        private void ActualizarGrilla()
        {

            using (var db = new ConsultorioContext())
            {
                //creamos una coleccion para seleccionar los datos que queremos mostrar en la grilla 
                var dotoresAListar = from doctores in db.Doctores
                                       select new
                                       {
                                           id = doctores.Id,
                                           nombre = doctores.Nombre + " " + doctores.Apellido,
                                           FechaNacimiento = doctores.FechaNacimiento,
                                           Sexo = doctores.Sexo
                                       };
                GridDoctores.DataSource = dotoresAListar.ToList();

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
            DialogResult respuesta = MessageBox.Show($"¿Estas seguro que desea eliminar a {nombreDoctorSeleccionado}?", "Eliminar Docotr", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            //si responde que si, instanciamos al objeto dbContext y eliminamos el tutor a traves del id que obtuvimos.
            if (respuesta == DialogResult.Yes)
            {
                dbAdminDoctores.Eliminar(idDoctorSeleccionado);
                ActualizarGrilla();
            }
        }

        private void BtnAgregarPaciente_Click(object sender, EventArgs e)
        {
            var frmNuevoEditarPaciente = new FrmNuevoEditarPaciente();
            frmNuevoEditarPaciente.ShowDialog();
        }

        private void BtnEditarPaciente_Click(object sender, EventArgs e)
        {
            //creamos la variable para saber que id de paciente tenemos seleccionado
            var idPacienteSeleccionado = GridPacientes.ObtenerIdSeleccionado();
            var filaAEditar = GridPacientes.CurrentRow.Index;

            //abrimos el formulario para la edicion de un  tutor
            var FrmNuevoEditarPaciente = new FrmNuevoEditarPaciente(idPacienteSeleccionado);
            FrmNuevoEditarPaciente.ShowDialog();

            //actualizamos la grilla
            ActualizarGrilla();

            //seleccionamos el registro editado
            GridPacientes.CurrentCell = GridPacientes.Rows[filaAEditar].Cells[0];
        }
    }
}
