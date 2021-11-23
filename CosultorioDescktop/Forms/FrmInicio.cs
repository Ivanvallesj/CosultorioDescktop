using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConsultorioDesktop.Models;

namespace ConsultorioDesktop.Forms
{
    public partial class FrmInicio : Form
    {
        private bool CargaBBDDCompleta = false;
        private bool CargaReporteCompleta = false;
        public FrmInicio()
        {
            InitializeComponent();
        }

        private async Task ConsultaDatosSqlAsync()
        {
            await Task.Run(() =>
            {
                using (var db = new ConsultorioContext())
                {
                    var listaDoctores = db.Doctores.ToList();
                }
                CargaBBDDCompleta = true;
            });
        }
        private async Task ImpresionDeReportesAsync()
        {
            await Task.Run(() =>
            {
                var reporte = new ReportViewer();
                //abrumos el reporte utilizando la clase FileStream
                using var fs = new FileStream(@"..\..\..\reportes\ReporteDoctores.rdlc", FileMode.Open);

                //asignamos el archivo a la propiedad LocalReport del objeto RepoViewer
                reporte.LocalReport.LoadReportDefinition(fs);

                //buscamos los datos que va a graficar el reporte
                using var db = new ConsultorioContext();
                var doctores = db.Doctores.ToList();

                //asignamos los datos a la propiedad DataSources de Local Report utilizando un objeto de tipo ReportDataSource
                reporte.LocalReport.DataSources.Add(new ReportDataSource("DataSetDoctores", doctores));

                reporte.RefreshReport();
                reporte.SetDisplayMode(DisplayMode.PrintLayout);
                CargaReporteCompleta = true;
            }); 
            

        }

        private void timerInicio_Tick(object sender, EventArgs e)
        {
                PbInicio.Value = PbInicio.Value += 1;
                lblPorcentaje.Text = PbInicio.Value.ToString() + " %";

            if(PbInicio.Value ==100 || CargaBBDDCompleta && CargaReporteCompleta){
                if (CargaReporteCompleta && CargaReporteCompleta) { 
                timerInicio.Enabled = false;
                var frmMenuPrincipal = new FrmMenuPrincipal();
                frmMenuPrincipal.ShowDialog();
                this.Close();
                }
                else
                {
                    PbInicio.Value = 0;
                }
            }
        }

        private async void FrmInicio_Activated(object sender, EventArgs e)
        {
            await ConsultaDatosSqlAsync();
            await ImpresionDeReportesAsync();
        }

        private void PbInicio_Click(object sender, EventArgs e)
        {

        }
    }
}
