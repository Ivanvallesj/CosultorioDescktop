using ConsultorioDesktop.Core;
using ConsultorioDesktop.Forms;
using ConsultorioDesktop.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsultorioDesktop
{
    public partial class FrmLogin : Form
    {
        int intentosFallidos = 0;
        int intentosMaximos = 3;
        int intentosRestantes;
        public FrmMenuPrincipal FrmMenuPrincipal;
        public FrmLogin(FrmMenuPrincipal frmPrincipal)
        {
            InitializeComponent();
            FrmMenuPrincipal = frmPrincipal;
        }

        private void BtnIngresar_Click(object sender, EventArgs e)
        {
            Ingresar();
        }
        private void Ingresar()
        {
            if (ValidarAcceso())
                this.Close();
            else
            {
                intentosFallidos++;
                intentosRestantes = intentosMaximos - intentosFallidos;
                if (intentosFallidos == 3)
                    this.Close();
                else
                {
                    MessageBox.Show($"Error en ingresar, usuario o contraseña incorrectos, te quedan {intentosRestantes} intentos");

                    TxtUsuario.Text = "";
                    TxtPassword.Text = "";
                }
            }
            }
        private bool ValidarAcceso()
        {
            using var db = new ConsultorioContext();
            string pass = HelperConsultorio.ObtenerSha256Hash(TxtPassword.Text);
            var listaUsuarios = db.Usuarios.Where(u => u.User.Equals(TxtUsuario.Text)).Where(u => u.Password.Equals(pass)).ToList();
            if (listaUsuarios.Count > 0)
            {
                FrmMenuPrincipal.Usuario = listaUsuarios.ElementAt(0);
                return true;
            }
            else
            {
                return false;
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
