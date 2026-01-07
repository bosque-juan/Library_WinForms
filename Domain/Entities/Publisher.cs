using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_WinForms.Domain.Entities
{
    public class Publisher
    {
        private int id;
        private string name;

        public Publisher(int id, string name)
        {
            this.id = id;
            this.name = name;
        }
        public Publisher()
        {
            this.id = 0;
            this.name = string.Empty;
        }
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public override string ToString()
        {
            return Name;
        }

    }
}
