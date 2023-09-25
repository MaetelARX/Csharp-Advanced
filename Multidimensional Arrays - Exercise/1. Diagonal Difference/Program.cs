int n = int.Parse(Console.ReadLine());

int[,] matrix = new int[n, n];

int firstDiagonal = 0;
int secondDiagonal = 0;

int sum = 0;

for (int row = 0; row < n; row++)
{
    int[] input = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

    for (int col = 0; col < n; col++)
    {
        matrix[row, col] = input[col];
    }
}

for (int i = 0; i < matrix.GetLength(0); i++)
{
    firstDiagonal += matrix[i, i];
}

for (int i = matrix.GetLength(0) -1; i >= 0; i--)
{
    secondDiagonal += matrix[i, n - 1 - i];
}

if (firstDiagonal > secondDiagonal)
{
    sum += firstDiagonal - secondDiagonal;
}
else
{
    sum += secondDiagonal - firstDiagonal;
}
Console.WriteLine(sum);