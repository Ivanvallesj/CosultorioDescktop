using ConsultorioDesktop.AdminData;
using ConsultorioDesktop.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;


namespace ConsultorioDesktop.Forms
{
    public partial class FrmNuevoEditarDoctor : Form
    {
        DbAdminDoctores dbAdminDoctores = new DbAdminDoctores();
        public int? IdDoctorEditar { get; set; }
        public Doctor doctor { get; set; }
        public FrmNuevoEditarDoctor(int? idDocotorSeleccionado = null)
        {

            InitializeComponent();
            LlenarComboSexo();
            LlenarComboEspecializacion();
            //si recibimos el idDoctorSeleccionado significa que vamos a editar
            if (idDocotorSeleccionado != null)
            {
                IdDoctorEditar = idDocotorSeleccionado;
                //llamamos al metodo de carga datos
                CargarDatosDelDoctorEnPantalla();
            }
            else
            {
                doctor = new Doctor();
            }

        }

        private void CargarDatosDelDoctorEnPantalla()
        {
            doctor = (Doctor)dbAdminDoctores.Obtener(IdDoctorEditar);
            TxtNombre.Text = doctor.Nombre;
            TxtApellido.Text = doctor.Apellido;
            NUpDownDni.Value = doctor.Dni;
            TxtLocalidad.Text = doctor.Localidad;
            CboSexo.SelectedItem = doctor.Sexo;
            DtpFechaNacimiento.Value = doctor.FechaNacimiento;
            CboEspecializacion.SelectedItem = doctor.Especializacion;
            TxtEmail.Text = doctor.Email;
            numUpDtelefono.Value = (decimal)doctor.Telefono;
        }
        private void LlenarComboSexo()
        {
            CboSexo.DataSource = Enum.GetValues(typeof(SexoEnum));
        }
        private void LlenarComboEspecializacion()
        {
            CboEspecializacion.DataSource = Enum.GetValues(typeof(EspecializacionEnum));
        }
        private void BtnGuardar_Click(object sender, EventArgs e)
        {

            //le asignamos a sus propiedades el valor de cada uno de los cuadros de texto
            doctor.Apellido = TxtApellido.Text;
            doctor.Nombre = TxtNombre.Text;
            doctor.Dni = (int)NUpDownDni.Value;
            doctor.Localidad = TxtLocalidad.Text;
            doctor.Sexo = (SexoEnum)CboSexo.SelectedValue;
            doctor.FechaNacimiento = DtpFechaNacimiento.Value.Date;
            doctor.Especializacion = (EspecializacionEnum)CboEspecializacion.SelectedValue;
            doctor.Email = TxtEmail.Text;
            doctor.Telefono = (double)numUpDtelefono.Value;


            //si el id del doctor a editar es nulo agregamos un doctor a la tabla
            if (IdDoctorEditar == null)
                //lo agregamos al objeto Tutor al objeto DbCOntext
                dbAdminDoctores.Agregar(doctor);
            else //configuramos el almacenamiento de la modificacion si el id de tutor es distinto de nulo
            {
                dbAdminDoctores.Actualizar(doctor);
            }

            //cerramos el formulario
            this.Close();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            //CAMINO POR SI ES UN NUEVO TUTOR

            if (doctor.Id == 0)

            {
                //length nos cuenta la cantidad de caracteres que hay en el string
                if (TxtApellido.Text.Length == 0 && TxtNombre.Text.Length == 0 && TxtEmail.Text.Length == 0)
                    this.Close();

                else
                {
                    PreguntarSiSaleSinGuardar();
                }
            }
            else  //CAMINO SI ES MODIFICANDO A UN TUTOR EXISTENTE
            {
                if (CompararDatosFormularioConLosDeBBDD())
                    this.Close();
                else
                {
                    PreguntarSiSaleSinGuardar();
                }
            }
        }

        private void PreguntarSiSaleSinGuardar()
        {
            DialogResult respuesta = MessageBox.Show($"¿Estas seguro que desea salir del formulario sin guardar los datos? ", "Datos sin Guardar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
                this.Close();
        }
        private bool CompararDatosFormularioConLosDeBBDD()
        {
            return (doctor.Apellido == TxtApellido.Text && doctor.Nombre == TxtNombre.Text && doctor.Email == TxtEmail.Text);
        }

        
    }
}
