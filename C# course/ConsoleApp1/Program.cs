namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string name;

            Console.Title = "Let's meet...";
            Console.WriteLine("What's your name?");
            name = Console.ReadLine();

            string txt = $"Nice to meet you {name}!";
            Console.Title = "We are friends!";
            Console.WriteLine(txt);

            Console.ReadKey();

        }
    }
}
