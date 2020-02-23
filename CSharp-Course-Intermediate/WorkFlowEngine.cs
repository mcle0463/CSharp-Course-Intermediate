namespace CSharp_Course_Intermediate
{
    public class WorkFlowEngine
    {
        public static void Run(WorkFlow workFlow)
        {
            foreach (var activity in workFlow.ActivityList)
            {
                activity.execute();
            }
        }
    }
}