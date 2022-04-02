using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Visitor
{
    interface IElementOfProject
    {
        public void writtenBy(IDeveloper developer);
    }
}
