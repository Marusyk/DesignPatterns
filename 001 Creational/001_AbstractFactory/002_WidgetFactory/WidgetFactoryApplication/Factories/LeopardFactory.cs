using System;

namespace WidgetFactoryApplication
{
    // ConcreteFactory2
    class LeopardFactory : WidgetFactory
    {
        public override AbstractWindow CreateWindow()
        {
            return new LeopardForm();
        }

        public override AbstractButton CreateButton()
        {
            return new LeopardButton();
        }
    }
}
