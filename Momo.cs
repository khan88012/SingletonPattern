using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    internal class Momo
    {
        private static Momo momo;

        private static readonly object InstanceLock = new object();

        public static Momo GetMomoObject()
        {
            if(momo == null)
            {
                // As long as one thread locks the resource , no other thread can access the resource
                // As long as one thread enters into the critical Section,
                // no other threads are allowed to enter the critical section
                lock (InstanceLock)
                {
                    //Critical Section start
                    if(momo == null)
                    {
                        momo = new Momo();
                    }
                }
            }
            return momo;
        }
    }
}
