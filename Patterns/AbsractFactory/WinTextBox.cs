using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.AbsractFactory
{
    class WinTextBox : ITextBox
    {
        public void createTextBox()
        {
            Console.WriteLine("Создано текст.поле для Windows");
        }
    }

    class MacTextBox : ITextBox
    {
        public void createTextBox()
        {
            Console.WriteLine("Создано текст.поле для MacOS");
        }
    }
}
