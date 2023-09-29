int n = int.Parse(Console.ReadLine());

Dictionary<string, int> input = new Dictionary<string, int>();

for (int i = 0; i < n; i++)
{
    List<string> info = Console.ReadLine().Split(", ").ToList();

    string name = info[0];
    int years = int.Parse(info[1]);

    input[name] = years;
}
string command = Console.ReadLine();
int age = int.Parse(Console.ReadLine());
string format = Console.ReadLine();

if(command == "older")
{
    if (format == "age")
    {
        foreach (var item in input)
        {
            if (item.Value >= age)
            {
                Console.WriteLine(item.Value);
            }
        }
    }
    else if (format == "name")
    {
        foreach (var item in input)
        {
            if (item.Value >= age)
            {
                Console.WriteLine(item.Key);
            }
        }
    }
    else if (format == "name age")
    {
        foreach (var item in input)
        {
            if (item.Value >= age)
            {
                Console.WriteLine($"{item.Key} - {item.Value}");
            }
        }
    }
}
else if (command == "younger")
{
    if (format == "age")
    {
        foreach (var item in input)
        {
            if (item.Value < age)
            {
                Console.WriteLine(item.Value);
            }
        }
    }
    else if (format == "name")
    {
        foreach (var item in input)
        {
            if (item.Value < age)
            {
                Console.WriteLine(item.Key);
            }
        }
    }
    else if (format == "name age")
    {
        foreach (var item in input)
        {
            if (item.Value < age)
            {
                Console.WriteLine($"{item.Key} - {item.Value}");
            }
        }
    }
}