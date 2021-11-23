using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace ConsultorioDesktop.ExtensionMethods
{
    public static class MyExtensions
    {
        /// <summary>
        /// Fecha : 30/09/2021
        /// Creamos un metodo generico que pregunte en formularios especiales si esta seguro que desea salir 
        /// </summary>
        /// <param name="form"></param>
        public static void MensajeDeAdvertenciaDeSalida(this Form form)
        {
            var respuesta = MessageBox.Show($"¿Éstas seguro que deseas salir del formulario {form.Text}?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes) form.Close();
        }
        public static void HabilitarYDeshabilitarTextBox(this Form form, bool valor)
        {
            foreach (Object obj in form.Controls)
            {
                if (obj.GetType().Name == "TextBox")
                {
                    TextBox o = (TextBox)obj;
                    o.Enabled = valor;
                }
            }
        }

        public static void OcultarColumnas(this DataGridView grid, bool ocultarMostrar = false)
        {
            //como entendemos que nunca sera necesario ver la columna id hacemos que siempre se oculte 
            if (grid.Columns["UsuarioId"] != null)
                grid.Columns["UsuarioId"].Visible = false;
            if (grid.Columns["Usuario"] != null)
                grid.Columns["Usuario"].Visible = ocultarMostrar;
            if (grid.Columns["Eliminado"] != null)
                grid.Columns["Eliminado"].Visible = ocultarMostrar;
            if (grid.Columns["FechaHoraEliminacion"] != null)
                grid.Columns["FechaHoraEliminacion"].Visible = ocultarMostrar;
            if (grid.Columns["Pacientes"] != null)
                grid.Columns["Pacientes"].Visible = ocultarMostrar;
            if (grid.Columns["Contraseña"] != null)
                grid.Columns["Contraseña"].Visible = ocultarMostrar;
            if (grid.Columns["Email"] != null)
                grid.Columns["Email"].Visible = ocultarMostrar;
            if (grid.Columns["FechaNacimiento"] != null)
                grid.Columns["FechaNacimiento"].Visible = ocultarMostrar;
            if (grid.Columns["DoctorId"] != null)
                grid.Columns["DoctorId"].Visible = ocultarMostrar;
            if (grid.Columns["PacienteId"] != null)
                grid.Columns["PacienteId"].Visible = ocultarMostrar;

        }
        public static int ObtenerIdSeleccionado(this DataGridView grid)
        {
            return int.Parse(grid.CurrentRow.Cells[0].Value.ToString());
        }
        public static string ObtenerNombreSeleccionado(this DataGridView grid, int nroColumnaNombre)
        {
            return grid.CurrentRow.Cells[nroColumnaNombre].Value.ToString();
        }
    }
}

