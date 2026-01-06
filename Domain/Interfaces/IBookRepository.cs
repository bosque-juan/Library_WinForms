using Library_WinForms.Domain.Entities;
using Library_WinForms.Domain.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_WinForms.Domain.Interfaces
{
    internal interface IBookRepository
    {
        List<BookDTO> GetBooks(AuthorDTORecomended filter);
        BookDTO GetBookById(int code);
        int UpdateBook(BookDTO book);
        int InsertBook(BookDTO obook);
        int DeleteBook(int codigo);
        List<int> GetBookByYear();
    }
}
