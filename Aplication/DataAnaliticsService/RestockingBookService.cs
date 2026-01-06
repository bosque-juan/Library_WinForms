using Library_WinForms.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Library_WinForms.Domain.DTOs;
using Library_WinForms.Domain.Entities;

namespace Library_WinForms.Servicio.VentasRealizadas
{
    internal class RestockingBookService
    {
        DaoRestockingBooks oDao;
        public RestockingBookService()
        {
            oDao = new DaoRestockingBooks();
        }
        public List<BookDTO> GetBooksForStocking(AuthorDTORecomended filter)
        {
            return oDao.GetBooksForStocking(filter);
        }

    }
}
