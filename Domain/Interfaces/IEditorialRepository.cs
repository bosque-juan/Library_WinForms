using Library_WinForms.Domain.DTOs;
using Library_WinForms.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_WinForms.Domain.Interfaces
{
    internal interface IEditorialRepository
    {
        List<PublisherDTO> GetEditorials();
        PublisherDTO GetEditorialById(int id);
        int InsertEditorial(PublisherDTO editorial);
        int UpdateEditorial(PublisherDTO editorial);
        int DeleteEditorial(int id);
    }
}
