using Library_WinForms.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_WinForms.Domain.DTOs
{
    public class AuthorDTO
    {
        public int Code { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime BirthDate { get; set; }
        public string Biography { get; set; }
        public NationalityDTO Nationality { get; set; }
        public SexDTO SexType { get; set; }
        public string FullName => $"{Name} {Surname}";

    }
}
