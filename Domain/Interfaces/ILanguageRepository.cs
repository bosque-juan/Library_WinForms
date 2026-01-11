using Library_WinForms.Domain.Entities;
using System.Collections.Generic;


namespace Library_WinForms.Domain.Interfaces
{
    internal interface ILanguageRepository
    {
        List<Book_Language> GetLanguages();
    }
}
