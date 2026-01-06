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


    public partial class FrmBookTransaction : Form
    {
        private BookManagmentService oBookManagmentService;
        private AuthorManagmentService oAuthorManagmentService;
        private PublisherManagmentService oEditorialManagmentService;

        Modo accion;
        Book oLibro;
        private string FormLabel;
        public int BookCode { get; set; }




        public FrmBookTransaction(Modo modo, Book libro)
        {
            InitializeComponent();
            oBookManagmentService = new BookManagmentService();
            oAuthorManagmentService = new AuthorManagmentService();
            oEditorialManagmentService = new PublisherManagmentService();

            accion = modo;
            oLibro = libro;
        }

        public FrmBookTransaction(Modo modo, string tituloForm)
        {
            InitializeComponent();
            oBookManagmentService = new BookManagmentService();
            oAuthorManagmentService = new AuthorManagmentService();
            oEditorialManagmentService = new PublisherManagmentService();

            accion = modo;
            FormLabel = tituloForm;

        }

        public FrmBookTransaction(Modo modo, int bookCode, string formLabel)
        {
            InitializeComponent();
            oBookManagmentService = new BookManagmentService();
            oAuthorManagmentService = new AuthorManagmentService();
            oEditorialManagmentService = new PublisherManagmentService();
            FormLabel = formLabel;
            BookCode = bookCode;
            accion = modo;
        }

        private void FrmDetalles_Load(object sender, EventArgs e)
        {
            this.Text = string.IsNullOrEmpty(FormLabel) ? "Formulario Detalle" : this.FormLabel;
            CargarComboAutores();
            LoadEditorialCombo();
            CargarComboIdiomas();
            ComboLoadGneder();
            TxtCodigo.Enabled = (accion == Modo.NUEVO);
            if (accion == Modo.EDITAR)
            {
                CargarInfo();
            }


            if (accion == Modo.VER)
            {
                TxtCodigo.Text = oLibro.Code.ToString();
                TxtIsbn.Text = oLibro.Isbn;
                TxtTitulo.Text = oLibro.Title;
                TxtPrecio.Text = oLibro.Price.ToString();
                TxtDescripcion.Text = oLibro.Description;
                TxtStock.Text = oLibro.Stock.ToString();
                if (oLibro.Genre != null)
                    cboGenero.Text = oLibro.Genre.genre;
                else
                    cboGenero.SelectedIndex = -1;
                CboEditorial.Text = oLibro._Editorial.Name;
                DtpFecha.Value = oLibro.ReleaseDate;
                CboIdioma.Text = oLibro.Languaje.LanguajeName;
                if (oLibro.Author != null)
                {
                    CboAutor.SelectedValue = oLibro.Author.Code;
                }
                CboAutor.Text = oLibro.Author.FullName;
            }
            if (accion == Modo.VER || accion == Modo.BORRAR)
            {
                GrbDetalles.Enabled = false;
            }

        }

        private void CargarComboAutores()
        {
            List<Author> authorsList = oAuthorManagmentService.GetAuthor();


            CboAutor.ValueMember = "Code";
            CboAutor.DisplayMember = "FullName";
            CboAutor.DataSource = authorsList;
            CboAutor.DropDownStyle = ComboBoxStyle.DropDownList;
            CboAutor.SelectedIndex = -1;
        }
        private void CargarComboIdiomas()
        {
            List<Book_Language> listaIdiomas = oBookManagmentService.GetBookLanguages();


            CboIdioma.ValueMember = "Id";
            CboIdioma.DisplayMember = "LanguajeName";
            CboIdioma.DataSource = listaIdiomas;
            CboIdioma.DropDownStyle = ComboBoxStyle.DropDownList;
            CboIdioma.SelectedIndex = -1;
        }

        private void LoadEditorialCombo()
        {
            List<Publisher> listaEditoriales = oEditorialManagmentService.GetEditorials();


            CboEditorial.ValueMember = "Id";
            CboEditorial.DisplayMember = "Name";
            CboEditorial.DataSource = listaEditoriales;
            CboEditorial.DropDownStyle = ComboBoxStyle.DropDownList;
            CboEditorial.SelectedIndex = -1;
        }

        private void ComboLoadGneder()
        {
            List<Genre> listGender = oBookManagmentService.GetBookGenres();


            cboGenero.ValueMember = "IdGenre";
            cboGenero.DisplayMember = "genre";
            cboGenero.DataSource = listGender;

            cboGenero.SelectedIndex = -1;
            cboGenero.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void CargarInfo()
        {
            Book oLibro = oBookManagmentService.GetBookById(BookCode);

            TxtCodigo.Text = oLibro.Code.ToString();
            TxtIsbn.Text = oLibro.Isbn;
            TxtTitulo.Text = oLibro.Title;
            TxtPrecio.Text = oLibro.Price.ToString();
            TxtDescripcion.Text = oLibro.Description;
            TxtStock.Text = oLibro.Stock.ToString();
            if (oLibro.Genre != null)
                cboGenero.Text = oLibro.Genre.genre;
            else
                cboGenero.SelectedIndex = -1;
            CboEditorial.Text = oLibro._Editorial.Name;
            DtpFecha.Value = oLibro.ReleaseDate;
            CboIdioma.Text = oLibro.Languaje.LanguajeName;
            if (oLibro.Author != null)
            {
                CboAutor.SelectedValue = oLibro.Author.Code;
            }
            CboAutor.Text = oLibro.Author.FullName;
        }


        private void BtnAceptar_Click(object sender, EventArgs e)
        {

            if (ValidarDatos())
            {
                Book oLibro = new Book();

                oLibro.Code = int.Parse(TxtCodigo.Text);
                oLibro.Author = (Author)CboAutor.SelectedItem;
                oLibro.Isbn = TxtIsbn.Text;
                oLibro.Title = TxtTitulo.Text;
                oLibro.Price = double.Parse(TxtPrecio.Text);
                oLibro.Stock = int.Parse(TxtStock.Text);
                oLibro.Genre = (Genre)cboGenero.SelectedItem;
                oLibro.Description = TxtDescripcion.Text;
                oLibro._Editorial = (Publisher)CboEditorial.SelectedItem;
                oLibro.ReleaseDate = DtpFecha.Value.Date;
                oLibro.Languaje = (Book_Language)CboIdioma.SelectedItem;

                int rowAffected = 0;
                string mensaje = string.Empty;
                if (accion == Modo.NUEVO)
                {
                    rowAffected = oBookManagmentService.CreateBook(oLibro);
                    mensaje = "creado";
                }
                else if (accion == Modo.EDITAR)
                {
                    rowAffected = oBookManagmentService.UpdateBook(oLibro);
                    mensaje = "actualizado";
                }
                else
                {
                    this.Close();
                    return;
                }

                if (rowAffected > 0)
                {
                    MessageBox.Show($"Libro {mensaje} exitosamente");
                    this.Close();
                }
                else
                {
                    MessageBox.Show($"Error al {mensaje} el libro");
                }

            }

        }

        private bool ValidarDatos()
        {
            if (string.IsNullOrEmpty(TxtCodigo.Text))
            {
                MessageBox.Show("Debe ingresar un código");
                TxtCodigo.Focus();
                return false;
            }
            if (!int.TryParse(TxtCodigo.Text, out _))
            {
                MessageBox.Show("El código debe ser numérico");
                TxtCodigo.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(TxtTitulo.Text))
            {
                MessageBox.Show("Debe ingresar un título");
                TxtTitulo.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(TxtIsbn.Text))
            {
                MessageBox.Show("Debe ingresar un ISBN");
                TxtIsbn.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(TxtPrecio.Text))
            {
                MessageBox.Show("Debe ingresar un precio");
                TxtPrecio.Focus();
                return false;
            }
            if (!decimal.TryParse(TxtPrecio.Text, out _))
            {
                MessageBox.Show("El precio debe ser un número válido");
                TxtPrecio.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(TxtStock.Text))
            {
                MessageBox.Show("Debe ingresar el stock");
                TxtStock.Focus();
                return false;
            }
            if (!int.TryParse(TxtStock.Text, out _))
            {
                MessageBox.Show("El stock debe ser un número entero");
                TxtStock.Focus();
                return false;
            }

            if (DtpFecha.Value.Date > DateTime.Today.Date)
            {
                MessageBox.Show("La fecha de publicación no puede ser posterior a hoy");
                DtpFecha.Focus();
                return false;
            }

            if (CboAutor.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un autor");
                CboAutor.Focus();
                return false;
            }
            if (CboIdioma.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un idioma");
                CboIdioma.Focus();
                return false;
            }
            if (CboEditorial.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione una editorial");
                CboEditorial.Focus();
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

    }
}
