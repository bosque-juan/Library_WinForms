using Library_WinForms.Data;
using Library_WinForms.Domain.DTOs;
using Library_WinForms.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_WinForms.Business
{
    public class BookManagmentService
    {
        DaoBookManagment oDao;
        public BookManagmentService()
        {
            oDao = new DaoBookManagment();
        }

        public List<BookDTO> GetBooks(AuthorDTORecomended oFilter)
        {
            return oDao.GetBooks(oFilter);
        }
        public Book GetBookById(int codigo)
        {
            return oDao.GetBookById(codigo);
        }
        public int UpdateBook(Book book)
        {
            return oDao.UpdateBook(book);
        }
        public int CreateBook(Book book)
        {
            return oDao.InsertBook(book);
        }
        public int DeleteBook(int codigo)
        {
            return oDao.DeleteBook(codigo);
        }
        public List<int> GetBookYears()
        {
            return oDao.GetBookByYear();
        }
        public List<Genre> GetBookGenres()
        {
            return oDao.GetBookGenders();
        }
        public List<Book_Language> GetBookLanguages()
        {
            return oDao.GetBookLanguages();
        }
    }
}
