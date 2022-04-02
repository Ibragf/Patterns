using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Visitor
{
    class ProjectClass : IElementOfProject
    {
        public void writtenBy(IDeveloper developer)
        {
            developer.create(this);
        }
    }

    class Database : IElementOfProject
    {
        public void writtenBy(IDeveloper developer)
        {
            developer.create(this);
        }
    }

    class Test : IElementOfProject
    {
        public void writtenBy(IDeveloper developer)
        {
            developer.create(this);
        }
    }
}
