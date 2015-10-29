
namespace Command.Pattern
{
    class CloseCommand : Command
    {
        public override void Execute()
        {
            if (MainForm.CurrentDocument != null)
            {
                LogExecution("close");
                MainForm.CurrentDocument.Close();
            }
        }
    }
}
