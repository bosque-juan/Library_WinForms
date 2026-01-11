using Library_WinForms.Domain.Entities;
using System;
using System.Collections.Generic;

using Library_WinForms.Aplication.DTOs;

namespace Library_WinForms.Domain.Interfaces
{
    internal interface IBookRepository
    {
        List<Book> GetBooks(AuthorDTORecomended filter);
        Book GetBookById(int code);
        int UpdateBook(Book book);
        int InsertBook(Book obook);
        int DeleteBook(int codigo);
        List<int> GetBookByYear();
    }
}
