using Library_WinForms.Data;
using Library_WinForms.Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Library_WinForms.Domain.Entities;

namespace Library_WinForms.Presentation
{
    //public enum Modo
    //{
    //    VER = 1,
    //    EDITAR,
    //    BORRAR,
    //    NUEVO
    //}


    public partial class FrmPublisherTransaction : Form
    {
        PublisherManagmentService oPublisherService;
        //NationalityService oNationalityService;

        Modo accion;
        Publisher oPublisher;
        private string _formLabel;
        public int PublisherCode { get; set; }




        public FrmPublisherTransaction(Modo modo, Publisher publisher)
        {
            InitializeComponent();
            oPublisherService = new PublisherManagmentService();

            accion = modo;
            oPublisher = publisher;
        }

        public FrmPublisherTransaction(Modo modo, string tituloForm)
        {
            InitializeComponent();
            oPublisherService = new PublisherManagmentService();
            accion = modo;
            _formLabel = tituloForm;

        }

        public FrmPublisherTransaction(Modo modo, int publisherCode, string tituloForm)
        {
            InitializeComponent();
            _formLabel = tituloForm;
            oPublisherService = new PublisherManagmentService();
            PublisherCode = publisherCode;
            accion = modo;
        }

        private void FrmDetalles_Load(object sender, EventArgs e)
        {
            this.Text = string.IsNullOrEmpty(_formLabel) ? "Administrador Editorial" : this._formLabel;
       
            TxtCode.Enabled = (accion == Modo.NUEVO);
            if (accion == Modo.EDITAR)
            {
                LoadInfo();
            }


            if (accion == Modo.VER)
            {
                TxtCode.Text = oPublisher.Id.ToString();
                TxtPublisher.Text = oPublisher.Name;
         

            }
            if (accion == Modo.VER || accion == Modo.BORRAR)
            {
                //GrbDetalles.Enabled = false;
            }

        }


    
     

        private void LoadInfo()
        {
            oPublisher = oPublisherService.GetPublisherById(PublisherCode);

            if (oPublisher != null)
            {
                TxtCode.Text = oPublisher.Id.ToString();
                TxtPublisher.Text = oPublisher.Name;
                
            }
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            if (accion == Modo.VER)
            {
                Close();
                return;
            }

            if (!ValidarDatos()) return;

            Publisher publisher = new Publisher
            {
                Id = int.Parse(TxtCode.Text),
                Name = TxtPublisher.Text.Trim()
            };

            int result;
            string msg;

            if (accion == Modo.NUEVO)
            {
                result = oPublisherService.CreateEditorial(publisher);
                msg = "creado";
            }
            else
            {
                result = oPublisherService.UpdateEditorial(publisher);
                msg = "actualizado";
            }

            if (result > 0)
            {
                MessageBox.Show($"Autor {msg} correctamente");
                Close();
            }
            else
            {
                MessageBox.Show($"Error al {msg} autor");
            }
        }
        private bool ValidarDatos()
        {
            // 1. Validar Código (Solo si es NUEVO, ya que suele ser la PK)
            if (string.IsNullOrWhiteSpace(TxtCode.Text))
            {
                MessageBox.Show("El código es obligatorio.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TxtCode.Focus();
                return false;
            }
            if (!int.TryParse(TxtCode.Text, out _))
            {
                MessageBox.Show("El código debe ser un número entero.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TxtCode.Focus();
                return false;
            }

            // 2. Validar Nombre
            if (string.IsNullOrWhiteSpace(TxtPublisher.Text))
            {
                MessageBox.Show("El nombre es obligatorio.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TxtPublisher.Focus();
                return false;
            }

            return true;
        }
        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea Cancelar", "Confirmar cancelación", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void DtpFecha_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
