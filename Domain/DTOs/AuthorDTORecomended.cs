using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_WinForms.Domain.DTOs
{
    public class AuthorDTORecomended
    {
        public int Code { get; set; }
        public string Title { get; set; } = string.Empty;
        public string AuthorName { get; set; } = string.Empty;
        public int Author { get; set; }
        public int Genre { get; set; }
        public int From { get; set; }
        public int To { get; set; }

    }
}
