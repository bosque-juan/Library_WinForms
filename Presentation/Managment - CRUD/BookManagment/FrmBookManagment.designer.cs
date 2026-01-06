namespace Library_WinForms.Presentation
{
    partial class FrmBookManagment
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.BtnNuevo = new System.Windows.Forms.Button();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.GrbCriterios = new System.Windows.Forms.GroupBox();
            this.DgvLibros = new System.Windows.Forms.DataGridView();
            this.ColCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTitulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColAutor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColVer = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ColBorrar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.CboAutor = new System.Windows.Forms.ComboBox();
            this.LblAutor = new System.Windows.Forms.Label();
            this.LblTitulo = new System.Windows.Forms.Label();
            this.TxtTitulo = new System.Windows.Forms.TextBox();
            this.ChkTodos = new System.Windows.Forms.CheckBox();
            this.BtnConsultar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.GrbCriterios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvLibros)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnNuevo
            // 
            this.BtnNuevo.Location = new System.Drawing.Point(12, 356);
            this.BtnNuevo.Name = "BtnNuevo";
            this.BtnNuevo.Size = new System.Drawing.Size(65, 49);
            this.BtnNuevo.TabIndex = 1;
            this.BtnNuevo.Text = "Nuevo";
            this.BtnNuevo.UseVisualStyleBackColor = true;
            this.BtnNuevo.Click += new System.EventHandler(this.BtnNuevo_Click);
            // 
            // BtnSalir
            // 
            this.BtnSalir.Location = new System.Drawing.Point(762, 358);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(65, 49);
            this.BtnSalir.TabIndex = 3;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.UseVisualStyleBackColor = true;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // GrbCriterios
            // 
            this.GrbCriterios.Controls.Add(this.DgvLibros);
            this.GrbCriterios.Controls.Add(this.CboAutor);
            this.GrbCriterios.Controls.Add(this.LblAutor);
            this.GrbCriterios.Controls.Add(this.LblTitulo);
            this.GrbCriterios.Controls.Add(this.TxtTitulo);
            this.GrbCriterios.Controls.Add(this.ChkTodos);
            this.GrbCriterios.Controls.Add(this.BtnConsultar);
            this.GrbCriterios.Location = new System.Drawing.Point(12, 26);
            this.GrbCriterios.Name = "GrbCriterios";
            this.GrbCriterios.Size = new System.Drawing.Size(815, 324);
            this.GrbCriterios.TabIndex = 0;
            this.GrbCriterios.TabStop = false;
            this.GrbCriterios.Text = "Criterios";
            // 
            // DgvLibros
            // 
            this.DgvLibros.AllowUserToAddRows = false;
            this.DgvLibros.AllowUserToDeleteRows = false;
            this.DgvLibros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvLibros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColCodigo,
            this.ColTitulo,
            this.ColAutor,
            this.ColVer,
            this.ColBorrar});
            this.DgvLibros.Location = new System.Drawing.Point(6, 145);
            this.DgvLibros.Name = "DgvLibros";
            this.DgvLibros.ReadOnly = true;
            this.DgvLibros.RowHeadersWidth = 51;
            this.DgvLibros.RowTemplate.Height = 24;
            this.DgvLibros.Size = new System.Drawing.Size(804, 150);
            this.DgvLibros.TabIndex = 6;
            this.DgvLibros.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvLibros_CellClick);
            // 
            // ColCodigo
            // 
            this.ColCodigo.HeaderText = "Código";
            this.ColCodigo.MinimumWidth = 6;
            this.ColCodigo.Name = "ColCodigo";
            this.ColCodigo.ReadOnly = true;
            this.ColCodigo.Visible = false;
            this.ColCodigo.Width = 125;
            // 
            // ColTitulo
            // 
            this.ColTitulo.HeaderText = "Titulo";
            this.ColTitulo.MinimumWidth = 6;
            this.ColTitulo.Name = "ColTitulo";
            this.ColTitulo.ReadOnly = true;
            this.ColTitulo.Width = 250;
            // 
            // ColAutor
            // 
            this.ColAutor.HeaderText = "Autor";
            this.ColAutor.MinimumWidth = 6;
            this.ColAutor.Name = "ColAutor";
            this.ColAutor.ReadOnly = true;
            this.ColAutor.Width = 150;
            // 
            // ColVer
            // 
            this.ColVer.HeaderText = "Ver";
            this.ColVer.MinimumWidth = 6;
            this.ColVer.Name = "ColVer";
            this.ColVer.ReadOnly = true;
            this.ColVer.Text = "Ver";
            this.ColVer.UseColumnTextForButtonValue = true;
            this.ColVer.Width = 125;
            // 
            // ColBorrar
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            this.ColBorrar.DefaultCellStyle = dataGridViewCellStyle2;
            this.ColBorrar.HeaderText = "Borrar";
            this.ColBorrar.MinimumWidth = 6;
            this.ColBorrar.Name = "ColBorrar";
            this.ColBorrar.ReadOnly = true;
            this.ColBorrar.Text = "Borrar";
            this.ColBorrar.UseColumnTextForButtonValue = true;
            this.ColBorrar.Width = 125;
            // 
            // CboAutor
            // 
            this.CboAutor.FormattingEnabled = true;
            this.CboAutor.Location = new System.Drawing.Point(125, 73);
            this.CboAutor.Name = "CboAutor";
            this.CboAutor.Size = new System.Drawing.Size(253, 21);
            this.CboAutor.TabIndex = 3;
            // 
            // LblAutor
            // 
            this.LblAutor.AutoSize = true;
            this.LblAutor.Location = new System.Drawing.Point(49, 76);
            this.LblAutor.Name = "LblAutor";
            this.LblAutor.Size = new System.Drawing.Size(32, 13);
            this.LblAutor.TabIndex = 2;
            this.LblAutor.Text = "Autor";
            // 
            // LblTitulo
            // 
            this.LblTitulo.AutoSize = true;
            this.LblTitulo.Location = new System.Drawing.Point(38, 33);
            this.LblTitulo.Name = "LblTitulo";
            this.LblTitulo.Size = new System.Drawing.Size(36, 13);
            this.LblTitulo.TabIndex = 0;
            this.LblTitulo.Text = "Titulo:";
            // 
            // TxtTitulo
            // 
            this.TxtTitulo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtTitulo.Location = new System.Drawing.Point(125, 34);
            this.TxtTitulo.Name = "TxtTitulo";
            this.TxtTitulo.Size = new System.Drawing.Size(253, 13);
            this.TxtTitulo.TabIndex = 1;
            // 
            // ChkTodos
            // 
            this.ChkTodos.AutoSize = true;
            this.ChkTodos.Location = new System.Drawing.Point(125, 112);
            this.ChkTodos.Name = "ChkTodos";
            this.ChkTodos.Size = new System.Drawing.Size(56, 17);
            this.ChkTodos.TabIndex = 4;
            this.ChkTodos.Text = "Todos";
            this.ChkTodos.UseVisualStyleBackColor = true;
            this.ChkTodos.CheckedChanged += new System.EventHandler(this.ChkTodos_CheckedChanged);
            // 
            // BtnConsultar
            // 
            this.BtnConsultar.Location = new System.Drawing.Point(680, 103);
            this.BtnConsultar.Name = "BtnConsultar";
            this.BtnConsultar.Size = new System.Drawing.Size(131, 36);
            this.BtnConsultar.TabIndex = 5;
            this.BtnConsultar.Text = "Consultar";
            this.BtnConsultar.UseVisualStyleBackColor = true;
            this.BtnConsultar.Click += new System.EventHandler(this.BtnConsultar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(91, 356);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(65, 49);
            this.btnModificar.TabIndex = 2;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // FrmLibros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 462);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.BtnNuevo);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.GrbCriterios);
            this.Name = "FrmLibros";
            this.Text = "Libros";
            this.Load += new System.EventHandler(this.FrmLibros_Load);
            this.GrbCriterios.ResumeLayout(false);
            this.GrbCriterios.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvLibros)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button BtnNuevo;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.GroupBox GrbCriterios;
        private System.Windows.Forms.DataGridView DgvLibros;
        private System.Windows.Forms.ComboBox CboAutor;
        private System.Windows.Forms.Label LblAutor;
        private System.Windows.Forms.Label LblTitulo;
        private System.Windows.Forms.TextBox TxtTitulo;
        private System.Windows.Forms.CheckBox ChkTodos;
        private System.Windows.Forms.Button BtnConsultar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTitulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColAutor;
        private System.Windows.Forms.DataGridViewButtonColumn ColVer;
        private System.Windows.Forms.DataGridViewButtonColumn ColBorrar;
    }
}

