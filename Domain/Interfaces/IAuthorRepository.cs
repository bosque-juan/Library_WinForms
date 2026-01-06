using Library_WinForms.Domain.DTOs;
using Library_WinForms.Domain.Entities;
using System.Collections.Generic;


namespace Library_WinForms.Domain.Interfaces
{
    public interface IAuthorRepository
    {
        List<AuthorDTO> GetAuthors();
        AuthorDTO GetAuthorById(int id);
        List<AuthorDTO> GetAuthorsByFilter(AuthorDTORecomended filter);
        int InsertAuthor(AuthorDTO author);
        int UpdateAuthor(AuthorDTO author);
        int DeleteAuthor(int id);
    }
}
