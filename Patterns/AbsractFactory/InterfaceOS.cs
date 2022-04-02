using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.AbsractFactory
{
    class InterfaceOS
    {
        private IButton button;
        private ITextBox textBox;

        public InterfaceOS(IAbstractFactoryOS factoryOS)
        {
            button = factoryOS.CreateButton();
            textBox = factoryOS.CreateTextBox();
        }

        public void createButton()
        {
            button.createButton();
        }

        public void createTextBox()
        {
            textBox.createTextBox();
        }
    }
}
