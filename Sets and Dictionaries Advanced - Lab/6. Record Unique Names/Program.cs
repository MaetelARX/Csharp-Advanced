int count = int.Parse(Console.ReadLine());

HashSet<string> set = new HashSet<string>();

for(int i = 0; i < count; i++)
{
    set.Add(Console.ReadLine());
}
foreach(var item in set)
{
    Console.WriteLine(item);
}