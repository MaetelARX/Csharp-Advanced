List<int> numbers = Console.ReadLine().Split(", ").Select(int.Parse).ToList();

numbers = numbers.Where(x => x % 2 == 0).OrderBy(x => x).ToList();

Console.WriteLine(string.Join(", ", numbers));