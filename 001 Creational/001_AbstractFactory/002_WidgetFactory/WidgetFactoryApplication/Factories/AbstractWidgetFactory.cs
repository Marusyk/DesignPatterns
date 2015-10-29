using System;

namespace WidgetFactoryApplication
{
    // AbstractFactory
    abstract class WidgetFactory
    {
        public abstract AbstractWindow CreateWindow();
        public abstract AbstractButton CreateButton();
    }
}
