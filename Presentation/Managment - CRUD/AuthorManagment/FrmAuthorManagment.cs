
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
using Library_WinForms.Domain.DTOs;
using Library_WinForms.Domain.Entities;

namespace Library_WinForms.Presentation
{
    public partial class FrmAuthorManagment : Form
    {
        AuthorManagmentService oServicio;
        //Modo modo;
        public FrmAuthorManagment()
        {
            InitializeComponent();
            oServicio = new AuthorManagmentService();
        }



        // -------------------------------------------------------  EVENT SECTION --------------------------------------------------------------//

        private void FrmLibros_Load(object sender, EventArgs e)
        {
            //ChkTodos.Checked = true;
        }

        // QUERY BUTTON
        private void BtnConsultar_Click(object sender, EventArgs e)
        {
            AuthorDTORecomended filter = null;

            if (!ChkTodos.Checked)
            {
                filter = new AuthorDTORecomended();

                if (int.TryParse(txtCodigo.Text, out int codigo))
                    filter.Code = codigo;

                filter.AuthorName = txtAutor.Text.Trim();
            }

            List<Author> authors = oServicio.GetAuthorByFilter(filter);

            DgvAuthor.Rows.Clear();

            foreach (Author a in authors)
            {
                DgvAuthor.Rows.Add(a.Code, a.Name, a.Surname);
            }

            if (authors.Count == 0)
                MessageBox.Show("No se encontraron autores.");
        }
        private void ChkTodos_CheckedChanged(object sender, EventArgs e)
        {
            txtCodigo.Enabled = !ChkTodos.Checked;
            txtAutor.Enabled = !ChkTodos.Checked;
        }

        // BOTON NUEVO
        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            string formLabel = "Crear un autor";
            FrmPublisherTransaction fd = new FrmPublisherTransaction(Modo.NUEVO, formLabel);
            fd.ShowDialog();
            if (DgvAuthor.Rows.Count > 0)
            {
                BtnConsultar_Click(null, null);
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
            if (DgvAuthor.CurrentRow == null)
            {
                MessageBox.Show("Por favor, seleccione una fila antes de modificar.",
                                 "Atención",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Warning);
                return;
            }

            int authorCode = (int)(DgvAuthor.CurrentRow.Cells[0].Value);
            string tituloForm = "Modificar autor";
            FrmAuthorTransaction fd = new FrmAuthorTransaction(Modo.EDITAR, authorCode, tituloForm);


            fd.ShowDialog();
            //actualiza la grilla
            BtnConsultar_Click(null, null);
        }

        private void DgvAuthor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            // Usar índice 0 para el cod_libro del libro
            int idAutor = Convert.ToInt32(DgvAuthor.Rows[e.RowIndex].Cells[0].Value);

            Author author = oServicio.GetAuthorById(idAutor);

            // Ver qué columna fue clickeada
            string nombreColumna = DgvAuthor.Columns[e.ColumnIndex].Name;

            if (nombreColumna == "ColView")
            {
                FrmAuthorTransaction frmAuthor = new FrmAuthorTransaction(Modo.VER, author);
                frmAuthor.ShowDialog();
            }
            else if (nombreColumna == "ColDelete")
            {
                DialogResult result = MessageBox.Show("¿Estás seguro de que querés eliminar a este Autor?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    int filasBorradas = oServicio.DeleteAuthor(author.Code);
                    if (filasBorradas > 0)
                        MessageBox.Show("Autor borrado exitosamente.");
                    else
                        MessageBox.Show("Error al intentar borrar el libro.");
                    //actualiza la grilla
                    BtnConsultar_Click(null, null);
                }
            }
        }
    }
}

