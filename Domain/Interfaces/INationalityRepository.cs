using Library_WinForms.Domain.DTOs;
using Library_WinForms.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_WinForms.Domain.Interfaces
{
    internal interface INationalityRepository
    {
        List<NationalityDTO> GetNationalities();
    }
}
