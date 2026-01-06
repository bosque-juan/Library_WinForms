using Library_WinForms.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Library_WinForms.Servicio.VentasRealizadas
{
    internal class SalesReportService
    {
        DaoSalesReport oDaoVentas;
        public SalesReportService()
        {
            oDaoVentas = new DaoSalesReport();
        }
        public DataTable GetSalesDone(string nombre, string apellido, double importeMin, double importeMax, bool usarFiltroImporte,
                                                DateTime? fechaDesde, DateTime? fechaHasta, bool usarFiltroFecha, bool top15, string ordenarPorFecha,
                                                string ordenarPorImporte, List<string> formasPagoSeleccionadas)
        {
            return oDaoVentas.GetSalesFiltered(nombre, apellido, importeMin, importeMax, usarFiltroImporte, fechaDesde, fechaHasta, usarFiltroFecha,
                                                     top15,ordenarPorFecha, ordenarPorImporte, formasPagoSeleccionadas);
        }
    }
}
