int n = int.Parse(Console.ReadLine());

SortedSet<string> set = new SortedSet<string>();

for (int i = 0; i < n; i++)
{
    List<string> list = Console.ReadLine().Split().ToList();

    for (int j = 0; j < list.Count; j++)
    {
        set.Add(list[j]);
    }
}
Console.WriteLine(string.Join(" ", set));