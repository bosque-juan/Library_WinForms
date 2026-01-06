namespace Library_WinForms.Presentation
{
    partial class FrmSystemGoal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSystemGoal));
            this.RtbObjetivoSistema = new System.Windows.Forms.RichTextBox();
            this.LblObjetiSistema = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // RtbObjetivoSistema
            // 
            this.RtbObjetivoSistema.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RtbObjetivoSistema.BackColor = System.Drawing.SystemColors.Menu;
            this.RtbObjetivoSistema.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RtbObjetivoSistema.Enabled = false;
            this.RtbObjetivoSistema.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RtbObjetivoSistema.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.RtbObjetivoSistema.HideSelection = false;
            this.RtbObjetivoSistema.Location = new System.Drawing.Point(30, 46);
            this.RtbObjetivoSistema.Name = "RtbObjetivoSistema";
            this.RtbObjetivoSistema.ReadOnly = true;
            this.RtbObjetivoSistema.Size = new System.Drawing.Size(870, 414);
            this.RtbObjetivoSistema.TabIndex = 0;
            this.RtbObjetivoSistema.Text = resources.GetString("RtbObjetivoSistema.Text");
            // 
            // LblObjetiSistema
            // 
            this.LblObjetiSistema.AutoSize = true;
            this.LblObjetiSistema.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblObjetiSistema.Location = new System.Drawing.Point(25, 25);
            this.LblObjetiSistema.Name = "LblObjetiSistema";
            this.LblObjetiSistema.Size = new System.Drawing.Size(443, 30);
            this.LblObjetiSistema.TabIndex = 1;
            this.LblObjetiSistema.Text = "Objetivos del sistema: Aministrador de Librería";
            // 
            // FrmSystemGoal
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(927, 484);
            this.Controls.Add(this.LblObjetiSistema);
            this.Controls.Add(this.RtbObjetivoSistema);
            this.Name = "FrmSystemGoal";
            this.Text = "FrmObjetivoSistema";
            this.Load += new System.EventHandler(this.FrmObjetivoSistema_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox RtbObjetivoSistema;
        private System.Windows.Forms.Label LblObjetiSistema;
    }
}