
namespace FactoryMethod.Pattern
{
    class PngApplication : Application
    {
        BaseForm baseForm;
        int counter;
        Action action;

        public PngApplication(BaseForm baseForm, int counter, Action action)
        {
            this.baseForm = baseForm;
            this.counter = counter;
            this.action = action;
        }

        public override Document CreateDocument()
        {
            return new PngDocument(baseForm, counter, action);
        }

        public override void OpenDocument()
        {
            CreateDocument().Open();
        }
    }
}
