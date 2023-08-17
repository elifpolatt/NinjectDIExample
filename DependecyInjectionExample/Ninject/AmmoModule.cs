using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DependecyInjectionExample.Abstract;
using DependecyInjectionExample.Concrete;
using Ninject.Modules;

namespace DependecyInjectionExample.Ninject
{
    public class AmmoModule : NinjectModule
    {
        
        public override void Load()
        {
            //IAmmo isminde bir interface gördüğünde YAmmo sınıfından bir nesne baglayacak.
            Bind<IAmmo>().To<YAmmo>();
            //veya 
         //Bind<IAmmo>().To<XAmmo>();
        }
    }
}
