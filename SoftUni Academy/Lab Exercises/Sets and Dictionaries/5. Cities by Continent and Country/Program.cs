using System.Threading.Channels;

int n = int.Parse(Console.ReadLine());

Dictionary<string, Dictionary<string, List<string>>> input = new Dictionary<string, Dictionary<string, List<string>>>();

for (int i = 0;  i < n; i++)
{
    string[] text = Console.ReadLine().Split();
    string continent = text[0];
    string country = text[1];
    string city = text[2];

    if (!input.ContainsKey(continent))
    {
        input.Add(continent, new Dictionary<string, List<string>>());
    }
    if (!input[continent].ContainsKey(country))
    {
        input[continent].Add(country, new List<string>());
    }
    input[continent][country].Add(city);
}
foreach(var item in input)
{
    Console.WriteLine($"{item.Key}:");
    foreach(var output in item.Value)
    {
        Console.WriteLine($"{output.Key} -> {string.Join(", ", output.Value)}");
    }
}