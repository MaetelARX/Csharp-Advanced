int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

int rows = input[0];
int cols = input[1];

int num1 = 0;
int num2 = 0;
int num3 = 0;
int num4 = 0;
int num5 = 0;
int num6 = 0;
int num7 = 0;
int num8 = 0;
int num9 = 0;

int[,] matrix = new int[rows, cols];

int sum = 0;

for (int row = 0; row < rows; row++)
{
    string[] numbers = Console.ReadLine().Split().ToArray();

    for (int col = 0; col < cols; col++)
    {
        matrix[row, col] = int.Parse(numbers[col]);
    }
}

for (int row = 0; row < rows - 2; row++)
{
    for (int col = 0; col < cols - 2; col++)
    {
        if (matrix[row, col] + matrix[row, col + 1]
                + matrix[row, col + 2] + matrix[row + 1, col]
                + matrix[row + 1, col + 1] + matrix[row + 1, col + 2]
                + matrix[row + 2, col] + matrix[row + 2, col + 1]
                + matrix[row + 2, col + 2] > sum)
        {
            sum = matrix[row, col] + matrix[row, col + 1]
                + matrix[row, col + 2] + matrix[row + 1, col]
                + matrix[row + 1, col + 1] + matrix[row + 1, col + 2]
                + matrix[row + 2, col] + matrix[row + 2, col + 1]
                + matrix[row + 2, col + 2];

            num1 = matrix[row, col];
            num2 = matrix[row, col + 1];
            num3 = matrix[row, col + 2];
            num4 = matrix[row + 1, col];
            num5 = matrix[row + 1, col + 1];
            num6 = matrix[row + 1, col + 2];
            num7 = matrix[row + 2, col];
            num8 = matrix[row + 2, col + 1];
            num9 = matrix[row + 2, col + 2];
        }

    }
}
Console.WriteLine($"Sum = {sum}");
Console.WriteLine($"{num1} {num2} {num3}");
Console.WriteLine($"{num4} {num5} {num6}");
Console.WriteLine($"{num7} {num8} {num9}");