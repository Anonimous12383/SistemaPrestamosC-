using System;
using System.Windows.Forms;
using Prestamos.Application.Services;

namespace Reportes_de_Victor
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Crear servicio
            PrestamoService servicio = new PrestamoService();

            // Generar tabla de amortización
            var datos = servicio.GenerarTablaAmortizacion(
                10000m,   // monto
                0.15m,    // tasa anual
                12        // plazo meses
            );

            // Crear formulario
            FrmReporteAmortizacion frm = new FrmReporteAmortizacion();

            // Cargar datos en el reporte
            frm.CargarDatos(datos);

            Application.Run(frm);
        }
    }
}