
namespace FactoryMethod.Pattern
{
    // Creator
    abstract class Application
    {
        public abstract Document CreateDocument();
        public abstract void OpenDocument();
    }
}
