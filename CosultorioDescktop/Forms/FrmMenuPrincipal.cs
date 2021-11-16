using CosultorioDescktop.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CosultorioDescktop.Forms
{
    public partial class FrmMenuPrincipal : Form
    {
        public static Usuario Usuario;
        public FrmMenuPrincipal()
        {
            InitializeComponent();
        }
        private void administradoresDoctoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmDoctores = new FrmDoctores();
            frmDoctores.ShowDialog();

        }

        private void FrmMenuPrincipal_Activated_1(object sender, EventArgs e)
        {
            if (Usuario == null)
            {
                //si no hay nadie logeado, entonces mostramos el formulario de Login
                var frmLogin = new FrmLogin(this);
                frmLogin.ShowDialog();
                if (Usuario != null)
                {
                    //dependiendo el tipo de usuario, habilitamos los distintos menues para que tengan acceso
                    //MnuUsuario.Enabled = Usuario.TipoUsuario == TipoUsuarioEnum.Administrador ? true : false;
                }
                else
                {
                    Application.Exit();
                }
            }

        }

        private void pacientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmPacientes = new FrmPacientes();
            frmPacientes.ShowDialog();
        }
    }
}
