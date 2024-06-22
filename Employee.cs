using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2mdk
{
   public class Employee:IPerson
    {public string? Name { get; set; }
    public string? Surname { get; set; } 
    public string? Patronymic { get; set; }
    public decimal Salery { get; set;}
    public decimal Tax()
        {
            return ((Salery * 13) / 100) * 12;
        }
    public decimal Income()
        {
            return Salery * 12;
        }
    }
}
