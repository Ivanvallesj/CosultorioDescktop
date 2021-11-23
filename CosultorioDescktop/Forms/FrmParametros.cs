using System;
using System.Drawing;
using System.Windows.Forms;
using ConsultorioDesktop.Core;
using ConsultorioDesktop.ExtensionMethods;

namespace ConsultorioDesktop.Forms
{
    public partial class FrmParametros : Form
    {
        Form FrmMenuPrincipal;
        public FrmParametros(Form form)
        {
            InitializeComponent();
            CargarDatosEnPantalla();
            FrmMenuPrincipal = form;
        }

        private void CargarDatosEnPantalla()
        {
            txtServidor.Text = Properties.Settings.Default.servidor;
            txtBBDD.Text = Properties.Settings.Default.bbdd;
            txtUsuario.Text = Properties.Settings.Default.usuario;
            txtContraseña.Text = Properties.Settings.Default.contraseña;
            if (Properties.Settings.Default.imagenDeFondo != "")
            {
                PbxImagen.Image = HelperConsultorio.RecuperarImagenDeArchivoDeRecursos("fondoSistema");
                txtImagen.Text = Properties.Settings.Default.imagenDeFondo;
            }
        }
        private void btnExaminar_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofdAbrirArchivo = new OpenFileDialog();
            string filtro = "Todas las imágenes|*.jpg;*.gif;*.png;*.bmp;*.jpeg";
            filtro += "|JPG (*.jpg)|*.jpg";
            filtro += "|JPEG (*.jpeg)|*.jpeg";
            filtro += "|GIF (*.gif)|*.gif";
            filtro += "|PNG (*.png)|*.png";
            filtro += "|BMP (*.bmp)|*.bmp";

            ofdAbrirArchivo.Filter = filtro;
            ofdAbrirArchivo.ShowDialog();

            if (ofdAbrirArchivo.FileName != "")
            {
                PbxImagen.Image = new Bitmap(ofdAbrirArchivo.FileName);
                txtImagen.Text = ofdAbrirArchivo.FileName;
            }
        }

        private void btnParametros_Click(object sender, EventArgs e)
        {
            if (btnParametros.Text == "Modificar")
            {
                btnParametros.Text = "Guardar";
                btnExaminar.Enabled = true;
                this.HabilitarYDeshabilitarTextBox(true);
            }
            else
            {
                btnExaminar.Enabled = false;
                Properties.Settings.Default.usuario = txtUsuario.Text;
                Properties.Settings.Default.servidor = txtServidor.Text;
                Properties.Settings.Default.bbdd = txtBBDD.Text;
                Properties.Settings.Default.contraseña = txtContraseña.Text;
                Properties.Settings.Default.imagenDeFondo = txtImagen.Text;
                Properties.Settings.Default.Save();
                btnParametros.Text = "Modificar";
                this.HabilitarYDeshabilitarTextBox(false);
                if (Properties.Settings.Default.imagenDeFondo != "")
                {
                    HelperConsultorio.AlmacenarImagenEnArchivoDeRecursos(Image.FromFile(Properties.Settings.Default.imagenDeFondo), "fondoSistema");
                    FrmMenuPrincipal.BackgroundImage = Image.FromFile(Properties.Settings.Default.imagenDeFondo);
                }
            }
        }
    }
}
