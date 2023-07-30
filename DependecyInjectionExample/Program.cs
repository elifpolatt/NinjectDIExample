using DependecyInjectionExample.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject;
using DependecyInjectionExample.Ninject;

namespace DependecyInjectionExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Weapon weaponX = new Weapon(new XAmmo());
            //Weapon weaponY = new Weapon(new YAmmo());

            //weaponX.Fire();
            //weaponY.Fire();

            //çekirdek olusturduk.
            IKernel kernel = new StandardKernel(new AmmoModule());

            Weapon weapon = kernel.Get<Weapon>();
            weapon.Fire();

        }
    }
}
