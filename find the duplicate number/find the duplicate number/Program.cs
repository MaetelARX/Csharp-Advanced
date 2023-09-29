using System.Text;

List<string> input = Console.ReadLine().Split().ToList();

var ordered = input.OrderBy(x => x).ToList();

StringBuilder sb = new StringBuilder();

Console.WriteLine(string.Join(" ", ordered));

for (int i = 1; i < ordered.Count; i++)
{
    if (ordered[i] == ordered[i - 1])
    {
        sb.Append(ordered[i] + " ");
    }
}
Console.WriteLine(sb);