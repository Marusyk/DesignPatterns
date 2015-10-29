
namespace Mediator.Pattern
{
    abstract class Widget
    {
        protected FontDialogDirector Director;

        public Widget(FontDialogDirector director)
        {
            Director = director;
        }

        public void Changed()
        {
            Director.WidgetChanged(this);
        }
    }
}
