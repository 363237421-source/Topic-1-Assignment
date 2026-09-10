using System.Threading.Channels;

namespace Topic_1_Assignment //Said
{
    internal class Program
    {
        static void Main(string[] args)
        {
          

            Console.WriteLine("Hello!");  //Code to write Hello! to the console.
            Console.WriteLine("My name is Said and this is my first C# assignment!");
            Console.WriteLine("");
            Console.WriteLine("Two reasons why comments are used are because they help explain the code and they can be used to temporarily disable code.");
            Console.WriteLine("");
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(" SSS    SSS");
            Console.WriteLine("S   S  S   S");
            Console.WriteLine("S      S    ");
            Console.WriteLine(" SSS    SSS");
            Console.WriteLine("    S      S");
            Console.WriteLine("S   S  S   S");
            Console.WriteLine(" SSS    SSS");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("");
            Console.WriteLine("Press Enter to continue... (Also try to press a different key)");
            if (Console.ReadKey(true).Key == ConsoleKey.Enter)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("You pressed Enter!");
            }
            else
            {
                Console.ReadKey(false);
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("You did not press Enter!");

            }
                Console.WriteLine("Press any key to exit.");
        }
    }
}
