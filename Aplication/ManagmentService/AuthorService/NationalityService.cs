using Library_WinForms.Data;
using Library_WinForms.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_WinForms.Business
{
    public class NationalityService
    {
        DaoNationality oDao;
        public NationalityService()
        {
            oDao = new DaoNationality();
        }

        public List<Nationality> GetNationalities()
        {
            return oDao.GetNationalities();
        }




    }
}
