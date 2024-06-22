using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2mdk
{
   public  class Student:IPerson
    {public string Name { get; set; }
   public string Surname { get; set; }
   public string Patronymic { get; set; }
public decimal monthScholarship { get; set; }
   public decimal Income()
        {
            return monthScholarship * 12;
        }

       
    }
}
