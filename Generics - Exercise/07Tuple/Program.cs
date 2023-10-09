using System.ComponentModel;
using System.Text;

namespace _07Tuple
{
    public class StartUp
    {
        static void Main()
        {
            string[] names = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string[] beers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string[] last = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            Tuple<string, string> Names = new($"{names[0]} {names[1]}", names[2]);
            Tuple<string, int> Beers = new($"{beers[0]}", int.Parse(beers[1]));
            Tuple<int, double> Last = new(int.Parse(last[0]), double.Parse(last[1]));

            Console.WriteLine(Names);
            Console.WriteLine(Beers);
            Console.WriteLine(Last);
        }
    }
}