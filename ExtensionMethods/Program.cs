using System;

namespace ExtensionMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            var post = "This is a supposed to be a very long blog post blah blah blah";

            var shortenedPost = post.Shorten(5);
            Console.WriteLine(shortenedPost);
        }
    }
}
