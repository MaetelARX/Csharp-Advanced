int n = int.Parse(Console.ReadLine());

Dictionary<int, int>input  = new Dictionary<int, int>();

int count = 0;

for (int i = 0; i < n; i++)
{
    int number = int.Parse(Console.ReadLine());
    if (!input.ContainsKey(number))
    {
        input.Add(number, 0);
    }
    input[number]++;
}
int even = input.Single(n => n.Value % 2 == 0).Key;
Console.WriteLine(even);