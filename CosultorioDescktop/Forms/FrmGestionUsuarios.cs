using ConsultorioDesktop.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using ConsultorioDesktop.Forms;
using ConsultorioDesktop.ExtensionMethods;

namespace ConsultorioDesktop.Forms
{
    public partial class FrmGestionUsuarios : Form
    {
        public FrmGestionUsuarios()
        {
            InitializeComponent();
            ActualizarGrillaUsuario();
        }

        private void ActualizarGrillaUsuario()
        {
            using (var db = new ConsultorioContext())
            {//creamos una lista personalizada para seleccionar los datos que queremos mostrar en el grilla
                var usuariosMostrados = from usuario in db.Usuarios
                                        select new
                                        {
                                            Id = usuario.Id,
                                            Nombre = usuario.Nombre,
                                            NombreUsuario = usuario.User,
                                            TipoDeUsuario = usuario.TipoUsuario
                                        };
                //cargamos la grilla con la coleccion creada
                dataGridUsuarios.DataSource = usuariosMostrados.ToList();
            }
        }
        private void BtnAñadirUsuario_Click_1(object sender, EventArgs e)
        {
            var frmNuevoEditarUsuario = new FrmNuevoEditarUsuario();
            frmNuevoEditarUsuario.ShowDialog();
            ActualizarGrillaUsuario();
            dataGridUsuarios.CurrentCell = dataGridUsuarios.Rows[dataGridUsuarios.RowCount - 1].Cells[0];
        }

        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            this.MensajeDeAdvertenciaDeSalida();
        }

        private void btnCambiarContraseña_Click_1(object sender, EventArgs e)
        {
            var idSeleccionado = int.Parse(dataGridUsuarios.CurrentRow.Cells[0].Value.ToString());
            var frmCambioContraseña = new FrmCambioContrasena(idSeleccionado);
            frmCambioContraseña.ShowDialog();
        }

        private void BtnEditarUsuario_Click_1(object sender, EventArgs e)
        {
            //creamos una variable para identificar el id del usuario que queremos editar
            var idSeleccionado = int.Parse(dataGridUsuarios.CurrentRow.Cells[0].Value.ToString());
            var filaAEditar = dataGridUsuarios.CurrentRow.Index;
            //abrimos el formulario para la edicion de una Propiedad
            var FrmNuevoEditarUsuario = new FrmNuevoEditarUsuario(idSeleccionado);
            FrmNuevoEditarUsuario.ShowDialog();
            ActualizarGrillaUsuario();
            dataGridUsuarios.CurrentCell = dataGridUsuarios.Rows[filaAEditar].Cells[0];
        }

        private void BtnEliminarUsuario_Click_1(object sender, EventArgs e)
        {
            //obtenemos el id y el nombre del Usuario seleccionado en la grilla
            //guardamos en una nueva variable el id obtenido del usuario
            var idUsuarioSeleccionado = int.Parse(dataGridUsuarios.CurrentRow.Cells[0].Value.ToString());
            //guardamos en la variable el nombre de la Propiedad
            var nombreUsuarioSeleccionado = dataGridUsuarios.CurrentRow.Cells[1].Value.ToString();
            // preguntar si realmente desea eliminar al Usuario [nombreUsuarioSeleccionado]
            //colocamos el signo $ para crear la interpolacion de cadenas
            DialogResult respuesta = MessageBox.Show($"¿Estas seguro que desea eliminar al usuario  {nombreUsuarioSeleccionado}?", "Eliminar Usuario", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            //si responde que si, instanciamos al objeto dbContext y eliminamos la propiedad a traves del id que obtuvimos.
            if (respuesta == DialogResult.Yes)
            {
                using (var db = new ConsultorioContext())
                {
                    var usuario = db.Usuarios.Find(idUsuarioSeleccionado);
                    db.Usuarios.Remove(usuario);
                    db.SaveChanges();
                }
                ActualizarGrillaUsuario();
            }
        }
    }
}
