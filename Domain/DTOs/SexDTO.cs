using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_WinForms.Domain.DTOs
{
    public class SexDTO
    {

        private int idSex;
        private string sexType = string.Empty;

        public int IdSex
        {
            get { return idSex; }
            set { idSex = value; }
        }

        public string SexType
        {
            get { return sexType; }
            set { sexType = value; }
        }
        public override string ToString()
        {
            return sexType;
        }

    }
}
