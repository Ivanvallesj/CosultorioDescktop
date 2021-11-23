using ConsultorioDesktop.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;

namespace ConsultorioDesktop.Forms
{
    public partial class FrmNuevoEditarPaciente : Form
    {
        public int? IdEditar { get; set; }
        Paciente paciente = new Paciente();

        //Nuevo paciente desde el formulario FrmTutores

        public FrmNuevoEditarPaciente(Doctor doctor)
        {
            InitializeComponent();
            CargarCboDoctor();
            LlenarComboSexo();
            LlenarComboObrasocial();
            CboDoctor.Enabled = false;
            CboDoctor.SelectedValue = doctor.Id;

        }
        // editar paciente existente desde el formulario FrmTutores

        public FrmNuevoEditarPaciente(Doctor doctor, int idPacienteSeleccionado)
        {
            InitializeComponent();
            CargarCboDoctor();
            LlenarComboSexo();
            LlenarComboObrasocial();
            CboDoctor.Enabled = false;
            CboDoctor.SelectedValue = doctor.Id;
            if (idPacienteSeleccionado != 0)
            {
                IdEditar = idPacienteSeleccionado;
                //llamamos al metodo de carga datos
                CargarDatosDelPaciente();
            }
        }

        private void CargarCboDoctor()
        {
            using (var db = new ConsultorioContext())
            {
                var listaDcotores = from doctor in db.Doctores
                                    select new { id = doctor.Id, nombre = doctor.Apellido + " " + doctor.Nombre };
                //cargamos el combo de tutores con los existentes en la base de datos
                CboDoctor.DataSource = listaDcotores.ToList();
                CboDoctor.DisplayMember = "nombre";
                CboDoctor.ValueMember = "id";
            }
        }

        //Nuevo paciente ejecutado desde el FrmPacientes
        public FrmNuevoEditarPaciente()
        {
            InitializeComponent();
            CargarCboDoctor();
            LlenarComboSexo();
            LlenarComboObrasocial();
        }

        //Editando un paciente desde FrmPacientes
        public FrmNuevoEditarPaciente(int idSeleccionado)
        {
            InitializeComponent();
            CargarCboDoctor();
            LlenarComboSexo();
            LlenarComboObrasocial();
            if (idSeleccionado != 0)
            {
                IdEditar = idSeleccionado;
                //llamamos al metodo de carga datos
                CargarDatosDelPaciente();
            }
        }

        private void CargarDatosDelPaciente()
        {
            using (var db = new ConsultorioContext())
            {
                paciente = db.Pacientes.Find(IdEditar);
                TxtApellido.Text = paciente.Apellido;
                TxtNombre.Text = paciente.Nombre;
                TxtDireccion.Text = paciente.Direccion;
                CboSexo.SelectedItem = paciente.Sexo;
                CboDoctor.SelectedValue = paciente.DoctorId;
                CboObraSocial.SelectedItem = paciente.ObraSocial;
                NUpDownDni.Value = (decimal)paciente.Dni;
                DtpFechaNacimiento.Value = paciente.FechaNacimiento;
                TxtEmail.Text = paciente.Email;
                TxtLocalidad.Text = paciente.Localidad;
                numUpDtelefono.Value = (decimal)paciente.Telefono;
            }
        }

        private void LlenarComboObrasocial()
        {
            CboObraSocial.DataSource = Enum.GetValues(typeof(ObraSocialEnum));

        }
        private void LlenarComboSexo()
        {
            CboSexo.DataSource = Enum.GetValues(typeof(SexoEnum));
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            using (var db = new ConsultorioContext())
            {

                //le asignamos a sus propiedades el valor de cada uno de los cuadros de texto
                paciente.Nombre = TxtNombre.Text;
                paciente.Apellido = TxtApellido.Text;
                paciente.Direccion = TxtDireccion.Text;
                paciente.Localidad = TxtLocalidad.Text;
                paciente.Sexo = (SexoEnum)CboSexo.SelectedValue;
                paciente.ObraSocial = (ObraSocialEnum)CboObraSocial.SelectedValue;
                paciente.Email = TxtEmail.Text;
                paciente.DoctorId = (int)CboDoctor.SelectedValue;
                paciente.Dni = (int)NUpDownDni.Value;
                paciente.Telefono = (double)numUpDtelefono.Value;
                paciente.FechaNacimiento = DtpFechaNacimiento.Value.Date;


                //si el id del Paciente a editar es nulo agregamos un Calendario a la tabla
                if (IdEditar == null)
                    //lo agregamos al objeto Paciente al objeto DbCOntext
                    db.Pacientes.Add(paciente);
                else //configuramos el almacenamiento de la modificacion si el id de Paciente es distinto de nulo
                {
                    db.Entry(paciente).State = EntityState.Modified;
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
