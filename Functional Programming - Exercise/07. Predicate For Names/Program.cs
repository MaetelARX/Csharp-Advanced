int n = int.Parse(Console.ReadLine());

string[] names = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();

Func<string, bool> isValid = func => func.Length <= n;

foreach(string name in names)
{
    if (isValid(name))
    {
        Console.WriteLine(name);
    }
}