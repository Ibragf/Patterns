using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Visitor
{
    interface IDeveloper
    {
        public void create(ProjectClass projectClass);
        public void create(Database database);
        public void create(Test test);
    }
}
