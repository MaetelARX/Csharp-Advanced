Func<string, double> predic = s => double.Parse(s);
Func<double, double> Vat = x => x * 1.20;

List<double> input = Console.ReadLine().Split(", ").Select(predic).Select(Vat).ToList();

foreach(var item in input)
{
    Console.WriteLine($"{item:f2}");
}