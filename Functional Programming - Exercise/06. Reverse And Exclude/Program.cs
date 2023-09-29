using System.Linq;

var input = Console.ReadLine()
                .Split(new char[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse);

int n = int.Parse(Console.ReadLine());

Func<int, bool> x = x => x % n != 0;

var numbers = input.Reverse().Where(x);

Console.WriteLine(string.Join(" ", numbers));