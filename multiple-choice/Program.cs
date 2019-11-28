using System;

namespace multiple_choice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("what is your name?");
            var name = Console.ReadLine();

            Console.WriteLine("what is age?");
            var age = Console.ReadLine();

            Console.WriteLine("what is birth month?");
            var month = Console.ReadLine();

            // we use a string formatter to output the name
            Console.WriteLine("Your name is {0}", name);
            Console.WriteLine("Your age is {0}", age);
            Console.WriteLine("Your birth month is {0}", month);
        }
    }
}
