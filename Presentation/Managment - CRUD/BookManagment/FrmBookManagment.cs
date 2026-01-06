
using Library_WinForms.Data;
using Library_WinForms.Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Library_WinForms.Domain.Entities;
using Library_WinForms.Domain.DTOs;

namespace Library_WinForms.Presentation
{
    public partial class FrmBookManagment : Form
    {
        BookManagmentService oServicioBook;
        AuthorManagmentService oServicioAuthor;

        //Modo modo;
        public FrmBookManagment()
        {
            InitializeComponent();
            oServicioBook = new BookManagmentService();
            oServicioAuthor = new AuthorManagmentService();
        }

        private void CargarCombo(ComboBox combo)
        {
            List<Author> authors = oServicioAuthor.GetAuthor();

            authors.Insert(0, new Author { Code = -1, Name = "-- Seleccionar --", Surname = "" });

            combo.DataSource = authors;
            combo.DisplayMember = "FullName";
            combo.ValueMember = "Code";
            combo.DropDownStyle = ComboBoxStyle.DropDownList;
            combo.SelectedIndex = 0;
        }

        // -------------------------------------------------------  EVENT SECTION --------------------------------------------------------------//

        private void FrmLibros_Load(object sender, EventArgs e)
        {
            CargarCombo(CboAutor);
            ChkTodos.Checked = true;
        }

        // QUERY BUTTON
        private void BtnConsultar_Click(object sender, EventArgs e)
        {
            AuthorDTORecomended oFilter = null;
            if (!ChkTodos.Checked)
            {
                oFilter = new AuthorDTORecomended();
                if (!string.IsNullOrEmpty(TxtTitulo.Text))
                    oFilter.Title = TxtTitulo.Text;
                if (CboAutor.SelectedIndex != 0)
                    oFilter.Author = ((Author)CboAutor.SelectedItem).Code;
            }

            //Cargar la grilla con los datos de la lista de libros
            List<BookDTO> lista = oServicioBook.GetBooks(oFilter);

            DgvLibros.Rows.Clear();
            foreach (BookDTO L in lista)
            {
                DgvLibros.Rows.Add(L.Code, L.Title, L.Author);
            }
        }
        private void ChkTodos_CheckedChanged(object sender, EventArgs e)
        {
            TxtTitulo.Enabled = !ChkTodos.Checked;
            CboAutor.Enabled = !ChkTodos.Checked;
        }

        // BOTON NUEVO
        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            string tituloForm = "Agregar un libro";
            FrmBookTransaction fd = new FrmBookTransaction(Modo.NUEVO, tituloForm);
            fd.ShowDialog();
            //actualiza la grilla
            if (DgvLibros.Rows.Count > 0)
            {
                BtnConsultar_Click(null, null);
            }
        }
        private void DgvLibros_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            // Usar índice 0 para el cod_libro del libro
            int idLibro = Convert.ToInt32(DgvLibros.Rows[e.RowIndex].Cells[0].Value);

            Book libro = oServicioBook.GetBookById(idLibro);

            // Ver qué columna fue clickeada
            string nombreColumna = DgvLibros.Columns[e.ColumnIndex].Name;

            if (nombreColumna == "ColVer")
            {
                FrmBookTransaction frm = new FrmBookTransaction(Modo.VER, libro);
                frm.ShowDialog();
            }
            else if (nombreColumna == "ColBorrar")
            {
                DialogResult result = MessageBox.Show("¿Estás seguro de que querés eliminar este libro?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    int filasBorradas = oServicioBook.DeleteBook(libro.Code);
                    if (filasBorradas > 0)
                        MessageBox.Show("Libro borrado exitosamente.");
                    else
                        MessageBox.Show("Error al intentar borrar el libro.");
                    //actualiza la grilla
                    BtnConsultar_Click(null, null);
                }
            }
        }

        // BOTON SALIR
        private void BtnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea Salir", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        // BOTON MODIFICAR
        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (DgvLibros.CurrentRow == null)
            {
                MessageBox.Show("Por favor, seleccione una fila antes de modificar.",
                                 "Atención",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Warning);
                return;
            }

            int codigoLibro = (int)(DgvLibros.CurrentRow.Cells[0].Value);
            string tituloForm = "Modificar libro";
            FrmBookTransaction fd = new FrmBookTransaction(Modo.EDITAR, codigoLibro, tituloForm);


            fd.ShowDialog();
            //actualiza la grilla
            BtnConsultar_Click(null, null);
        }
    }
}

