using System;

namespace Mediator.Pattern
{
    abstract class DialogDirector
    {
        public void ShowDialog()
        {
            throw new InvalidOperationException();
        }
        public abstract void WidgetChanged(Widget wdgt);

        protected abstract void CreateWidgets();
    }
}
