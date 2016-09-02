using System;
using System.Linq;

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

    public static class StringExtensions
    {
        public static string Shorten(this string str, int numberOfWords)
        {
            if (numberOfWords == 0)
            {
                return "";
            }

            var words = str.Split(' ');
            if (words.Length <= numberOfWords)
            {
                return str;
            }

            return string.Join(" ", words.Take(numberOfWords)) + "......";
        }
    }
}
