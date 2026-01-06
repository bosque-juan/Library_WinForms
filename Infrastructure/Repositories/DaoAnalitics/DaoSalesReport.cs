using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_WinForms.Data
{
    internal class DaoSalesReport
    {
        DataAccess oBDSales;

        public DaoSalesReport()
        {
            oBDSales = new DataAccess();
        }
        public DataTable GetSalesFiltered(string nombreCliente, string apellidoCliente, double importeMin, double importeMax,
                                             bool usarFiltroImporte, DateTime? fechaDesde, DateTime? fechaHasta, bool usarFiltroFecha,
                                             bool top15, string ordenarPorFecha, string ordenarPorImporte, List<string> formasPagoSeleccionadas)
        {
            string selectTop = top15 ? "TOP 15" : "";

            string consulta = $@"
                              SELECT {selectTop}
                                     c.nombre + SPACE(1) + UPPER(c.apellido) AS CLIENTE,
                                     df.cantidad AS 'CANTIDAD DE LIBROS',
                                     (df.cantidad * df.precio + df.recargo) AS IMPORTE_TOTAL,
                                     CONVERT(varchar, f.fecha, 103) AS 'FECHA FACTURA',
                                     fp.forma_pago AS 'FORMA DE PAGO'
                                FROM detalle_facturas df
                                JOIN facturas f ON df.nro_factura = f.nro_factura
                                JOIN clientes c ON f.cod_cliente = c.cod_cliente
                                JOIN contactos con ON c.cod_cliente = con.cod_cliente
                                JOIN tipos_contactos tcon ON con.id_tipo_contacto = tcon.id_tipo_contacto
                                JOIN facturas_formaspago ffp ON f.nro_factura = ffp.nro_factura
                                JOIN formas_pagos fp ON ffp.id_forma_pago = fp.id_forma_pago
                               WHERE 1 = 1 ";

            List<Parameter> parameters = new List<Parameter>();

            if (!string.IsNullOrWhiteSpace(nombreCliente))
            {
                consulta += " AND c.nombre LIKE @nombre";
                parameters.Add(new Parameter("@nombre", $"%{nombreCliente}%"));
            }

            if (!string.IsNullOrWhiteSpace(apellidoCliente))
            {
                consulta += " AND c.apellido LIKE @apellido";
                parameters.Add(new Parameter("@apellido", $"%{apellidoCliente.ToUpper()}%"));
            }

            if (usarFiltroImporte)
            {
                consulta += " AND (df.cantidad * df.precio + df.recargo) BETWEEN @importeMin AND @importeMax";
                parameters.Add(new Parameter("@importeMin", importeMin));
                parameters.Add(new Parameter("@importeMax", importeMax));
            }

            if (usarFiltroFecha && fechaDesde.HasValue && fechaHasta.HasValue)
            {
                consulta += " AND f.fecha BETWEEN @fechaDesde AND @fechaHasta";
                parameters.Add(new Parameter("@fechaDesde", fechaDesde.Value));
                parameters.Add(new Parameter("@fechaHasta", fechaHasta.Value));
            }

            if (formasPagoSeleccionadas != null && formasPagoSeleccionadas.Any())
            {
                List<string> inParams = new List<string>();

                for (int i = 0; i < formasPagoSeleccionadas.Count; i++)
                {
                    string paramName = $"@fp{i}";
                    inParams.Add(paramName);
                    parameters.Add(new Parameter(paramName, formasPagoSeleccionadas[i]));
                }

                consulta += $" AND fp.forma_pago IN ({string.Join(",", inParams)})";
            }

            List<string> ordenamientos = new List<string>();

            if (!string.IsNullOrEmpty(ordenarPorImporte))
                ordenamientos.Add($"IMPORTE_TOTAL {(ordenarPorImporte == "desc" ? "DESC" : "ASC")}");

            if (!string.IsNullOrEmpty(ordenarPorFecha))
                ordenamientos.Add($"f.fecha {(ordenarPorFecha == "desc" ? "DESC" : "ASC")}");

            if (ordenamientos.Count > 0)
                consulta += " ORDER BY " + string.Join(", ", ordenamientos);

            return oBDSales.QueryDb(consulta, parameters);
        }


    }
}
