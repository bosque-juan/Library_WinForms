namespace Library_WinForms.Presentation
{
    partial class FrmSuggestedBooks
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
            this.grbLibrosRecomendar = new System.Windows.Forms.GroupBox();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.dgvConsulta3 = new System.Windows.Forms.DataGridView();
            this.ColCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTitulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColAutor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grbFecha = new System.Windows.Forms.GroupBox();
            this.CboHasta = new System.Windows.Forms.ComboBox();
            this.lblHasta = new System.Windows.Forms.Label();
            this.CboDesde = new System.Windows.Forms.ComboBox();
            this.lblDesde = new System.Windows.Forms.Label();
            this.lblGenero = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPrecioMax = new System.Windows.Forms.TextBox();
            this.txtPrecioMin = new System.Windows.Forms.TextBox();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.cboGenero = new System.Windows.Forms.ComboBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.grbLibrosRecomendar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsulta3)).BeginInit();
            this.grbFecha.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbLibrosRecomendar
            // 
            this.grbLibrosRecomendar.Controls.Add(this.btnConsultar);
            this.grbLibrosRecomendar.Controls.Add(this.dgvConsulta3);
            this.grbLibrosRecomendar.Controls.Add(this.grbFecha);
            this.grbLibrosRecomendar.Controls.Add(this.lblGenero);
            this.grbLibrosRecomendar.Controls.Add(this.label1);
            this.grbLibrosRecomendar.Controls.Add(this.txtPrecioMax);
            this.grbLibrosRecomendar.Controls.Add(this.txtPrecioMin);
            this.grbLibrosRecomendar.Controls.Add(this.lblPrecio);
            this.grbLibrosRecomendar.Controls.Add(this.cboGenero);
            this.grbLibrosRecomendar.Location = new System.Drawing.Point(20, 20);
            this.grbLibrosRecomendar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grbLibrosRecomendar.Name = "grbLibrosRecomendar";
            this.grbLibrosRecomendar.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grbLibrosRecomendar.Size = new System.Drawing.Size(574, 373);
            this.grbLibrosRecomendar.TabIndex = 0;
            this.grbLibrosRecomendar.TabStop = false;
            this.grbLibrosRecomendar.Text = "Libros para recomendar en redes";;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(510, 123);
            this.btnConsultar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(60, 22);
            this.btnConsultar.TabIndex = 7;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // dgvConsulta3
            // 
            this.dgvConsulta3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsulta3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColCodigo,
            this.ColTitulo,
            this.ColFecha,
            this.ColPrecio,
            this.ColStock,
            this.ColAutor});
            this.dgvConsulta3.Location = new System.Drawing.Point(4, 150);
            this.dgvConsulta3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvConsulta3.Name = "dgvConsulta3";
            this.dgvConsulta3.RowHeadersWidth = 51;
            this.dgvConsulta3.RowTemplate.Height = 24;
            this.dgvConsulta3.Size = new System.Drawing.Size(566, 219);
            this.dgvConsulta3.TabIndex = 8;
            // 
            // ColCodigo
            // 
            this.ColCodigo.HeaderText = "Codigo";
            this.ColCodigo.MinimumWidth = 6;
            this.ColCodigo.Name = "ColCodigo";
            this.ColCodigo.Width = 50;
            // 
            // ColTitulo
            // 
            this.ColTitulo.HeaderText = "Titulo";
            this.ColTitulo.MinimumWidth = 6;
            this.ColTitulo.Name = "ColTitulo";
            this.ColTitulo.Width = 150;
            // 
            // ColFecha
            // 
            this.ColFecha.HeaderText = "Fecha de Publicacion";
            this.ColFecha.MinimumWidth = 6;
            this.ColFecha.Name = "ColFecha";
            this.ColFecha.Width = 90;
            // 
            // ColPrecio
            // 
            this.ColPrecio.HeaderText = "Precio";
            this.ColPrecio.MinimumWidth = 6;
            this.ColPrecio.Name = "ColPrecio";
            this.ColPrecio.Width = 70;
            // 
            // ColStock
            // 
            this.ColStock.HeaderText = "Stock";
            this.ColStock.MinimumWidth = 6;
            this.ColStock.Name = "ColStock";
            this.ColStock.Width = 45;
            // 
            // ColAutor
            // 
            this.ColAutor.HeaderText = "Autor";
            this.ColAutor.MinimumWidth = 6;
            this.ColAutor.Name = "ColAutor";
            this.ColAutor.Width = 110;
            // 
            // grbFecha
            // 
            this.grbFecha.Controls.Add(this.CboHasta);
            this.grbFecha.Controls.Add(this.lblHasta);
            this.grbFecha.Controls.Add(this.CboDesde);
            this.grbFecha.Controls.Add(this.lblDesde);
            this.grbFecha.Location = new System.Drawing.Point(350, 17);
            this.grbFecha.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grbFecha.Name = "grbFecha";
            this.grbFecha.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grbFecha.Size = new System.Drawing.Size(189, 89);
            this.grbFecha.TabIndex = 6;
            this.grbFecha.TabStop = false;
            this.grbFecha.Text = "Año de publicación";
            // 
            // CboHasta
            // 
            this.CboHasta.FormattingEnabled = true;
            this.CboHasta.Location = new System.Drawing.Point(70, 62);
            this.CboHasta.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CboHasta.Name = "CboHasta";
            this.CboHasta.Size = new System.Drawing.Size(92, 21);
            this.CboHasta.TabIndex = 3;
            // 
            // lblHasta
            // 
            this.lblHasta.AutoSize = true;
            this.lblHasta.Location = new System.Drawing.Point(14, 67);
            this.lblHasta.Name = "lblHasta";
            this.lblHasta.Size = new System.Drawing.Size(35, 13);
            this.lblHasta.TabIndex = 2;
            this.lblHasta.Text = "Hasta";
            // 
            // CboDesde
            // 
            this.CboDesde.FormattingEnabled = true;
            this.CboDesde.Location = new System.Drawing.Point(70, 20);
            this.CboDesde.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CboDesde.Name = "CboDesde";
            this.CboDesde.Size = new System.Drawing.Size(92, 21);
            this.CboDesde.TabIndex = 1;
            // 
            // lblDesde
            // 
            this.lblDesde.AutoSize = true;
            this.lblDesde.Location = new System.Drawing.Point(14, 27);
            this.lblDesde.Name = "lblDesde";
            this.lblDesde.Size = new System.Drawing.Size(38, 13);
            this.lblDesde.TabIndex = 0;
            this.lblDesde.Text = "Desde";
            // 
            // lblGenero
            // 
            this.lblGenero.AutoSize = true;
            this.lblGenero.Location = new System.Drawing.Point(50, 44);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(42, 13);
            this.lblGenero.TabIndex = 0;
            this.lblGenero.Text = "Genero";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(168, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(10, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "-";
            // 
            // txtPrecioMax
            // 
            this.txtPrecioMax.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtPrecioMax.Location = new System.Drawing.Point(182, 79);
            this.txtPrecioMax.Name = "txtPrecioMax";
            this.txtPrecioMax.ReadOnly = true;
            this.txtPrecioMax.Size = new System.Drawing.Size(70, 20);
            this.txtPrecioMax.TabIndex = 5;
            this.txtPrecioMax.Text = "$100.000";
            this.txtPrecioMax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPrecioMin
            // 
            this.txtPrecioMin.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtPrecioMin.Location = new System.Drawing.Point(93, 79);
            this.txtPrecioMin.Name = "txtPrecioMin";
            this.txtPrecioMin.ReadOnly = true;
            this.txtPrecioMin.Size = new System.Drawing.Size(70, 20);
            this.txtPrecioMin.TabIndex = 3;
            this.txtPrecioMin.Text = "$30.000";
            this.txtPrecioMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(50, 84);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(37, 13);
            this.lblPrecio.TabIndex = 2;
            this.lblPrecio.Text = "Precio";
            // 
            // cboGenero
            // 
            this.cboGenero.FormattingEnabled = true;
            this.cboGenero.Location = new System.Drawing.Point(93, 37);
            this.cboGenero.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboGenero.Name = "cboGenero";
            this.cboGenero.Size = new System.Drawing.Size(159, 21);
            this.cboGenero.TabIndex = 1;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(484, 399);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(111, 32);
            this.btnSalir.TabIndex = 1;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // FrmConsulta3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 440);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.grbLibrosRecomendar);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmConsulta3";
            this.Text = "Libros a recomendar";
            this.Load += new System.EventHandler(this.FrmSuggestedBooks_Load);
            this.grbLibrosRecomendar.ResumeLayout(false);
            this.grbLibrosRecomendar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsulta3)).EndInit();
            this.grbFecha.ResumeLayout(false);
            this.grbFecha.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbLibrosRecomendar;
        private System.Windows.Forms.ComboBox cboGenero;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPrecioMax;
        private System.Windows.Forms.TextBox txtPrecioMin;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblGenero;
        private System.Windows.Forms.Label lblHasta;
        private System.Windows.Forms.Label lblDesde;
        private System.Windows.Forms.GroupBox grbFecha;
        private System.Windows.Forms.ComboBox CboDesde;
        private System.Windows.Forms.ComboBox CboHasta;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.DataGridView dgvConsulta3;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTitulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColAutor;
    }
}