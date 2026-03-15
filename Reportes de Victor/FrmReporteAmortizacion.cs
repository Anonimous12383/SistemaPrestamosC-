using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using Prestamos.Application.DTOs;

namespace Reportes_de_Victor
{
    public partial class FrmReporteAmortizacion : Form
    {
        public FrmReporteAmortizacion()
        {
            InitializeComponent();
        }

        public void CargarDatos(List<AmortizacionItemDto> datos)
        {
            reportViewer1.Reset();

            reportViewer1.ProcessingMode = ProcessingMode.Local;

            reportViewer1.LocalReport.ReportEmbeddedResource =
                "Reportes_de_Victor.RDLC.RptAmortizacion.rdlc";

            reportViewer1.LocalReport.DataSources.Clear();

            ReportDataSource rds = new ReportDataSource("DataSet1", datos);

            reportViewer1.LocalReport.DataSources.Add(rds);

            reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
