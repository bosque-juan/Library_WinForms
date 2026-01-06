namespace Library_WinForms.Presentation
{
    partial class FrmBookTransaction
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
            this.GrbDetalles = new System.Windows.Forms.GroupBox();
            this.CboEditorial = new System.Windows.Forms.ComboBox();
            this.CboIdioma = new System.Windows.Forms.ComboBox();
            this.TxtDescripcion = new System.Windows.Forms.TextBox();
            this.TxtIsbn = new System.Windows.Forms.TextBox();
            this.TxtStock = new System.Windows.Forms.TextBox();
            this.LblIdioma = new System.Windows.Forms.Label();
            this.LblEditorial = new System.Windows.Forms.Label();
            this.LblStock = new System.Windows.Forms.Label();
            this.LblDescripcion = new System.Windows.Forms.Label();
            this.TxtPrecio = new System.Windows.Forms.TextBox();
            this.LblPrecio = new System.Windows.Forms.Label();
            this.DtpFecha = new System.Windows.Forms.DateTimePicker();
            this.CboAutor = new System.Windows.Forms.ComboBox();
            this.TxtTitulo = new System.Windows.Forms.TextBox();
            this.TxtCodigo = new System.Windows.Forms.TextBox();
            this.LblFecha = new System.Windows.Forms.Label();
            this.LblIsbn = new System.Windows.Forms.Label();
            this.LblAutor = new System.Windows.Forms.Label();
            this.LblTitulo = new System.Windows.Forms.Label();
            this.LblCodigo = new System.Windows.Forms.Label();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnAceptar = new System.Windows.Forms.Button();
            this.lblGenero = new System.Windows.Forms.Label();
            this.cboGenero = new System.Windows.Forms.ComboBox();
            this.GrbDetalles.SuspendLayout();
            this.SuspendLayout();
            // 
            // GrbDetalles
            // 
            this.GrbDetalles.Controls.Add(this.cboGenero);
            this.GrbDetalles.Controls.Add(this.lblGenero);
            this.GrbDetalles.Controls.Add(this.CboEditorial);
            this.GrbDetalles.Controls.Add(this.CboIdioma);
            this.GrbDetalles.Controls.Add(this.TxtDescripcion);
            this.GrbDetalles.Controls.Add(this.TxtIsbn);
            this.GrbDetalles.Controls.Add(this.TxtStock);
            this.GrbDetalles.Controls.Add(this.LblIdioma);
            this.GrbDetalles.Controls.Add(this.LblEditorial);
            this.GrbDetalles.Controls.Add(this.LblStock);
            this.GrbDetalles.Controls.Add(this.LblDescripcion);
            this.GrbDetalles.Controls.Add(this.TxtPrecio);
            this.GrbDetalles.Controls.Add(this.LblPrecio);
            this.GrbDetalles.Controls.Add(this.DtpFecha);
            this.GrbDetalles.Controls.Add(this.CboAutor);
            this.GrbDetalles.Controls.Add(this.TxtTitulo);
            this.GrbDetalles.Controls.Add(this.TxtCodigo);
            this.GrbDetalles.Controls.Add(this.LblFecha);
            this.GrbDetalles.Controls.Add(this.LblIsbn);
            this.GrbDetalles.Controls.Add(this.LblAutor);
            this.GrbDetalles.Controls.Add(this.LblTitulo);
            this.GrbDetalles.Controls.Add(this.LblCodigo);
            this.GrbDetalles.Location = new System.Drawing.Point(164, 12);
            this.GrbDetalles.Name = "GrbDetalles";
            this.GrbDetalles.Size = new System.Drawing.Size(426, 366);
            this.GrbDetalles.TabIndex = 0;
            this.GrbDetalles.TabStop = false;
            this.GrbDetalles.Text = "Detalles";
            // 
            // CboEditorial
            // 
            this.CboEditorial.FormattingEnabled = true;
            this.CboEditorial.Location = new System.Drawing.Point(157, 285);
            this.CboEditorial.Name = "CboEditorial";
            this.CboEditorial.Size = new System.Drawing.Size(203, 21);
            this.CboEditorial.TabIndex = 19;
            // 
            // CboIdioma
            // 
            this.CboIdioma.FormattingEnabled = true;
            this.CboIdioma.Location = new System.Drawing.Point(157, 254);
            this.CboIdioma.Name = "CboIdioma";
            this.CboIdioma.Size = new System.Drawing.Size(203, 21);
            this.CboIdioma.TabIndex = 17;
            // 
            // TxtDescripcion
            // 
            this.TxtDescripcion.Location = new System.Drawing.Point(157, 137);
            this.TxtDescripcion.Name = "TxtDescripcion";
            this.TxtDescripcion.Size = new System.Drawing.Size(203, 20);
            this.TxtDescripcion.TabIndex = 9;
            // 
            // TxtIsbn
            // 
            this.TxtIsbn.Location = new System.Drawing.Point(157, 50);
            this.TxtIsbn.Margin = new System.Windows.Forms.Padding(2);
            this.TxtIsbn.Name = "TxtIsbn";
            this.TxtIsbn.Size = new System.Drawing.Size(203, 20);
            this.TxtIsbn.TabIndex = 3;
            // 
            // TxtStock
            // 
            this.TxtStock.Location = new System.Drawing.Point(157, 166);
            this.TxtStock.Name = "TxtStock";
            this.TxtStock.Size = new System.Drawing.Size(203, 20);
            this.TxtStock.TabIndex = 11;
            // 
            // LblIdioma
            // 
            this.LblIdioma.AutoSize = true;
            this.LblIdioma.Location = new System.Drawing.Point(92, 257);
            this.LblIdioma.Name = "LblIdioma";
            this.LblIdioma.Size = new System.Drawing.Size(38, 13);
            this.LblIdioma.TabIndex = 16;
            this.LblIdioma.Text = "Idioma";
            // 
            // LblEditorial
            // 
            this.LblEditorial.AutoSize = true;
            this.LblEditorial.Location = new System.Drawing.Point(84, 288);
            this.LblEditorial.Name = "LblEditorial";
            this.LblEditorial.Size = new System.Drawing.Size(44, 13);
            this.LblEditorial.TabIndex = 18;
            this.LblEditorial.Text = "Publisher";
            // 
            // LblStock
            // 
            this.LblStock.AutoSize = true;
            this.LblStock.Location = new System.Drawing.Point(93, 169);
            this.LblStock.Name = "LblStock";
            this.LblStock.Size = new System.Drawing.Size(35, 13);
            this.LblStock.TabIndex = 10;
            this.LblStock.Text = "Stock";
            // 
            // LblDescripcion
            // 
            this.LblDescripcion.AutoSize = true;
            this.LblDescripcion.Location = new System.Drawing.Point(65, 140);
            this.LblDescripcion.Name = "LblDescripcion";
            this.LblDescripcion.Size = new System.Drawing.Size(63, 13);
            this.LblDescripcion.TabIndex = 8;
            this.LblDescripcion.Text = "Descripción";
            // 
            // TxtPrecio
            // 
            this.TxtPrecio.Location = new System.Drawing.Point(157, 109);
            this.TxtPrecio.Name = "TxtPrecio";
            this.TxtPrecio.Size = new System.Drawing.Size(203, 20);
            this.TxtPrecio.TabIndex = 7;
            // 
            // LblPrecio
            // 
            this.LblPrecio.AutoSize = true;
            this.LblPrecio.Location = new System.Drawing.Point(93, 112);
            this.LblPrecio.Name = "LblPrecio";
            this.LblPrecio.Size = new System.Drawing.Size(37, 13);
            this.LblPrecio.TabIndex = 6;
            this.LblPrecio.Text = "Precio";
            // 
            // DtpFecha
            // 
            this.DtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpFecha.Location = new System.Drawing.Point(157, 195);
            this.DtpFecha.Name = "DtpFecha";
            this.DtpFecha.Size = new System.Drawing.Size(203, 20);
            this.DtpFecha.TabIndex = 13;
            // 
            // CboAutor
            // 
            this.CboAutor.FormattingEnabled = true;
            this.CboAutor.Location = new System.Drawing.Point(157, 224);
            this.CboAutor.Name = "CboAutor";
            this.CboAutor.Size = new System.Drawing.Size(203, 21);
            this.CboAutor.TabIndex = 15;
            // 
            // TxtTitulo
            // 
            this.TxtTitulo.Location = new System.Drawing.Point(157, 79);
            this.TxtTitulo.Name = "TxtTitulo";
            this.TxtTitulo.Size = new System.Drawing.Size(203, 20);
            this.TxtTitulo.TabIndex = 5;
            // 
            // TxtCodigo
            // 
            this.TxtCodigo.Enabled = false;
            this.TxtCodigo.Location = new System.Drawing.Point(157, 20);
            this.TxtCodigo.Name = "TxtCodigo";
            this.TxtCodigo.Size = new System.Drawing.Size(203, 20);
            this.TxtCodigo.TabIndex = 1;
            // 
            // LblFecha
            // 
            this.LblFecha.AutoSize = true;
            this.LblFecha.Location = new System.Drawing.Point(19, 201);
            this.LblFecha.Name = "LblFecha";
            this.LblFecha.Size = new System.Drawing.Size(111, 13);
            this.LblFecha.TabIndex = 12;
            this.LblFecha.Text = "Fecha de lanzamiento";
            // 
            // LblIsbn
            // 
            this.LblIsbn.AutoSize = true;
            this.LblIsbn.Location = new System.Drawing.Point(103, 53);
            this.LblIsbn.Name = "LblIsbn";
            this.LblIsbn.Size = new System.Drawing.Size(27, 13);
            this.LblIsbn.TabIndex = 2;
            this.LblIsbn.Text = "Isbn";
            // 
            // LblAutor
            // 
            this.LblAutor.AutoSize = true;
            this.LblAutor.Location = new System.Drawing.Point(98, 227);
            this.LblAutor.Name = "LblAutor";
            this.LblAutor.Size = new System.Drawing.Size(32, 13);
            this.LblAutor.TabIndex = 14;
            this.LblAutor.Text = "Autor";
            // 
            // LblTitulo
            // 
            this.LblTitulo.AutoSize = true;
            this.LblTitulo.Location = new System.Drawing.Point(95, 82);
            this.LblTitulo.Name = "LblTitulo";
            this.LblTitulo.Size = new System.Drawing.Size(33, 13);
            this.LblTitulo.TabIndex = 4;
            this.LblTitulo.Text = "Titulo";
            // 
            // LblCodigo
            // 
            this.LblCodigo.AutoSize = true;
            this.LblCodigo.Location = new System.Drawing.Point(90, 23);
            this.LblCodigo.Name = "LblCodigo";
            this.LblCodigo.Size = new System.Drawing.Size(40, 13);
            this.LblCodigo.TabIndex = 0;
            this.LblCodigo.Text = "Código";
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Location = new System.Drawing.Point(460, 401);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(130, 32);
            this.BtnCancelar.TabIndex = 2;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // BtnAceptar
            // 
            this.BtnAceptar.Location = new System.Drawing.Point(164, 401);
            this.BtnAceptar.Name = "BtnAceptar";
            this.BtnAceptar.Size = new System.Drawing.Size(130, 32);
            this.BtnAceptar.TabIndex = 1;
            this.BtnAceptar.Text = "Aceptar";
            this.BtnAceptar.UseVisualStyleBackColor = true;
            this.BtnAceptar.Click += new System.EventHandler(this.BtnAceptar_Click);
            // 
            // lblGenero
            // 
            this.lblGenero.AutoSize = true;
            this.lblGenero.Location = new System.Drawing.Point(88, 320);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(42, 13);
            this.lblGenero.TabIndex = 20;
            this.lblGenero.Text = "Genero";
            // 
            // cboGenero
            // 
            this.cboGenero.FormattingEnabled = true;
            this.cboGenero.Location = new System.Drawing.Point(157, 317);
            this.cboGenero.Name = "cboGenero";
            this.cboGenero.Size = new System.Drawing.Size(203, 21);
            this.cboGenero.TabIndex = 21;
            // 
            // FrmDetais
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 453);
            this.Controls.Add(this.GrbDetalles);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnAceptar);
            this.Name = "FrmDetais";
            this.Text = "FrmDetalles";
            this.Load += new System.EventHandler(this.FrmDetalles_Load);
            this.GrbDetalles.ResumeLayout(false);
            this.GrbDetalles.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GrbDetalles;
        private System.Windows.Forms.TextBox TxtPrecio;
        private System.Windows.Forms.Label LblPrecio;
        private System.Windows.Forms.DateTimePicker DtpFecha;
        private System.Windows.Forms.ComboBox CboAutor;
        private System.Windows.Forms.TextBox TxtTitulo;
        private System.Windows.Forms.TextBox TxtCodigo;
        private System.Windows.Forms.Label LblFecha;
        private System.Windows.Forms.Label LblIsbn;
        private System.Windows.Forms.Label LblAutor;
        private System.Windows.Forms.Label LblTitulo;
        private System.Windows.Forms.Label LblCodigo;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button BtnAceptar;
        private System.Windows.Forms.TextBox TxtIsbn;
        private System.Windows.Forms.Label LblDescripcion;
        private System.Windows.Forms.Label LblStock;
        private System.Windows.Forms.Label LblEditorial;
        private System.Windows.Forms.Label LblIdioma;
        private System.Windows.Forms.TextBox TxtStock;
        private System.Windows.Forms.TextBox TxtDescripcion;
        private System.Windows.Forms.ComboBox CboEditorial;
        private System.Windows.Forms.ComboBox CboIdioma;
        private System.Windows.Forms.ComboBox cboGenero;
        private System.Windows.Forms.Label lblGenero;
    }
}