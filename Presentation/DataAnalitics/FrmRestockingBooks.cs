using Library_WinForms.Business;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Library_WinForms.Servicio.VentasRealizadas;
using Library_WinForms.Domain.Entities;
using Library_WinForms.Domain.DTOs;

namespace Library_WinForms.Presentation
{
    public partial class FrmRestockingBooks : Form
    {
        RestockingBookService _stockingBookService;
        BookManagmentService RestockingBooksService;
        public FrmRestockingBooks()
        {
            InitializeComponent();
            RestockingBooksService = new BookManagmentService();
            _stockingBookService = new RestockingBookService();
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Terminó de consultar?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes) this.Close();
        }
        private void FrmConsulta2_Load(object sender, EventArgs e)
        {
            CargarComboGeneros();
        }
        private void CargarComboGeneros()
        {
            List<Genre> listaGeneros = RestockingBooksService.GetBookGenres();


            cboGenero.ValueMember = "IdGenre";
            cboGenero.DisplayMember = "genre";
            cboGenero.DataSource = listaGeneros;

            cboGenero.SelectedIndex = -1;
            cboGenero.DropDownStyle = ComboBoxStyle.DropDownList;

        }
        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (!chkTodos.Checked && string.IsNullOrEmpty(txtTitulo.Text) && cboGenero.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor marcar al menos un Filter.",
                                "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            List<Book> lista;

            if (chkTodos.Checked)
            {
                lista = _stockingBookService.GetBooksForStocking(null);
            }
            else
            {
                AuthorDTORecomended oFilter = new AuthorDTORecomended();

                if (!string.IsNullOrEmpty(txtTitulo.Text))
                    oFilter.Title = txtTitulo.Text;

                if (cboGenero.SelectedIndex > -1)
                    oFilter.Genre = (int)cboGenero.SelectedValue;

                lista = _stockingBookService.GetBooksForStocking(oFilter);
            }

            dgvConsulta2.DataSource = lista;

            dgvConsulta2.Columns["Code"].Visible = false;
            dgvConsulta2.Columns["ReleaseDAte"].Visible = false;
            dgvConsulta2.Columns["Description"].Visible = false;
            dgvConsulta2.Columns["_Editorial"].Visible = false;
            dgvConsulta2.Columns["Languaje"].Visible = false;
            dgvConsulta2.Columns["Author"].Visible = false;
        }
        private void chkTodos_CheckedChanged(object sender, EventArgs e)
        {
            bool estaMarcado = chkTodos.Checked;

            txtTitulo.Enabled = !estaMarcado;
            cboGenero.Enabled = !estaMarcado;
        }
    }
}


