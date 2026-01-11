using Library_WinForms.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_WinForms.Domain.Interfaces
{
    internal interface IPublisherRepository
    {
        List<Publisher> GetPublishers();
        Publisher GetPublisherById(int id);
        int InsertPublisher(Publisher Publisher);
        int UpdatePublisher(Publisher Publisher);
        int DeletePublisher(int id);
    }
}
