using System;

namespace WidgetFactoryApplication
{
    // ConcreteFactory1
    class WindowsFactory : WidgetFactory
    {
        public override AbstractWindow CreateWindow()
        {
            return new WindowsForm();
        }

        public override AbstractButton CreateButton()
        {
            return new WindowsButton();
        }
    }
}
