
namespace FactoryMethod.Pattern
{
    // ConcreteCreatorA
    class TextApplication : Application
    {
        BaseForm baseForm;
        int counter;
        Action action;

        public TextApplication(BaseForm baseForm, int counter, Action action)
        {
            this.baseForm = baseForm;
            this.counter = counter;
            this.action = action;
        }

        public override Document CreateDocument()
        {
            return new TextDocument(baseForm, counter, action);
        }

        public override void OpenDocument()
        {
            CreateDocument().Open();
        }
    }
}
