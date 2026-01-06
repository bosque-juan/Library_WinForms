using Library_WinForms.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_WinForms.Domain.Entities
{
    public class Author
    {
        public int Code { get; set; }

        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime BirthDate { get; set; }
        public string Biography { get; set; }
        public Nationality Nationality { get; set; }
        public Sex SexType { get; set; }

    }
}
