using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Visitor
{
    class JuniorDev : IDeveloper
    {
        public void create(ProjectClass projectClass)
        {
            Console.WriteLine("Написание плохого класса");
        }

        public void create(Database database)
        {
            Console.WriteLine("Роняет базу");
        }

        public void create(Test test)
        {
            Console.WriteLine("Создание ненадежных тестов");
        }
    }
}
