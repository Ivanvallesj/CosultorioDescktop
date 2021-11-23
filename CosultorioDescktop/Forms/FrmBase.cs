using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ConsultorioDesktop.ExtensionMethods;
using ConsultorioDesktop.Interfaces;

namespace ConsultorioDesktop.Forms
{
    public partial class FrmBase : Form
    {
        IDbAdmin dbAdmin;
        IFormBase FrmNuevoEditar;
        public FrmBase(IDbAdmin objetoDbAdmin, IFormBase frmNuevoEditar)
        {
            InitializeComponent();
            dbAdmin = objetoDbAdmin;
            FrmNuevoEditar = frmNuevoEditar;
            ActualizarGrilla();
        }
        private void ActualizarGrilla()
        {
            if (chkVerEliminados.Checked)
            {
                grid.DataSource = dbAdmin.ObtenerEliminados();
                grid.OcultarColumnas(ocultarMostrar: true);
            }
            else
            {
                grid.DataSource = dbAdmin.ObtenerTodos();
                grid.OcultarColumnas();
            }
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            FrmNuevoEditar.LimpiarDatosDeLaPantalla();
            FrmNuevoEditar.ShowDialog();

            //actualizamos la grilla
            ActualizarGrilla();

            //seleccionamos la fila del nuevo registro cargado, le pasamos al RowCount -1 para que reste una posicion porque todo comienza del 0
            grid.CurrentCell = grid.Rows[grid.RowCount - 1].Cells[0];
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            //creamos la variable para saber que id de Calendario tenemos seleccionado
            var idSeleccionado = grid.ObtenerIdSeleccionado();
            var filaAEditar = grid.CurrentRow.Index;

            FrmNuevoEditar.IdEditar = idSeleccionado;
            FrmNuevoEditar.CargarDatosEnPantalla();
            FrmNuevoEditar.ShowDialog();


            //actualizamos la grilla
            ActualizarGrilla();

            //seleccionamos el registro editado
            grid.CurrentCell = grid.Rows[filaAEditar].Cells[0];
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            //obtenemos el id y el nombre del Calendario seleccionado en la grilla
            var idSeleccionado = grid.ObtenerIdSeleccionado();

            //guardamos en la variable el nombre y el apellido del Calendario seleccionado
            var nombreCalendarioSeleccionado = grid.ObtenerNombreSeleccionado(nroColumnaNombre: 1);

            // preguntar si realmente desea eliminar al Calendario [nombre_Calendario_seleccionado]
            //colocamos el signo $ para crear la interpolacion de cadenas
            DialogResult respuesta = MessageBox.Show($"¿Estas seguro que desea {BtnEliminar.Text} a {nombreCalendarioSeleccionado}?", BtnEliminar.Text + " Calendario", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            //si responde que si, instanciamos al objeto dbContext y eliminamos el Calendario a traves del id que obtuvimos.
            if (respuesta == DialogResult.Yes && BtnEliminar.Text == "Eliminar")
            {
                dbAdmin.Eliminar(idSeleccionado);
                ActualizarGrilla();
            }
            if (respuesta == DialogResult.Yes && BtnEliminar.Text == "Restaurar")
            {
                dbAdmin.Restaurar(idSeleccionado);
                ActualizarGrilla();
            }
        }
        private void chkVerEliminados_CheckedChanged(object sender, EventArgs e)
        {
            if (chkVerEliminados.Checked)
                BtnEliminar.Text = "Restaurar";
            else
                BtnEliminar.Text = "Eliminar";
            ActualizarGrilla();
        }

        private void TxtBusqueda_TextChanged_1(object sender, EventArgs e)
        {
            grid.DataSource = dbAdmin.ObtenerTodos(TxtBusqueda.Text);
        }
    }
}
