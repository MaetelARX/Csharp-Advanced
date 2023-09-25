int[] n = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

int rows = n[0];
int cols = n[1];

int num1 = 0;
int num2 = 0;
int num3 = 0;
int num4 = 0;

int sum = 0;

int[,] matrix = new int[rows, cols];

for (int row = 0; row < rows; row++)
{
    int[] input = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

    for (int col = 0; col < cols; col++)
    {
        matrix[row, col] = input[col];
    }
}
for (int row = 0; row < rows - 1; row++)
{
    for (int col = 0; col < cols - 1; col++)
    {
        if (matrix[row,col] + matrix[row , col + 1] + matrix[row + 1, col] +matrix[row + 1, col + 1] > sum)
        {
            num1 = matrix[row, col];
            num2 = matrix[row, col + 1];
            num3 = matrix[row + 1, col];
            num4 = matrix[row + 1, col + 1];
            sum = matrix[row, col] + matrix[row, col + 1] + matrix[row + 1, col] + matrix[row + 1, col + 1];
        }
    }
}
Console.WriteLine($"{num1} {num2}");
Console.WriteLine($"{num3} {num4}");
Console.WriteLine(sum);
