using System;

namespace Advanced
{
    class Program
    {
        static void Main(string[] args)
        {
            var nullableType = new Nullable<int>();

            Console.WriteLine(nullableType.GetValueOrDefault());


        }
    }
}
