using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Adapter
{
    
    class Computer
    {
        public void connect(USB usb)
        {
            usb.Connect();
        }
    }

    class USB
    {
        public virtual void Connect()
        {
            Console.WriteLine("USB подключено");
        }
    }

    class MemoryCard
    {
        public void connectCard()
        {
            Console.WriteLine("Карта памяти подкючена");
        }
    }
}
