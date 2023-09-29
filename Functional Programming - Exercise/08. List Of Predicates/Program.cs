using System;

List<Predicate<int>> predicate = new List<Predicate<int>>();

int n = int.Parse(Console.ReadLine());

HashSet<int> input = Console.ReadLine().Split().Select(int.Parse).ToHashSet();

foreach (var item in input)
{
    predicate.Add(n => n % item == 0);
}

int[] numbers = Enumerable.Range(1, n).ToArray();

foreach (var number in numbers)
{
    bool isDivisible = true;

    foreach (var match in predicate)
    {
        if (!match(number))
        {
            isDivisible = false;
            break;
        }
    }

    if (isDivisible)
    {
        Console.Write($"{number} ");
    }
}