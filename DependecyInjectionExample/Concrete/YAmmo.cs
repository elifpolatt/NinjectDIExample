using DependecyInjectionExample.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependecyInjectionExample.Concrete
{
    public class YAmmo : BaseAmmo
    {
       public YAmmo()
        {
            power = 20;
        }
    }
}
