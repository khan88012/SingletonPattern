using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    internal class Biryani
    {
        private static Biryani biryani;

        //if any thread passes through it the InstanceLock object is created i.e. it's not null
        private static readonly object InstanceLock = new object();

        private Biryani() { }

        public static Biryani getBiryaniObject() {
        
            lock (InstanceLock)
            {
                if(biryani == null)
                {
                    biryani = new Biryani();
                }
            }
            return biryani;
            
        }
    }
}
