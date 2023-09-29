int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

string command = Console.ReadLine();

Predicate<int> isEven = number => number % 2 == 0;
Predicate<string> isEvenCommand = x => x == "even";

for (int i = input[0]; i <= input[1]; i++)
{
    if (isEven(i) && isEvenCommand(command))
    {
        Console.Write($"{i} ");
    }
    else if (!isEven(i) && !isEvenCommand(command))
    {
        Console.Write($"{i} ");
    }
}
