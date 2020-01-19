using System;

namespace CSharp_Course_Intermediate
{
    public class StopWatch
    {
        public TimeSpan TimeSpan { get; private set; }
        private DateTime StarTTime { get; set; }

        private DateTime StopTime { get; set; }

        public void Start()
        {
            try
            {
                this.StarTTime = DateTime.Now;

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public void Stop()
        {
            try
            {
                this.StopTime = DateTime.Now;
                TimeSpan = StopTime - StarTTime;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public StopWatch()
        {
            this.TimeSpan = new TimeSpan();
            this.StarTTime = new DateTime();
            this.StopTime = new DateTime();
        }

    }
}