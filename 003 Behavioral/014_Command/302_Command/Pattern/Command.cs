
namespace Command.Pattern
{
    abstract class Command
    {
        public abstract void Execute();

        protected void LogExecution(string text)
        {
            MainForm.MainFormInstance.Log(this.GetType().Name + " -> " + text);
        }
    }
}
