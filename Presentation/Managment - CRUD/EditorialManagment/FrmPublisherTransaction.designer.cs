namespace Library_WinForms.Presentation
{
    partial class FrmPublisherTransaction
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
            this.TxtPublisher = new System.Windows.Forms.TextBox();
            this.TxtCode = new System.Windows.Forms.TextBox();
            this.LblPublisher = new System.Windows.Forms.Label();
            this.LblCodigo = new System.Windows.Forms.Label();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnAceptar = new System.Windows.Forms.Button();
            this.GrvDetalles.SuspendLayout();
            this.SuspendLayout();
            // 
            // GrvDetalles
            // 
            this.GrvDetalles.Controls.Add(this.TxtPublisher);
            this.GrvDetalles.Controls.Add(this.TxtCode);
            this.GrvDetalles.Controls.Add(this.LblPublisher);
            this.GrvDetalles.Controls.Add(this.LblCodigo);
            this.GrvDetalles.Location = new System.Drawing.Point(41, 23);
            this.GrvDetalles.Name = "GrvDetalles";
            this.GrvDetalles.Size = new System.Drawing.Size(420, 120);
            this.GrvDetalles.TabIndex = 0;
            this.GrvDetalles.TabStop = false;
            this.GrvDetalles.Text = "Editorial Detalle";
            // 
            // TxtPublisher
            // 
            this.TxtPublisher.Location = new System.Drawing.Point(156, 70);
            this.TxtPublisher.Name = "TxtPublisher";
            this.TxtPublisher.Size = new System.Drawing.Size(200, 20);
            this.TxtPublisher.TabIndex = 5;
            // 
            // TxtCode
            // 
            this.TxtCode.Enabled = false;
            this.TxtCode.Location = new System.Drawing.Point(156, 33);
            this.TxtCode.Name = "TxtCode";
            this.TxtCode.Size = new System.Drawing.Size(200, 20);
            this.TxtCode.TabIndex = 1;
            // 
            // LblPublisher
            // 
            this.LblPublisher.AutoSize = true;
            this.LblPublisher.Location = new System.Drawing.Point(85, 73);
            this.LblPublisher.Name = "LblPublisher";
            this.LblPublisher.Size = new System.Drawing.Size(44, 13);
            this.LblPublisher.TabIndex = 4;
            this.LblPublisher.Text = "Editorial";
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
            this.BtnCancelar.Location = new System.Drawing.Point(331, 173);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(130, 32);
            this.BtnCancelar.TabIndex = 2;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // BtnAceptar
            // 
            this.BtnAceptar.Location = new System.Drawing.Point(40, 173);
            this.BtnAceptar.Name = "BtnAceptar";
            this.BtnAceptar.Size = new System.Drawing.Size(130, 32);
            this.BtnAceptar.TabIndex = 1;
            this.BtnAceptar.Text = "Aceptar";
            this.BtnAceptar.UseVisualStyleBackColor = true;
            this.BtnAceptar.Click += new System.EventHandler(this.BtnAceptar_Click);
            // 
            // FrmPublisherTransaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 236);
            this.Controls.Add(this.GrvDetalles);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnAceptar);
            this.Name = "FrmPublisherTransaction";
            this.Text = "Adiministrador Editoriales";
            this.Load += new System.EventHandler(this.FrmDetalles_Load);
            this.GrvDetalles.ResumeLayout(false);
            this.GrvDetalles.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GrvDetalles;
        private System.Windows.Forms.TextBox TxtPublisher;
        private System.Windows.Forms.TextBox TxtCode;
        private System.Windows.Forms.Label LblPublisher;
        private System.Windows.Forms.Label LblCodigo;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button BtnAceptar;
    }
}