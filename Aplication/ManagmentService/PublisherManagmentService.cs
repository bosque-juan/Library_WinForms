using Library_WinForms.Data;
using Library_WinForms.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_WinForms.Business
{
    public class PublisherManagmentService
    {
        DaoPublisherManagment oDaoEditorial;
        public PublisherManagmentService()
        {
            oDaoEditorial = new DaoPublisherManagment();
        }

        public List<Publisher> GetEditorials()
        {
            return oDaoEditorial.GetEditorials();
        }
        public List<Publisher> GetPublisherByFilter(List<Parameter> filter)
        {
            return oDaoEditorial.GetPublisherByFilter(filter);
        }
        public Publisher GetPublisherById(int codigo)
        {
            return oDaoEditorial.GetEditorialById(codigo);
        }
        public int UpdateEditorial(Publisher editorial)
        {
            return oDaoEditorial.UpdateEditorial(editorial);
        }
        public int CreateEditorial(Publisher editorial)
        {
            return oDaoEditorial.InsertEditorial(editorial);
        }
        public int DeleteEditorial(int codigo)
        {
            return oDaoEditorial.DeleteEditorial(codigo);
        }
    }
}
