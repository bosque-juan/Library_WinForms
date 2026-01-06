using Library_WinForms.Data;
using Library_WinForms.Servicio;
using Library_WinForms.Servicio.VentasRealizadas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_WinForms.Presentation
{
    public partial class FrmSalesReport : Form
    {
        SalesReportService ServicioVentas;
        public FrmSalesReport()
        {
            InitializeComponent();
            ServicioVentas = new SalesReportService();
        }

        private void FrmConsultaVentas_Load(object sender, EventArgs e)
        {
            comboOrdenamiento();
        }
        private bool ValidarFrmVentas(double importeMin, double importeMax, bool EsMinDouble, bool EsMaxDouble)
        {
            bool placeholderMin = txtImporteMin.Text == "min";
            bool placeholderMax = txtImporteMax.Text == "máx";
            bool minVacio = string.IsNullOrWhiteSpace(txtImporteMin.Text) ;
            bool maxVacio = string.IsNullOrWhiteSpace(txtImporteMax.Text) ;
 
            bool ambosPlaceholder = placeholderMin && placeholderMax;

            // Para ver si algun campo está vacio
            if ((minVacio && !maxVacio) || (!minVacio && maxVacio) ||
                (placeholderMin && !placeholderMax) || (!placeholderMin && placeholderMax))
            {
                MessageBox.Show("Los campos de importe deben estar completos y con valores numéricos.");
                return true;
            }

            // corroborar valores
            if (!ambosPlaceholder)
            {
                if (!EsMinDouble || !EsMaxDouble)
                {
                    MessageBox.Show("Los campos de importe deben contener valores numéricos.");
                    return true;
                }

                if (importeMin > importeMax)
                {
                    MessageBox.Show("El importe mínimo debe ser menor o igual al importe máximo.");
                    return true;
                }
            }

            // Validar fechas
            if (!(dtpDesde.Value.Date < DateTime.Today))
            {
                MessageBox.Show("La fecha 'Desde' debe ser anterior a la fecha de hoy.");
                dtpDesde.Focus();
                return true;
            }

            if (!(dtpHasta.Value.Date >= DateTime.Today))
            {
                MessageBox.Show("La fecha 'Hasta' debe ser igual o anterior a la fecha de hoy.");
                dtpHasta.Focus();
                return true;
            }

            return false;
        }

        // BOTON CONSULTAR
        private void btnConsultar_Click(object sender, EventArgs e)
        {
            bool minDouble = double.TryParse(txtImporteMin.Text, out double importeMin);
            bool maxDouble = double.TryParse(txtImporteMax.Text, out double importeMax);
            // corta el flujo de ejecución
            if (ValidarFrmVentas(importeMin, importeMax, minDouble, maxDouble)) return;
            // FILTROS

            // nombre
            string nombre = txtClienteNombre.Text;
            string apellido = txtClienteApellido.Text;

            bool usarFiltroImporte = minDouble && maxDouble;

            // fechas
            DateTime fechaDesde = dtpDesde.Value;
            DateTime fechaHasta = dtpHasta.Value.Date;
            bool filtroFecha = fechaDesde != fechaHasta;

            // forma de pago
            List<string> formasPago = new List<string>();
            if (chbBilleteraVirtual.Checked) formasPago.Add("Billetera Virtual");
            if (chbTarjetaCredito.Checked) formasPago.Add("Tarjeta de crédito");
            if (chbTarjetaDebito.Checked) formasPago.Add("Tarjeta de débito");
            if (chbTransferenciaBancaria.Checked) formasPago.Add("Transferencia bancaria");

            // ordenamiento por filtros
            bool top = chbTop.Checked;
            string ordenFecha = cboFecha.Text;
            string ordenImporte = cboImporte.Text;

            DataTable resultados = ServicioVentas.GetSalesDone(
                nombre,
                apellido,
                importeMin,
                importeMax,
                usarFiltroImporte,
                fechaDesde,
                fechaHasta,
                filtroFecha,
                top,
                ordenFecha,
                ordenImporte,
                formasPago
            );

            dgvVentasRealizadas.Rows.Clear();
            foreach (DataRow dt in resultados.Rows)
            {
                dgvVentasRealizadas.Rows.Add(dt[0], dt[3], dt[4], dt[1], dt[2]);
            }
        }

        private void comboOrdenamiento()
        {
            // fecha
            cboFecha.SelectedItem = -1;
            cboFecha.Items.Add("");
            cboFecha.Items.Add("asc");
            cboFecha.Items.Add("desc");
            cboFecha.DropDownStyle = ComboBoxStyle.DropDownList;

            // importe
            cboImporte.SelectedItem = -1;
            cboImporte.Items.Add("");
            cboImporte.Items.Add("asc");
            cboImporte.Items.Add("desc");
            cboImporte.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea Salir", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}

