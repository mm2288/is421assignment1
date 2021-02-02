using System;

namespace is421assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Megan!");

            Console.WriteLine("Press ESC key to exit command line.");

            var key = Console.ReadKey();

            if (key.Key == ConsoleKey.Escape)
            {
                Environment.Exit(0);
            }
        }
    }
}
