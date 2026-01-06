using Library_WinForms.Data;
using Library_WinForms.Domain.DTOs;
using Library_WinForms.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_WinForms.Business
{
    public class AuthorManagmentService
    {
        DaoAuthorManagment oDao;
        public AuthorManagmentService()
        {
            oDao = new DaoAuthorManagment();
        }
        public List<Author> GetAuthor()
        {
            return oDao.GetAuthors();
        }
        public Author GetAuthorById(int codigo)
        {
            return oDao.GetAuthorById(codigo);
        }
        public List<Author> GetAuthorByFilter(AuthorDTORecomended filter)
        {
            return oDao.GetAuthorsByFilter(filter);
        }

        public int UpdateAuthor(Author author)
        {
            return oDao.UpdateAuthor(author);
        }
        public int CreateAuthor(Author author)
        {
            return oDao.InsertAuthor(author);
        }
        public int DeleteAuthor(int codigo)
        {
            return oDao.DeleteAuthor(codigo);
        }
        public List<Sex> GetSexes()
        {
            return oDao.GetSexes();

        }
    }
}