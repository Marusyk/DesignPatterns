using System.Activities;

namespace MealyStateMachine
{
    class Program
    {
        static void Main()
        {
            Activity workflow = new Workflow1();
            WorkflowInvoker.Invoke(workflow);
        }
    }
}
