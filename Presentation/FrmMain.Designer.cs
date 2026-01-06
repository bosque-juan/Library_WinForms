namespace Library_WinForms.Presentation
{
    partial class FrmMain
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.Crud_Managment_ToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.BookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AuthorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PublisherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AnaliticsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SalesReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RestockingBooksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SuggestedBooksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SystemGoalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.Crud_Managment_ToolStrip,
            this.AnaliticsToolStripMenuItem,
            this.AboutToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip.Size = new System.Drawing.Size(886, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.archivoToolStripMenuItem.Text = "Menu";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(96, 22);
            this.toolStripMenuItem1.Text = "Salir";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // Crud_Managment_ToolStrip
            // 
            this.Crud_Managment_ToolStrip.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BookToolStripMenuItem,
            this.AuthorToolStripMenuItem,
            this.PublisherToolStripMenuItem});
            this.Crud_Managment_ToolStrip.Name = "Crud_Managment_ToolStrip";
            this.Crud_Managment_ToolStrip.Size = new System.Drawing.Size(96, 20);
            this.Crud_Managment_ToolStrip.Text = "Gestión ABMC";
            // 
            // BookToolStripMenuItem
            // 
            this.BookToolStripMenuItem.Name = "BookToolStripMenuItem";
            this.BookToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.BookToolStripMenuItem.Text = "Libros";
            this.BookToolStripMenuItem.Click += new System.EventHandler(this.BookManagmentToolStripMenuItem_Click);
            // 
            // AuthorToolStripMenuItem
            // 
            this.AuthorToolStripMenuItem.Name = "AuthorToolStripMenuItem";
            this.AuthorToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.AuthorToolStripMenuItem.Text = "Autores";
            this.AuthorToolStripMenuItem.Click += new System.EventHandler(this.AuthorToolStripMenuItem_Click);
            // 
            // PublisherToolStripMenuItem
            // 
            this.PublisherToolStripMenuItem.Name = "PublisherToolStripMenuItem";
            this.PublisherToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.PublisherToolStripMenuItem.Text = "Editoriales";
            this.PublisherToolStripMenuItem.Click += new System.EventHandler(this.editorialesToolStripMenuItem_Click);
            // 
            // AnaliticsToolStripMenuItem
            // 
            this.AnaliticsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SalesReportToolStripMenuItem,
            this.RestockingBooksToolStripMenuItem,
            this.SuggestedBooksToolStripMenuItem});
            this.AnaliticsToolStripMenuItem.Name = "AnaliticsToolStripMenuItem";
            this.AnaliticsToolStripMenuItem.Size = new System.Drawing.Size(108, 20);
            this.AnaliticsToolStripMenuItem.Text = "Analisis de Datos";
            // 
            // SalesReportToolStripMenuItem
            // 
            this.SalesReportToolStripMenuItem.Name = "SalesReportToolStripMenuItem";
            this.SalesReportToolStripMenuItem.ShowShortcutKeys = false;
            this.SalesReportToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.SalesReportToolStripMenuItem.Text = "Reporte de Ventas";
            this.SalesReportToolStripMenuItem.Click += new System.EventHandler(this.SalesReportToolStripMenuItem_Click);
            // 
            // RestockingBooksToolStripMenuItem
            // 
            this.RestockingBooksToolStripMenuItem.Name = "RestockingBooksToolStripMenuItem";
            this.RestockingBooksToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.RestockingBooksToolStripMenuItem.Text = "Libros para reabastecer";
            this.RestockingBooksToolStripMenuItem.Click += new System.EventHandler(this.RestockingBooksToolStripMenuItem_Click);
            // 
            // SuggestedBooksToolStripMenuItem
            // 
            this.SuggestedBooksToolStripMenuItem.Name = "SuggestedBooksToolStripMenuItem";
            this.SuggestedBooksToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.SuggestedBooksToolStripMenuItem.Text = "Libros recomendados";
            this.SuggestedBooksToolStripMenuItem.Click += new System.EventHandler(this.SuggestedBooksToolStripMenuItem_Click);
            // 
            // AboutToolStripMenuItem
            // 
            this.AboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SystemGoalToolStripMenuItem});
            this.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem";
            this.AboutToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.AboutToolStripMenuItem.Text = "Acerca de...";
            // 
            // SystemGoalToolStripMenuItem
            // 
            this.SystemGoalToolStripMenuItem.Name = "SystemGoalToolStripMenuItem";
            this.SystemGoalToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.SystemGoalToolStripMenuItem.Text = "Objetivos del sistema";
            this.SystemGoalToolStripMenuItem.Click += new System.EventHandler(this.SystemGolToolStripMenuItem_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Library_WinForms.Properties.Resources.library_background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(886, 497);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "FrmMain";
            this.Text = "App - Administrador de Libreria";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Crud_Managment_ToolStrip;
        private System.Windows.Forms.ToolStripMenuItem BookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AnaliticsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem SalesReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RestockingBooksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SuggestedBooksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SystemGoalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AuthorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PublisherToolStripMenuItem;
    }
}