using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    internal class Burger
    {
        //eager singleton object creation. 
        private static Burger burger = new Burger();    

        private Burger() { }

        public static Burger GetBurgerObject()
        {
            return burger;
        }
    }
}
