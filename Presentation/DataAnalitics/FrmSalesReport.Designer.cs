namespace Library_WinForms.Presentation
{
    partial class FrmSalesReport
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvVentasRealizadas = new System.Windows.Forms.DataGridView();
            this.ColCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColFormaPago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCantLibros = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColImporte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblImporte = new System.Windows.Forms.Label();
            this.txtImporteMin = new System.Windows.Forms.TextBox();
            this.txtImporteMax = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCliente = new System.Windows.Forms.Label();
            this.txtClienteNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpDesde = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpHasta = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.chbTarjetaDebito = new System.Windows.Forms.CheckBox();
            this.chbTarjetaCredito = new System.Windows.Forms.CheckBox();
            this.chbBilleteraVirtual = new System.Windows.Forms.CheckBox();
            this.chbTransferenciaBancaria = new System.Windows.Forms.CheckBox();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.chbTop = new System.Windows.Forms.CheckBox();
            this.lblFiltros = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtClienteApellido = new System.Windows.Forms.TextBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.cboImporte = new System.Windows.Forms.ComboBox();
            this.cboFecha = new System.Windows.Forms.ComboBox();
            this.lblFecha = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentasRealizadas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvVentasRealizadas
            // 
            this.dgvVentasRealizadas.AllowUserToAddRows = false;
            this.dgvVentasRealizadas.AllowUserToDeleteRows = false;
            this.dgvVentasRealizadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVentasRealizadas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColCliente,
            this.ColFecha,
            this.ColFormaPago,
            this.ColCantLibros,
            this.ColImporte});
            this.dgvVentasRealizadas.Location = new System.Drawing.Point(31, 176);
            this.dgvVentasRealizadas.Name = "dgvVentasRealizadas";
            this.dgvVentasRealizadas.ReadOnly = true;
            this.dgvVentasRealizadas.RowHeadersWidth = 51;
            this.dgvVentasRealizadas.Size = new System.Drawing.Size(935, 257);
            this.dgvVentasRealizadas.TabIndex = 25;
            // 
            // ColCliente
            // 
            this.ColCliente.FillWeight = 200F;
            this.ColCliente.HeaderText = "Cliente";
            this.ColCliente.Name = "ColCliente";
            this.ColCliente.ReadOnly = true;
            this.ColCliente.Width = 160;
            // 
            // ColFecha
            // 
            this.ColFecha.FillWeight = 200F;
            this.ColFecha.HeaderText = "Fecha";
            this.ColFecha.Name = "ColFecha";
            this.ColFecha.ReadOnly = true;
            this.ColFecha.Width = 180;
            // 
            // ColFormaPago
            // 
            this.ColFormaPago.FillWeight = 200F;
            this.ColFormaPago.HeaderText = "Forma de Pago";
            this.ColFormaPago.Name = "ColFormaPago";
            this.ColFormaPago.ReadOnly = true;
            this.ColFormaPago.Width = 180;
            // 
            // ColCantLibros
            // 
            this.ColCantLibros.FillWeight = 200F;
            this.ColCantLibros.HeaderText = "Cantidad de Libros";
            this.ColCantLibros.Name = "ColCantLibros";
            this.ColCantLibros.ReadOnly = true;
            this.ColCantLibros.Width = 170;
            // 
            // ColImporte
            // 
            this.ColImporte.FillWeight = 200F;
            this.ColImporte.HeaderText = "Importe Total";
            this.ColImporte.Name = "ColImporte";
            this.ColImporte.ReadOnly = true;
            this.ColImporte.Width = 170;
            // 
            // lblImporte
            // 
            this.lblImporte.AutoSize = true;
            this.lblImporte.Location = new System.Drawing.Point(28, 124);
            this.lblImporte.Name = "lblImporte";
            this.lblImporte.Size = new System.Drawing.Size(42, 13);
            this.lblImporte.TabIndex = 5;
            this.lblImporte.Text = "Importe";
            // 
            // txtImporteMin
            // 
            this.txtImporteMin.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtImporteMin.Location = new System.Drawing.Point(97, 119);
            this.txtImporteMin.Name = "txtImporteMin";
            this.txtImporteMin.Size = new System.Drawing.Size(70, 20);
            this.txtImporteMin.TabIndex = 6;
            this.txtImporteMin.Text = "min";
            this.txtImporteMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtImporteMax
            // 
            this.txtImporteMax.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtImporteMax.Location = new System.Drawing.Point(189, 119);
            this.txtImporteMax.Name = "txtImporteMax";
            this.txtImporteMax.Size = new System.Drawing.Size(70, 20);
            this.txtImporteMax.TabIndex = 8;
            this.txtImporteMax.Text = "máx";
            this.txtImporteMax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(173, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(10, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "-";
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(28, 22);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(39, 13);
            this.lblCliente.TabIndex = 0;
            this.lblCliente.Text = "Cliente";
            // 
            // txtClienteNombre
            // 
            this.txtClienteNombre.Location = new System.Drawing.Point(97, 57);
            this.txtClienteNombre.Name = "txtClienteNombre";
            this.txtClienteNombre.Size = new System.Drawing.Size(162, 20);
            this.txtClienteNombre.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(352, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Desde";
            // 
            // dtpDesde
            // 
            this.dtpDesde.Location = new System.Drawing.Point(341, 58);
            this.dtpDesde.Name = "dtpDesde";
            this.dtpDesde.Size = new System.Drawing.Size(201, 20);
            this.dtpDesde.TabIndex = 11;
            this.dtpDesde.Value = new System.DateTime(2021, 6, 1, 11, 27, 0, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(338, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Rango de Fecha";
            // 
            // dtpHasta
            // 
            this.dtpHasta.Location = new System.Drawing.Point(341, 117);
            this.dtpHasta.Name = "dtpHasta";
            this.dtpHasta.Size = new System.Drawing.Size(201, 20);
            this.dtpHasta.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(352, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Hasta";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(621, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Forma de Pago";
            // 
            // chbTarjetaDebito
            // 
            this.chbTarjetaDebito.AutoSize = true;
            this.chbTarjetaDebito.Location = new System.Drawing.Point(624, 57);
            this.chbTarjetaDebito.Name = "chbTarjetaDebito";
            this.chbTarjetaDebito.Size = new System.Drawing.Size(93, 17);
            this.chbTarjetaDebito.TabIndex = 15;
            this.chbTarjetaDebito.Text = "Tarjeta Débito";
            this.chbTarjetaDebito.UseVisualStyleBackColor = true;
            // 
            // chbTarjetaCredito
            // 
            this.chbTarjetaCredito.AutoSize = true;
            this.chbTarjetaCredito.Location = new System.Drawing.Point(624, 79);
            this.chbTarjetaCredito.Name = "chbTarjetaCredito";
            this.chbTarjetaCredito.Size = new System.Drawing.Size(95, 17);
            this.chbTarjetaCredito.TabIndex = 16;
            this.chbTarjetaCredito.Text = "Tarjeta Crédito";
            this.chbTarjetaCredito.UseVisualStyleBackColor = true;
            // 
            // chbBilleteraVirtual
            // 
            this.chbBilleteraVirtual.AutoSize = true;
            this.chbBilleteraVirtual.Location = new System.Drawing.Point(624, 102);
            this.chbBilleteraVirtual.Name = "chbBilleteraVirtual";
            this.chbBilleteraVirtual.Size = new System.Drawing.Size(95, 17);
            this.chbBilleteraVirtual.TabIndex = 17;
            this.chbBilleteraVirtual.Text = "Billetera Virtual";
            this.chbBilleteraVirtual.UseVisualStyleBackColor = true;
            // 
            // chbTransferenciaBancaria
            // 
            this.chbTransferenciaBancaria.AutoSize = true;
            this.chbTransferenciaBancaria.Location = new System.Drawing.Point(624, 125);
            this.chbTransferenciaBancaria.Name = "chbTransferenciaBancaria";
            this.chbTransferenciaBancaria.Size = new System.Drawing.Size(136, 17);
            this.chbTransferenciaBancaria.TabIndex = 18;
            this.chbTransferenciaBancaria.Text = "Transferencia Bancaria";
            this.chbTransferenciaBancaria.UseVisualStyleBackColor = true;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(77, 459);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(157, 29);
            this.btnConsultar.TabIndex = 26;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // chbTop
            // 
            this.chbTop.AutoSize = true;
            this.chbTop.Location = new System.Drawing.Point(820, 57);
            this.chbTop.Name = "chbTop";
            this.chbTop.Size = new System.Drawing.Size(60, 17);
            this.chbTop.TabIndex = 20;
            this.chbTop.Text = "Top 15";
            this.chbTop.UseVisualStyleBackColor = true;
            // 
            // lblFiltros
            // 
            this.lblFiltros.AutoSize = true;
            this.lblFiltros.Location = new System.Drawing.Point(817, 22);
            this.lblFiltros.Name = "lblFiltros";
            this.lblFiltros.Size = new System.Drawing.Size(34, 13);
            this.lblFiltros.TabIndex = 19;
            this.lblFiltros.Text = "Filtros";
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(752, 459);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(157, 29);
            this.btnSalir.TabIndex = 27;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(28, 64);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre";
            // 
            // txtClienteApellido
            // 
            this.txtClienteApellido.Location = new System.Drawing.Point(97, 88);
            this.txtClienteApellido.Name = "txtClienteApellido";
            this.txtClienteApellido.Size = new System.Drawing.Size(162, 20);
            this.txtClienteApellido.TabIndex = 4;
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(28, 95);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(44, 13);
            this.lblApellido.TabIndex = 3;
            this.lblApellido.Text = "Apellido";
            // 
            // cboImporte
            // 
            this.cboImporte.FormattingEnabled = true;
            this.cboImporte.Location = new System.Drawing.Point(880, 120);
            this.cboImporte.Name = "cboImporte";
            this.cboImporte.Size = new System.Drawing.Size(86, 21);
            this.cboImporte.TabIndex = 24;
            // 
            // cboFecha
            // 
            this.cboFecha.FormattingEnabled = true;
            this.cboFecha.Location = new System.Drawing.Point(880, 80);
            this.cboFecha.Name = "cboFecha";
            this.cboFecha.Size = new System.Drawing.Size(86, 21);
            this.cboFecha.TabIndex = 22;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(817, 88);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(37, 13);
            this.lblFecha.TabIndex = 21;
            this.lblFecha.Text = "Fecha";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(817, 126);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "Importe";
            // 
            // FrmConsultaVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1007, 500);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.cboFecha);
            this.Controls.Add(this.cboImporte);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.txtClienteApellido);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.lblFiltros);
            this.Controls.Add(this.chbTop);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.chbTransferenciaBancaria);
            this.Controls.Add(this.chbBilleteraVirtual);
            this.Controls.Add(this.chbTarjetaCredito);
            this.Controls.Add(this.chbTarjetaDebito);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtpHasta);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpDesde);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtClienteNombre);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtImporteMax);
            this.Controls.Add(this.txtImporteMin);
            this.Controls.Add(this.lblImporte);
            this.Controls.Add(this.dgvVentasRealizadas);
            this.Name = "FrmSalesReport";
            this.ShowIcon = false;
            this.Text = "Ventas Realizadas";
            this.Load += new System.EventHandler(this.FrmConsultaVentas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentasRealizadas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvVentasRealizadas;
        private System.Windows.Forms.Label lblImporte;
        private System.Windows.Forms.TextBox txtImporteMin;
        private System.Windows.Forms.TextBox txtImporteMax;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.TextBox txtClienteNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpDesde;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpHasta;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox chbTarjetaDebito;
        private System.Windows.Forms.CheckBox chbTarjetaCredito;
        private System.Windows.Forms.CheckBox chbBilleteraVirtual;
        private System.Windows.Forms.CheckBox chbTransferenciaBancaria;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.CheckBox chbTop;
        private System.Windows.Forms.Label lblFiltros;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtClienteApellido;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.ComboBox cboImporte;
        private System.Windows.Forms.ComboBox cboFecha;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColFormaPago;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCantLibros;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColImporte;
    }
}