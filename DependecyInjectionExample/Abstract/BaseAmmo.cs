using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependecyInjectionExample.Abstract
{
    public abstract class BaseAmmo : IAmmo
    {
        protected int power; 
        public void Fire()
        {
            Console.WriteLine("power: " + power + "Fired.");

        }
    }
}
