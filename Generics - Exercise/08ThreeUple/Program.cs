namespace _08ThreeUple
{
    public class StartUp
    {
        static void Main()
        {
            string[] names = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string[] beers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string[] last = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            ThreeUple<string, string,string> Names = new($"{names[0]} {names[1]}", names[2], string.Join(" ",names[3..]));
            ThreeUple<string, int, bool> Beers = new($"{beers[0]}", int.Parse(beers[1]), beers[2] == "drunk");           
            ThreeUple<string, double, string> Last = new($"{last[0]}", double.Parse(last[1]), last[2]);

            Console.WriteLine(Names.ToString());
            Console.WriteLine(Beers);
            Console.WriteLine(Last);            
        }
    }
}