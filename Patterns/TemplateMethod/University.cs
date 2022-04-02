using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.TemplateMethod
{
    class University : Education
    {
        protected override void GetDocument()
        {
            Console.WriteLine("Получение диплома");
        }

        protected override void StartLearn()
        {
            Console.WriteLine("Поступление в университет");
        }
    }
}
