using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_WinForms.Domain.DTOs
{
    public class GenreDTO
    {
        private int idGenre;
        private string _genre = string.Empty;

        public int IdGenre
        {
            get { return idGenre; }
            set { idGenre = value; }
        }

        public string genre
        {
            get { return _genre; }
            set { _genre = value; }
        }
        public override string ToString()
        {
            return genre;
        }
    }
}
