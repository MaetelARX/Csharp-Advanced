int n = int.Parse(Console.ReadLine());

Dictionary<string, Dictionary<string,int>> colorsClothes = new Dictionary<string, Dictionary<string, int>>();

for (int i = 0; i < n; i++)
{
    string[] input = Console.ReadLine().Split(new string[] { " -> ", "," }, StringSplitOptions.RemoveEmptyEntries);

    string color = input[0];

    if (!colorsClothes.ContainsKey(color))
    {
        colorsClothes.Add(color, new Dictionary<string, int>());
    }

    for (int j = 1;  j < input.Length; j++)
    {
        string current = input[j];

        if (!colorsClothes[color].ContainsKey(current))
        {
            colorsClothes[color].Add(current, 0);
        }

        colorsClothes[color][current]++;
    }
}

string[] find = Console.ReadLine().Split();

foreach(var item in colorsClothes)
{       
    Console.WriteLine($"{item.Key} clothes:");
    foreach(var output in item.Value)
    {
        string color = find[0];
        string wear = find[1];
        string print = $"* {output.Key} - {output.Value}";
        if (item.Key == color && output.Key == wear)
        {
            print += " (found!)";
        }
        Console.WriteLine(print);
    }
}