namespace Library_WinForms.Presentation
{
    partial class FrmAuthorTransaction
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
            this.GrvDetalles = new System.Windows.Forms.GroupBox();
            this.TxtSurname = new System.Windows.Forms.TextBox();
            this.LblApellido = new System.Windows.Forms.Label();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.TxtCodigo = new System.Windows.Forms.TextBox();
            this.LblNombre = new System.Windows.Forms.Label();
            this.LblCodigo = new System.Windows.Forms.Label();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnAceptar = new System.Windows.Forms.Button();
            this.lblSexo = new System.Windows.Forms.Label();
            this.lblNacionalidad = new System.Windows.Forms.Label();
            this.lblFechaNacimiento = new System.Windows.Forms.Label();
            this.CboNationality = new System.Windows.Forms.ComboBox();
            this.dtpBirthDate = new System.Windows.Forms.DateTimePicker();
            this.CboSexo = new System.Windows.Forms.ComboBox();
            this.GrvDetalles.SuspendLayout();
            this.SuspendLayout();
            // 
            // GrvDetalles
            // 
            this.GrvDetalles.Controls.Add(this.CboSexo);
            this.GrvDetalles.Controls.Add(this.dtpBirthDate);
            this.GrvDetalles.Controls.Add(this.CboNationality);
            this.GrvDetalles.Controls.Add(this.lblFechaNacimiento);
            this.GrvDetalles.Controls.Add(this.lblNacionalidad);
            this.GrvDetalles.Controls.Add(this.lblSexo);
            this.GrvDetalles.Controls.Add(this.TxtSurname);
            this.GrvDetalles.Controls.Add(this.LblApellido);
            this.GrvDetalles.Controls.Add(this.TxtName);
            this.GrvDetalles.Controls.Add(this.TxtCodigo);
            this.GrvDetalles.Controls.Add(this.LblNombre);
            this.GrvDetalles.Controls.Add(this.LblCodigo);
            this.GrvDetalles.Location = new System.Drawing.Point(41, 23);
            this.GrvDetalles.Name = "GrvDetalles";
            this.GrvDetalles.Size = new System.Drawing.Size(420, 267);
            this.GrvDetalles.TabIndex = 0;
            this.GrvDetalles.TabStop = false;
            this.GrvDetalles.Text = "Autor Detalles";
            // 
            // TxtSurname
            // 
            this.TxtSurname.Location = new System.Drawing.Point(156, 109);
            this.TxtSurname.Name = "TxtSurname";
            this.TxtSurname.Size = new System.Drawing.Size(200, 20);
            this.TxtSurname.TabIndex = 9;
            // 
            // LblApellido
            // 
            this.LblApellido.AutoSize = true;
            this.LblApellido.Location = new System.Drawing.Point(85, 112);
            this.LblApellido.Name = "LblApellido";
            this.LblApellido.Size = new System.Drawing.Size(44, 13);
            this.LblApellido.TabIndex = 8;
            this.LblApellido.Text = "Apellido";
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(156, 70);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(200, 20);
            this.TxtName.TabIndex = 5;
            // 
            // TxtCodigo
            // 
            this.TxtCodigo.Enabled = false;
            this.TxtCodigo.Location = new System.Drawing.Point(156, 33);
            this.TxtCodigo.Name = "TxtCodigo";
            this.TxtCodigo.Size = new System.Drawing.Size(200, 20);
            this.TxtCodigo.TabIndex = 1;
            // 
            // LblNombre
            // 
            this.LblNombre.AutoSize = true;
            this.LblNombre.Location = new System.Drawing.Point(85, 73);
            this.LblNombre.Name = "LblNombre";
            this.LblNombre.Size = new System.Drawing.Size(44, 13);
            this.LblNombre.TabIndex = 4;
            this.LblNombre.Text = "Nombre";
            // 
            // LblCodigo
            // 
            this.LblCodigo.AutoSize = true;
            this.LblCodigo.Location = new System.Drawing.Point(89, 36);
            this.LblCodigo.Name = "LblCodigo";
            this.LblCodigo.Size = new System.Drawing.Size(40, 13);
            this.LblCodigo.TabIndex = 0;
            this.LblCodigo.Text = "Código";
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Location = new System.Drawing.Point(331, 307);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(130, 32);
            this.BtnCancelar.TabIndex = 2;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // BtnAceptar
            // 
            this.BtnAceptar.Location = new System.Drawing.Point(41, 307);
            this.BtnAceptar.Name = "BtnAceptar";
            this.BtnAceptar.Size = new System.Drawing.Size(130, 32);
            this.BtnAceptar.TabIndex = 1;
            this.BtnAceptar.Text = "Aceptar";
            this.BtnAceptar.UseVisualStyleBackColor = true;
            this.BtnAceptar.Click += new System.EventHandler(this.BtnAceptar_Click);
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Location = new System.Drawing.Point(99, 148);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(31, 13);
            this.lblSexo.TabIndex = 10;
            this.lblSexo.Text = "Sexo";
            // 
            // lblNacionalidad
            // 
            this.lblNacionalidad.AutoSize = true;
            this.lblNacionalidad.Location = new System.Drawing.Point(61, 231);
            this.lblNacionalidad.Name = "lblNacionalidad";
            this.lblNacionalidad.Size = new System.Drawing.Size(69, 13);
            this.lblNacionalidad.TabIndex = 11;
            this.lblNacionalidad.Text = "Nacionalidad";
            // 
            // lblFechaNacimiento
            // 
            this.lblFechaNacimiento.AutoSize = true;
            this.lblFechaNacimiento.Location = new System.Drawing.Point(24, 187);
            this.lblFechaNacimiento.Name = "lblFechaNacimiento";
            this.lblFechaNacimiento.Size = new System.Drawing.Size(106, 13);
            this.lblFechaNacimiento.TabIndex = 12;
            this.lblFechaNacimiento.Text = "Fecha de nacimiento";
            // 
            // CboNationality
            // 
            this.CboNationality.FormattingEnabled = true;
            this.CboNationality.Location = new System.Drawing.Point(156, 228);
            this.CboNationality.Name = "CboNationality";
            this.CboNationality.Size = new System.Drawing.Size(200, 21);
            this.CboNationality.TabIndex = 14;
            // 
            // dtpBirthDate
            // 
            this.dtpBirthDate.Location = new System.Drawing.Point(156, 187);
            this.dtpBirthDate.Name = "dtpBirthDate";
            this.dtpBirthDate.Size = new System.Drawing.Size(200, 20);
            this.dtpBirthDate.TabIndex = 15;
            this.dtpBirthDate.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // CboSexo
            // 
            this.CboSexo.FormattingEnabled = true;
            this.CboSexo.Location = new System.Drawing.Point(156, 145);
            this.CboSexo.Name = "CboSexo";
            this.CboSexo.Size = new System.Drawing.Size(200, 21);
            this.CboSexo.TabIndex = 16;
            // 
            // FrmAuthorTransaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 351);
            this.Controls.Add(this.GrvDetalles);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnAceptar);
            this.Name = "FrmAuthorTransaction";
            this.Text = "Adiministrador Autores";
            this.Load += new System.EventHandler(this.FrmDetalles_Load);
            this.GrvDetalles.ResumeLayout(false);
            this.GrvDetalles.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GrvDetalles;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.TextBox TxtCodigo;
        private System.Windows.Forms.Label LblNombre;
        private System.Windows.Forms.Label LblCodigo;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button BtnAceptar;
        private System.Windows.Forms.Label LblApellido;
        private System.Windows.Forms.TextBox TxtSurname;
        private System.Windows.Forms.Label lblFechaNacimiento;
        private System.Windows.Forms.Label lblNacionalidad;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.ComboBox CboNationality;
        private System.Windows.Forms.DateTimePicker dtpBirthDate;
        private System.Windows.Forms.ComboBox CboSexo;
    }
}