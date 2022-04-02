using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.TemplateMethod
{
    class School : Education
    {
        protected override void GetDocument()
        {
            Console.WriteLine("Получение аттестата");
        }

        protected override void StartLearn()
        {
            Console.WriteLine("Поступление в школу");
        }

    }
}
