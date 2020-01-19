using System;
using System.Runtime.CompilerServices;

namespace CSharp_Course_Intermediate
{
    class Program
    {
        static void Main(string[] args)
        {
            var post = new Post
            {
                Title = "new post1",
                Description = "hiiiiiiiiiiiiiii",
                Date = DateTime.Now
            };
            int votes;
            post.UpVote();
           post.UpVote();
            post.UpVote();
            post.UpVote();
            
            votes = post.DownVote();
            Console.WriteLine(votes);
        }

    }
}
