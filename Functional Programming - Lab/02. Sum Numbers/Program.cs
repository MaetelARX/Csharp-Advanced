List<int> numbers = Console.ReadLine().Split(", ").Select(int.Parse).ToList();

int sum = 0;
int count = 0;

foreach (var number in numbers)
{
    count ++;
    sum += number;
}
Console.WriteLine($"{count}\n{sum}");