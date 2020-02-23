using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace CSharp_Course_Intermediate
{
    class Program
    {
        static void Main(string[] args)
        {
            WorkFlow workFlow = new WorkFlow();
            workFlow.AddActivity(new EmailNotify());
            workFlow.AddActivity(new ProcessVideo());
            workFlow.AddActivity(new EncodeVideo());
            workFlow.AddActivity(new VideoUpload());
            WorkFlowEngine.Run(workFlow);
        }

    }
}
