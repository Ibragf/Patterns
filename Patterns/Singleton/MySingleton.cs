using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Singleton
{
    public class MySingleton
    {
        private static MySingleton singleton=null;

        //конструктор скрытый
        private MySingleton()
        {

        }
            
        public static MySingleton getInstance()
        {
            if (singleton==null)
            {
                singleton = new MySingleton();
            }
            return singleton;
        }
    }
}
