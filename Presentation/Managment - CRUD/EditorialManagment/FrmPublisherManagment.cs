
using Library_WinForms.Business;
using Library_WinForms.Data;
using System;
using System.Collections.Generic;
using Library_WinForms.Domain.Entities;
using System.Windows.Forms;

namespace Library_WinForms.Presentation
{
    public partial class FrmPublisherManagment : Form
    {
        PublisherManagmentService oServicio;
        //Modo modo;
        public FrmPublisherManagment()
        {
            InitializeComponent();
            oServicio = new PublisherManagmentService();
        }



        // -------------------------------------------------------  EVENT SECTION --------------------------------------------------------------//


        // QUERY BUTTON
        private void BtnConsultar_Click(object sender, EventArgs e)
        {
            List<Parameter> filter = null;

            if (!ChkTodos.Checked)
            {
                filter = new List<Parameter>();

                if (int.TryParse(txtCode.Text, out int codigo))
                    filter.Add(new Parameter("code", txtCode.Text.Trim()));
                filter.Add(new Parameter("publisher", txtPublisher.Text.Trim()));
            }

            List<Publisher> publishers = oServicio.GetPublisherByFilter(filter);

            DgvAuthor.Rows.Clear();

            foreach (Publisher publisher in publishers)
            {
                DgvAuthor.Rows.Add(publisher.Id, publisher.Name);
            }

            if (publishers.Count == 0)
                MessageBox.Show("No se encontraron Editoriales.");
        }
        private void ChkTodos_CheckedChanged(object sender, EventArgs e)
        {
            txtCode.Enabled = !ChkTodos.Checked;
            txtPublisher.Enabled = !ChkTodos.Checked;
        }

        // BOTON NUEVO
        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            string formLabel = "Crear una Editorial";
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
            string tituloForm = "Modificar Editorial";
            FrmPublisherTransaction fd = new FrmPublisherTransaction(Modo.EDITAR, authorCode, tituloForm);


            fd.ShowDialog();
            //actualiza la grilla
            BtnConsultar_Click(null, null);
        }

        private void DgvAuthor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            // Usar índice 0 para el cod_libro del libro
            int idPublisher = Convert.ToInt32(DgvAuthor.Rows[e.RowIndex].Cells[0].Value);

            Publisher publisher = oServicio.GetPublisherById(idPublisher);

            // Ver qué columna fue clickeada
            string nombreColumna = DgvAuthor.Columns[e.ColumnIndex].Name;

            if (nombreColumna == "ColView")
            {
                FrmPublisherTransaction frmAuthor = new FrmPublisherTransaction(Modo.VER, publisher);
                frmAuthor.ShowDialog();
            }
            else if (nombreColumna == "ColDelete")
            {
                DialogResult result = MessageBox.Show("¿Estás seguro de que querés eliminar este Editorial?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    int filasBorradas = oServicio.DeleteEditorial(publisher.Id);
                    if (filasBorradas > 0)
                        MessageBox.Show("Editorial borrado exitosamente.");
                    else
                        MessageBox.Show("Error al intentar borrar el Editorial.");
                    //actualiza la grilla
                    BtnConsultar_Click(null, null);
                }
            }
        }
    }
}

