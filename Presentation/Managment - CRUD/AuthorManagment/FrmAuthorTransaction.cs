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
    public enum Modo
    {
        VER = 1,
        EDITAR,
        BORRAR,
        NUEVO
    }


    public partial class FrmAuthorTransaction : Form
    {
        AuthorManagmentService oAuthorService;
        NationalityService oNationalityService;

        Modo accion;
        Author oAuthor;
        private string _formLabel;
        public int AuthorCode { get; set; }




        public FrmAuthorTransaction(Modo modo, Author author)
        {
            InitializeComponent();
            oAuthorService = new AuthorManagmentService();
            oNationalityService = new NationalityService();

            accion = modo;
            oAuthor = author;
        }

        public FrmAuthorTransaction(Modo modo, string tituloForm)
        {
            InitializeComponent();
            oAuthorService = new AuthorManagmentService();
            oNationalityService = new NationalityService();
            accion = modo;
            _formLabel = tituloForm;

        }

        public FrmAuthorTransaction(Modo modo, int authorCode, string tituloForm)
        {
            InitializeComponent();
            _formLabel = tituloForm;
            oAuthorService = new AuthorManagmentService();

            oNationalityService = new NationalityService();
            AuthorCode = authorCode;
            accion = modo;
        }

        private void FrmDetalles_Load(object sender, EventArgs e)
        {
            this.Text = string.IsNullOrEmpty(_formLabel) ? "Administrador Autor" : this._formLabel;
            LoadNationalitiesCombo();
            LoadSexCombo();
            TxtCodigo.Enabled = (accion == Modo.NUEVO);
            if (accion == Modo.EDITAR)
            {
                LoadInfo();
            }


            if (accion == Modo.VER)
            {
                TxtCodigo.Text = oAuthor.Code.ToString();
                TxtName.Text = oAuthor.Name;
                TxtSurname.Text = oAuthor.Surname;
                dtpBirthDate.Value = oAuthor.BirthDate;
                CboNationality.Text = oAuthor.Nationality.Description;
                CboSexo.Text = oAuthor.SexType.SexType;

            }
            if (accion == Modo.VER || accion == Modo.BORRAR)
            {
                //GrbDetalles.Enabled = false;
            }

        }


        private void LoadNationalitiesCombo()
        {
            List<Nationality> nationalityList = oNationalityService.GetNationalities();

            CboNationality.ValueMember = "Id";
            CboNationality.DisplayMember = "Description";
            CboNationality.DataSource = nationalityList;
            CboNationality.DropDownStyle = ComboBoxStyle.DropDownList;
            CboNationality.SelectedIndex = -1;
        }
        private void LoadSexCombo()
        {
            List<Sex> sexList = oAuthorService.GetSexes();

            CboSexo.DataSource = sexList;
            CboSexo.ValueMember = "IdSex";
            CboSexo.DisplayMember = "SexType";
            CboSexo.DropDownStyle = ComboBoxStyle.DropDownList;
            CboSexo.SelectedIndex = -1;
        }

    


        private void LoadInfo()
        {
            // Obtenemos el autor por su código
            oAuthor = oAuthorService.GetAuthorById(AuthorCode);

            if (oAuthor != null)
            {
                TxtCodigo.Text = oAuthor.Code.ToString();
                TxtName.Text = oAuthor.Name;
                TxtSurname.Text = oAuthor.Surname;
                dtpBirthDate.Value = oAuthor.BirthDate;
                CboSexo.Text = oAuthor.SexType.SexType;
                CboNationality.Text = oAuthor.Nationality.Description;
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

            Author autor = new Author
            {
                Code = int.Parse(TxtCodigo.Text),
                Name = TxtName.Text.Trim(),
                Surname = TxtSurname.Text.Trim(),
                SexType = (Sex)CboSexo.SelectedItem,
                BirthDate = dtpBirthDate.Value,
                Nationality = (Nationality)CboNationality.SelectedItem
            };

            int result;
            string msg;

            if (accion == Modo.NUEVO)
            {
                result = oAuthorService.CreateAuthor(autor);
                msg = "creado";
            }
            else
            {
                result = oAuthorService.UpdateAuthor(autor);
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
            if (string.IsNullOrWhiteSpace(TxtCodigo.Text))
            {
                MessageBox.Show("El código es obligatorio.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TxtCodigo.Focus();
                return false;
            }
            if (!int.TryParse(TxtCodigo.Text, out _))
            {
                MessageBox.Show("El código debe ser un número entero.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TxtCodigo.Focus();
                return false;
            }

            // 2. Validar Nombre
            if (string.IsNullOrWhiteSpace(TxtName.Text))
            {
                MessageBox.Show("El nombre es obligatorio.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TxtName.Focus();
                return false;
            }

            // 3. Validar Apellido
            if (string.IsNullOrWhiteSpace(TxtSurname.Text))
            {
                MessageBox.Show("El apellido es obligatorio.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TxtSurname.Focus();
                return false;
            }

            // 4. Validar Fecha de Nacimiento (que no sea una fecha futura)
            if (dtpBirthDate.Value > DateTime.Now)
            {
                MessageBox.Show("La fecha de nacimiento no puede ser mayor a la fecha actual.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtpBirthDate.Focus();
                return false;
            }

            // 5. Validar Sexo (ComboBox)
            if (CboSexo.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un sexo.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                CboSexo.Focus();
                return false;
            }

            // 6. Validar Nacionalidad (ComboBox)
            if (CboNationality.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar una nacionalidad.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                CboNationality.Focus();
                return false;
            }

            // Si pasó todas las validaciones
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
