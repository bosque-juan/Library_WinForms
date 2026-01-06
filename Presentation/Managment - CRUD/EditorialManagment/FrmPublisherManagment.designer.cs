namespace Library_WinForms.Presentation
{
    partial class FrmPublisherManagment
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
            this.txtPublisher = new System.Windows.Forms.TextBox();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.DgvAuthor = new System.Windows.Forms.DataGridView();
            this.ColCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColPublisher = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColView = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ColDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.LblPublisher = new System.Windows.Forms.Label();
            this.LblCode = new System.Windows.Forms.Label();
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
            this.BtnSalir.Location = new System.Drawing.Point(294, 366);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(65, 49);
            this.BtnSalir.TabIndex = 3;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.UseVisualStyleBackColor = true;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // GrbCriterios
            // 
            this.GrbCriterios.Controls.Add(this.txtPublisher);
            this.GrbCriterios.Controls.Add(this.txtCode);
            this.GrbCriterios.Controls.Add(this.DgvAuthor);
            this.GrbCriterios.Controls.Add(this.LblPublisher);
            this.GrbCriterios.Controls.Add(this.LblCode);
            this.GrbCriterios.Controls.Add(this.ChkTodos);
            this.GrbCriterios.Controls.Add(this.BtnConsultar);
            this.GrbCriterios.Location = new System.Drawing.Point(12, 26);
            this.GrbCriterios.Name = "GrbCriterios";
            this.GrbCriterios.Size = new System.Drawing.Size(377, 324);
            this.GrbCriterios.TabIndex = 0;
            this.GrbCriterios.TabStop = false;
            this.GrbCriterios.Text = "Editoriales";
            // 
            // txtPublisher
            // 
            this.txtPublisher.Location = new System.Drawing.Point(114, 69);
            this.txtPublisher.Name = "txtPublisher";
            this.txtPublisher.Size = new System.Drawing.Size(145, 20);
            this.txtPublisher.TabIndex = 8;
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(114, 30);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(145, 20);
            this.txtCode.TabIndex = 7;
            // 
            // DgvAuthor
            // 
            this.DgvAuthor.AllowUserToAddRows = false;
            this.DgvAuthor.AllowUserToDeleteRows = false;
            this.DgvAuthor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvAuthor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColCodigo,
            this.ColPublisher,
            this.ColView,
            this.ColDelete});
            this.DgvAuthor.Location = new System.Drawing.Point(28, 158);
            this.DgvAuthor.Name = "DgvAuthor";
            this.DgvAuthor.ReadOnly = true;
            this.DgvAuthor.RowHeadersWidth = 51;
            this.DgvAuthor.RowTemplate.Height = 24;
            this.DgvAuthor.Size = new System.Drawing.Size(319, 150);
            this.DgvAuthor.TabIndex = 6;
            this.DgvAuthor.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvAuthor_CellContentClick);
            // 
            // ColCodigo
            // 
            this.ColCodigo.FillWeight = 45F;
            this.ColCodigo.HeaderText = "Codigo";
            this.ColCodigo.MinimumWidth = 6;
            this.ColCodigo.Name = "ColCodigo";
            this.ColCodigo.ReadOnly = true;
            this.ColCodigo.Width = 45;
            // 
            // ColPublisher
            // 
            this.ColPublisher.FillWeight = 80F;
            this.ColPublisher.HeaderText = "Editorial";
            this.ColPublisher.MinimumWidth = 6;
            this.ColPublisher.Name = "ColPublisher";
            this.ColPublisher.ReadOnly = true;
            this.ColPublisher.Width = 80;
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
            // LblPublisher
            // 
            this.LblPublisher.AutoSize = true;
            this.LblPublisher.Location = new System.Drawing.Point(49, 76);
            this.LblPublisher.Name = "LblPublisher";
            this.LblPublisher.Size = new System.Drawing.Size(44, 13);
            this.LblPublisher.TabIndex = 2;
            this.LblPublisher.Text = "Editorial";
            // 
            // LblCode
            // 
            this.LblCode.AutoSize = true;
            this.LblCode.Location = new System.Drawing.Point(53, 33);
            this.LblCode.Name = "LblCode";
            this.LblCode.Size = new System.Drawing.Size(40, 13);
            this.LblCode.TabIndex = 0;
            this.LblCode.Text = "Codigo";
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
            this.BtnConsultar.Location = new System.Drawing.Point(216, 109);
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
            // FrmPublisherManagment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 462);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.BtnNuevo);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.GrbCriterios);
            this.Name = "FrmPublisherManagment";
            this.Text = "Administrador Editoriales";
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
        private System.Windows.Forms.Label LblPublisher;
        private System.Windows.Forms.Label LblCode;
        private System.Windows.Forms.CheckBox ChkTodos;
        private System.Windows.Forms.Button BtnConsultar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.TextBox txtPublisher;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPublisher;
        private System.Windows.Forms.DataGridViewButtonColumn ColView;
        private System.Windows.Forms.DataGridViewButtonColumn ColDelete;
    }
}

