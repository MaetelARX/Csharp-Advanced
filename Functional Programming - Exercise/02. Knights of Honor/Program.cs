string[] names = Console.ReadLine().Split(" ").ToArray();

Action<string[]> action = names =>
{
    foreach(var item in names)
    {
        Console.WriteLine($"Sir {item}");
    }
};
action(names);