using System;

namespace CSharp_Course_Intermediate
{
    public class Post
    {

        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        private int Votes { get; set; }

        public Post()
        {
        }

        public int UpVote()
        {
            return ++Votes;
        }

        public int DownVote()
        {
            return --Votes;
        }
    }
}