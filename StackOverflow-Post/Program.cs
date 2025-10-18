using System;
namespace StackOverflow
{
    class Program
    {
        static void Main(string[] args)
        {
            //create a new post
            var post = new Post("How to implement a voting system in C#?", "I want to create a simple voting system for posts in C#. How can I do that?");
            
            // up-vote the post
            post.UpVote();
            
            // down-vote the post
            post.DownVote();

            // multiple up-votes
            post.UpVote();
            post.UpVote();
            post.UpVote();
            post.UpVote();

            // display the post details (votes, title, description, created at)
            Console.WriteLine(post.ToString());
        }
    }
}