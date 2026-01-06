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
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DialogResult pregunta = MessageBox.Show("¿Desea salir de la aplicación?",
                                        "Salir",
                                        MessageBoxButtons.YesNo,
                                        MessageBoxIcon.Question,
                                        MessageBoxDefaultButton.Button2);

            if (pregunta == DialogResult.Yes)
            Application.Exit();
        }

        private void BookManagmentToolStripMenuItem_Click (object sender, EventArgs e)
        {
            FrmBookManagment fl = new FrmBookManagment();
            fl.ShowDialog();
        }
        private void AuthorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAuthorManagment frmAuthorManagment = new FrmAuthorManagment();
            frmAuthorManagment.ShowDialog();
        }

        private void editorialesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPublisherManagment frmEditorialManagment = new FrmPublisherManagment();
            frmEditorialManagment.ShowDialog();
        }
        private void SalesReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSalesReport frmSalesReport = new FrmSalesReport();
            frmSalesReport.ShowDialog();
        }

        private void RestockingBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRestockingBooks frmRestockingBooks = new FrmRestockingBooks();
            frmRestockingBooks.ShowDialog();
        }

        private void SuggestedBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSuggestedBooks frmSuggestedBooks = new FrmSuggestedBooks();
            frmSuggestedBooks.ShowDialog();
        }

        private void SystemGolToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSystemGoal frm = new FrmSystemGoal();
            frm.ShowDialog();
        }

    }
}
