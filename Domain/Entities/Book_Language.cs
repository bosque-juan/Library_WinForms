using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_WinForms.Domain.Entities
{
    public class Book_Language
    {
        private int id;
        private string Language;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string LanguajeName
        {
            get { return Language; }
            set { Language = value; }
        }
        public override string ToString()
        {
            return Language;
        }
        public Book_Language(int id, string language)
        {
            this.id = id;
            this.Language = language;
        }
        public Book_Language()
        {
            this.id = 0;
            this.Language = string.Empty;
        }
    }
}
