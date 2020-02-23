using System.Collections.Generic;

namespace CSharp_Course_Intermediate
{
    public class WorkFlow
    {
        public List<IActivity> ActivityList;
        public WorkFlow()
        {
            this.ActivityList = new List<IActivity>();
        }

        public void AddActivity(IActivity activity)
        {
            ActivityList.Add(activity);
        }
    }
}