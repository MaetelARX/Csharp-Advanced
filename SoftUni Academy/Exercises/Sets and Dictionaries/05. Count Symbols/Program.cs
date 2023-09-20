string input = Console.ReadLine();

char[] symbol = input.ToCharArray();

SortedDictionary<char,int>result = new SortedDictionary<char,int>();

for (int i = 0; i < input.Length; i++)
{
    char c = symbol[i];
    if (!result.ContainsKey(symbol[i]))
    {
        result.Add(c, 1);
    }
    else
    {
        result[symbol[i]]++;
    }
}
foreach (var item in result)
{
    Console.WriteLine($"{item.Key}: {item.Value} time/s");
}