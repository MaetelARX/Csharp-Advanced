int n = int.Parse(Console.ReadLine());
string[,] matrix = new string[n, n];

for (int row = 0; row < n; row++)
{
    string text = Console.ReadLine();

    for (int col = 0; col < text.Length; col++)
    {
        matrix[row, col] += text[col];
    }
}

string symbol = Console.ReadLine();

for (int row = 0; row < n; row++)
{
    for (int col = 0; col < n; col++)
    {
        if (matrix[row, col] == symbol)
        {
            Console.WriteLine($"({row}, {col})");
            return;
        }
    }
}
Console.WriteLine($"{symbol} does not occur in the matrix");
