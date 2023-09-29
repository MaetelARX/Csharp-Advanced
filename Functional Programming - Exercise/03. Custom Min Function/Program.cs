int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

Func<int[], int> small = input => input.Min();

Console.WriteLine(small(input));