using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2mdk
{
    public interface IPerson
    {
        string Surname { get; set; }
        string Name { get; set; }
        string Patronymic { get; set; }

        decimal Income();
    }
}
