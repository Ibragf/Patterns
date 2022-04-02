using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Visitor
{
    class SeniorDev : IDeveloper
    {
        public void create(ProjectClass projectClass)
        {
            Console.WriteLine("Написание хороших класса");
        }

        public void create(Database database)
        {
            Console.WriteLine("Поднимает базу");
        }

        public void create(Test test)
        {
            Console.WriteLine("Создание надежных тестов");
        }
    }
}
