Action<string[]> name = SomeMethod;

string[] input = Console.ReadLine().Split().ToArray();

name(input);

static void SomeMethod(string[] newLine)
{
    foreach (var line in newLine)
    {
        Console.WriteLine(line);
    }
}