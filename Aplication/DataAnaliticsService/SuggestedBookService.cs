using Library_WinForms.Business;
using Library_WinForms.Data;
using Library_WinForms.Domain.DTOs;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookDTO = Library_WinForms.Domain.DTOs.BookDTO;

namespace Library_WinForms.Servicio.VentasRealizadas
{
    internal class SuggestedBookService
    {
        DaoSuggestedBooks oDaSuggestedBook;
        public SuggestedBookService()
        {
            oDaSuggestedBook = new DaoSuggestedBooks();
        }
        public List<BookDTO> GetSuggestedBooks(AuthorDTORecomended oFlistro)
        {
            return oDaSuggestedBook.GetSuggestedBooks(oFlistro);
        }
    }
}
