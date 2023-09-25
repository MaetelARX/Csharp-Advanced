List<double> numbers = Console.ReadLine().Split().Select(double.Parse).ToList();

Dictionary<double, int> numberCount = new Dictionary<double, int>();

foreach (var item in numbers)
{
    if (!numberCount.ContainsKey(item))
    {
        numberCount.Add(item, 1);
    }
    else
    {
        numberCount[item]++;
    }
}
foreach (var item in numberCount)
{
    Console.WriteLine($"{item.Key} - {item.Value} times");
}