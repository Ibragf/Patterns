using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.AbsractFactory
{
    class WinButton : IButton
    {
        public void createButton()
        {
            Console.WriteLine("Создана кнопка для Win");
        }
    }

    class MacButton : IButton
    {
        public void createButton()
        {
            Console.WriteLine("Создана кнопка для MacOS");
        }
    }
}
