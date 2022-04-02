using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.AbsractFactory
{
    interface IAbstractFactoryOS
    {
        IButton CreateButton();
        ITextBox CreateTextBox();
    }
}
