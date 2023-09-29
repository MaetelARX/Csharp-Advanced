int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

string command = Console.ReadLine();

Func<int[], int> add = Add;
Func<int[], int> multiply = Multiply;
Func<int[], int> subtract = Subtract;

while (command != "end")
{
    if (command == "add")
    {
        Add(input);
    }
    else if (command == "multiply")
    {
        Multiply(input);
    }
    else if (command == "subtract")
    {
        Subtract(input);
    }
    else if (command == "print")
    {
        Console.WriteLine(string.Join(" ", input));
    }
    command = Console.ReadLine();
}

static int Add(int[] input)
{
    for (int i = 0; i < input.Length; i++)
    {
        input[i] += 1;
    }
    return 0;
}
static int Subtract(int[] input)
{
    for (int i = 0; i < input.Length; i++)
    {
        input[i] -= 1;
    }
    return 0;
}
static int Multiply(int[] input)
{
    for (int i = 0; i < input.Length; i++)
    {
        input[i] *= 2;
    }
    return 0;
}