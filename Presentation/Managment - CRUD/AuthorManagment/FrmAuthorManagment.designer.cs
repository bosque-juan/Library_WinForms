namespace Library_WinForms.Presentation
{
    partial class FrmAuthorManagment
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
            this.BtnNuevo = new System.Windows.Forms.Button();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.GrbCriterios = new System.Windows.Forms.GroupBox();
            this.txtAutor = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.DgvAuthor = new System.Windows.Forms.DataGridView();
            this.ColCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColApellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColView = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ColDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.LblAutor = new System.Windows.Forms.Label();
            this.LblTitulo = new System.Windows.Forms.Label();
            this.ChkTodos = new System.Windows.Forms.CheckBox();
            this.BtnConsultar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.GrbCriterios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvAuthor)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnNuevo
            // 
            this.BtnNuevo.Location = new System.Drawing.Point(40, 366);
            this.BtnNuevo.Name = "BtnNuevo";
            this.BtnNuevo.Size = new System.Drawing.Size(65, 49);
            this.BtnNuevo.TabIndex = 1;
            this.BtnNuevo.Text = "Nuevo";
            this.BtnNuevo.UseVisualStyleBackColor = true;
            this.BtnNuevo.Click += new System.EventHandler(this.BtnNuevo_Click);
            // 
            // BtnSalir
            // 
            this.BtnSalir.Location = new System.Drawing.Point(372, 366);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(65, 49);
            this.BtnSalir.TabIndex = 3;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.UseVisualStyleBackColor = true;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // GrbCriterios
            // 
            this.GrbCriterios.Controls.Add(this.txtAutor);
            this.GrbCriterios.Controls.Add(this.txtCodigo);
            this.GrbCriterios.Controls.Add(this.DgvAuthor);
            this.GrbCriterios.Controls.Add(this.LblAutor);
            this.GrbCriterios.Controls.Add(this.LblTitulo);
            this.GrbCriterios.Controls.Add(this.ChkTodos);
            this.GrbCriterios.Controls.Add(this.BtnConsultar);
            this.GrbCriterios.Location = new System.Drawing.Point(12, 26);
            this.GrbCriterios.Name = "GrbCriterios";
            this.GrbCriterios.Size = new System.Drawing.Size(463, 324);
            this.GrbCriterios.TabIndex = 0;
            this.GrbCriterios.TabStop = false;
            this.GrbCriterios.Text = "Autores";
            // 
            // txtAutor
            // 
            this.txtAutor.Location = new System.Drawing.Point(114, 69);
            this.txtAutor.Name = "txtAutor";
            this.txtAutor.Size = new System.Drawing.Size(145, 20);
            this.txtAutor.TabIndex = 8;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(114, 30);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(145, 20);
            this.txtCodigo.TabIndex = 7;
            // 
            // DgvAuthor
            // 
            this.DgvAuthor.AllowUserToAddRows = false;
            this.DgvAuthor.AllowUserToDeleteRows = false;
            this.DgvAuthor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvAuthor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColCodigo,
            this.ColNombre,
            this.ColApellido,
            this.ColView,
            this.ColDelete});
            this.DgvAuthor.Location = new System.Drawing.Point(28, 158);
            this.DgvAuthor.Name = "DgvAuthor";
            this.DgvAuthor.ReadOnly = true;
            this.DgvAuthor.RowHeadersWidth = 51;
            this.DgvAuthor.RowTemplate.Height = 24;
            this.DgvAuthor.Size = new System.Drawing.Size(397, 150);
            this.DgvAuthor.TabIndex = 6;
            this.DgvAuthor.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvAuthor_CellContentClick);
            // 
            // ColCodigo
            // 
            this.ColCodigo.FillWeight = 45F;
            this.ColCodigo.HeaderText = "Código";
            this.ColCodigo.MinimumWidth = 6;
            this.ColCodigo.Name = "ColCodigo";
            this.ColCodigo.ReadOnly = true;
            this.ColCodigo.Width = 45;
            // 
            // ColNombre
            // 
            this.ColNombre.FillWeight = 80F;
            this.ColNombre.HeaderText = "Nombre";
            this.ColNombre.MinimumWidth = 6;
            this.ColNombre.Name = "ColNombre";
            this.ColNombre.ReadOnly = true;
            this.ColNombre.Width = 80;
            // 
            // ColApellido
            // 
            this.ColApellido.FillWeight = 80F;
            this.ColApellido.HeaderText = "Apellido";
            this.ColApellido.Name = "ColApellido";
            this.ColApellido.ReadOnly = true;
            this.ColApellido.Width = 80;
            // 
            // ColView
            // 
            this.ColView.FillWeight = 60F;
            this.ColView.HeaderText = "Ver";
            this.ColView.Name = "ColView";
            this.ColView.ReadOnly = true;
            this.ColView.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColView.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ColView.Text = "Ver";
            this.ColView.UseColumnTextForButtonValue = true;
            this.ColView.Width = 60;
            // 
            // ColDelete
            // 
            this.ColDelete.FillWeight = 60F;
            this.ColDelete.HeaderText = "Borrar";
            this.ColDelete.Name = "ColDelete";
            this.ColDelete.ReadOnly = true;
            this.ColDelete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColDelete.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ColDelete.Text = "Borrar";
            this.ColDelete.UseColumnTextForButtonValue = true;
            this.ColDelete.Width = 60;
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
            this.LblTitulo.Size = new System.Drawing.Size(40, 13);
            this.LblTitulo.TabIndex = 0;
            this.LblTitulo.Text = "Codigo";
            // 
            // ChkTodos
            // 
            this.ChkTodos.AutoSize = true;
            this.ChkTodos.Location = new System.Drawing.Point(28, 128);
            this.ChkTodos.Name = "ChkTodos";
            this.ChkTodos.Size = new System.Drawing.Size(56, 17);
            this.ChkTodos.TabIndex = 4;
            this.ChkTodos.Text = "Todos";
            this.ChkTodos.UseVisualStyleBackColor = true;
            this.ChkTodos.CheckedChanged += new System.EventHandler(this.ChkTodos_CheckedChanged);
            // 
            // BtnConsultar
            // 
            this.BtnConsultar.Location = new System.Drawing.Point(294, 109);
            this.BtnConsultar.Name = "BtnConsultar";
            this.BtnConsultar.Size = new System.Drawing.Size(131, 36);
            this.BtnConsultar.TabIndex = 5;
            this.BtnConsultar.Text = "Consultar";
            this.BtnConsultar.UseVisualStyleBackColor = true;
            this.BtnConsultar.Click += new System.EventHandler(this.BtnConsultar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(157, 366);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(65, 49);
            this.btnModificar.TabIndex = 2;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // FrmAuthorManagment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 462);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.BtnNuevo);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.GrbCriterios);
            this.Name = "FrmAuthorManagment";
            this.Text = "Administrador Autores";
            this.Load += new System.EventHandler(this.FrmLibros_Load);
            this.GrbCriterios.ResumeLayout(false);
            this.GrbCriterios.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvAuthor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button BtnNuevo;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.GroupBox GrbCriterios;
        private System.Windows.Forms.DataGridView DgvAuthor;
        private System.Windows.Forms.Label LblAutor;
        private System.Windows.Forms.Label LblTitulo;
        private System.Windows.Forms.CheckBox ChkTodos;
        private System.Windows.Forms.Button BtnConsultar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.TextBox txtAutor;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColApellido;
        private System.Windows.Forms.DataGridViewButtonColumn ColView;
        private System.Windows.Forms.DataGridViewButtonColumn ColDelete;
    }
}

