using System;

namespace StackOverFlowPost

{
    class Program
    {
        static void Main(string[] args)
        {
            var post = new StOvPost("test title", "test description");

            Console.WriteLine(@"Type 'upvote'or 'downvote' the post or 'quit' to end the program ");
            var input = Console.ReadLine().ToLower();

            while(true)
            {
                if (input == "upvote")
                {
                    post.UpVote();
                    Console.WriteLine(@"Type 'upvote'or 'downvote' the post or 'quit' to end the program ");
                    input = Console.ReadLine().ToLower();
                }
                else if (input == "downvote")
                {
                    post.DownVote();
                    Console.WriteLine(@"Type 'upvote'or 'downvote' the post or 'quit' to end the program ");
                    input = Console.ReadLine().ToLower();
                }
                else if (input == "quit")
                {
                    post.display();
                    break;
                }
            }
        }
    }
}
