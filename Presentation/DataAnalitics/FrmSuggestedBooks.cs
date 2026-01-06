using Library_WinForms.Business;
using Library_WinForms.Data;
using Library_WinForms.Domain.DTOs;
using Library_WinForms.Domain.Entities;
using Library_WinForms.Servicio.VentasRealizadas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_WinForms.Presentation
{
    public partial class FrmSuggestedBooks : Form
    {
        BookManagmentService oBookService;
        SuggestedBookService oSuggestedBook;
        public FrmSuggestedBooks()
        {
            InitializeComponent();
            oBookService = new BookManagmentService();
            oSuggestedBook = new SuggestedBookService();
        }

        private void FrmSuggestedBooks_Load(object sender, EventArgs e)
        {
            LoadComboGenre();
            LoadComboTo();
            LoadComboFrom();
        }

        private void LoadComboTo()
        {
            List<int> year = oBookService.GetBookYears();
            CboHasta.DataSource = year;
            CboHasta.SelectedIndex = -1;
            CboHasta.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        private void LoadComboFrom()
        {
            List<int> year = oBookService.GetBookYears();
            CboDesde.DataSource = year;
            CboDesde.SelectedIndex = -1;
            CboDesde.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void LoadComboGenre()
        {
            List<Genre> genreList = oBookService.GetBookGenres();
            cboGenero.ValueMember = "IdGender";
            cboGenero.DisplayMember = "genre";
            cboGenero.DataSource = genreList;
            cboGenero.SelectedIndex = -1;
            cboGenero.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            AuthorDTORecomended oFilter = new AuthorDTORecomended();
            if (cboGenero.SelectedIndex != -1)
            {
                oFilter.Genre = ((Genre)cboGenero.SelectedItem).IdGenre;
            }
            else { MessageBox.Show("Por favor seleccionar genero.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }

            if (CboDesde.SelectedIndex != -1 || CboHasta.SelectedIndex != -1)
            {
                oFilter.From = Convert.ToInt32(CboDesde.SelectedItem);
                oFilter.To = Convert.ToInt32(CboHasta.SelectedItem);
                if (oFilter.From > oFilter.To)
                {
                    MessageBox.Show("El año desde debe ser menor o igual al año hasta.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            else { MessageBox.Show("Por favor seleccionar año desde y hasta.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }

            List<BookDTO> list = oSuggestedBook.GetSuggestedBooks(oFilter);
            dgvConsulta3.Rows.Clear();
            foreach (BookDTO C in list)
            {
                dgvConsulta3.Rows.Add(C.Code, C.Title, C.RealeseDate.ToString("yyyy-MM-dd"), C.Price, C.Stock, C.Author, C.Gender);
            }
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea Salir", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
