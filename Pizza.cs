using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    internal class Pizza
    {
        //making it static because you need object to access non-static fields 
        //static object is null by default
        private static Pizza? pizza;
        private Pizza() {
            Console.WriteLine("private constructor");
        }

        //making it static because whenever you want to create an object from another class, can create directly with class name 
        // lazy way of creating singleton object as the object will be created when the method is called
        public static Pizza GetPizzaObject()
        {
            if(pizza == null)
            {
              pizza =  new Pizza();
            }

            return pizza;
        }
    }
}
