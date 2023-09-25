int [] n = Console.ReadLine().Split().Select(int.Parse).ToArray();

int rows = n[0];
int cols = n[1];

int sum = 0;

string[,] matrix = new string[rows, cols];

for (int row = 0; row < rows; row++)
{
    string [] input = Console.ReadLine().Split(" ").ToArray();

    for (int col = 0; col < cols; col++)
    {
        matrix[row, col] = input[col];
    }
}
for (int row = 0; row < rows - 1; row++)
{
    for (int col = 0; col < cols - 1; col++)
    {
        string current = matrix[row, col];
        if (matrix[row, col] == current && matrix[row, col + 1] == current && matrix[row + 1, col] == current && matrix[row + 1, col + 1] == current)
        {
            sum++;
        }
    }
}
Console.WriteLine(sum);