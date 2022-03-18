// See https://aka.ms/new-console-template for more information


namespace PracticeConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.BackgroundColor = ConsoleColor.Green;
            Console.WriteLine("Second line written and colour changed to green?");
            Console.Read();
        }
    }
}