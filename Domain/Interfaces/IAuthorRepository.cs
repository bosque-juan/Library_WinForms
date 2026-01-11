using Library_WinForms.Aplication.DTOs;
using Library_WinForms.Domain.Entities;
using System.Collections.Generic;


namespace Library_WinForms.Domain.Interfaces
{
    public interface IAuthorRepository
    {
        List<Author> GetAuthors();
        Author GetAuthorById(int id);
        List<Author> GetAuthorsByFilter(AuthorDTORecomended filter);
        int InsertAuthor(Author author);
        int UpdateAuthor(Author author);
        int DeleteAuthor(int id);
    }
}
