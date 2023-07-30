using DependecyInjectionExample.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependecyInjectionExample.Concrete
{
    public class Weapon
    {
        IAmmo usingammo;
        public Weapon(IAmmo ammo)
        {
            usingammo = ammo;
        }
        public void Fire()
        {
            usingammo.Fire();
        }
    }
}
