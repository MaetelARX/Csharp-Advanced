int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

int n = input[0];
int m = input[1];

HashSet<int> set = new HashSet<int>();
HashSet<int> result = new HashSet<int>();

for (int i = 0; i < n; i++)
{
    set.Add(int.Parse(Console.ReadLine()));
}
for (int j = 0; j < m; j++)
{
    result.Add(int.Parse(Console.ReadLine()));
}
set.IntersectWith(result);
Console.WriteLine(string.Join(" ", set));