using DependecyInjectionExample.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependecyInjectionExample.Concrete
{
    public class XAmmo : BaseAmmo
    {
        public XAmmo()
        {
            power = 10;
        }
    }
}
