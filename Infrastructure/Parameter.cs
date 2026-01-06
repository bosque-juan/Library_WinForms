using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_WinForms.Data
{
    public class Parameter
    {
        private string name;
        private object value;
        public Parameter()
        {
            name = string.Empty;
            value = null;
        }
        public Parameter(string name, object value)
        {
            this.name = name;
            this.value = value;
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public object Value
        {
            get { return value; }
            set { this.value = value; }
        }

    }
}
