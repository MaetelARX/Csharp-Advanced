int[] rowsCols = Console.ReadLine().Split().Select(int.Parse).ToArray();

int rows = rowsCols[0];
int cols = rowsCols[1];

string[,] matrix = new string[rows, cols];

for (int row = 0; row < rows; row++)
{
    string[] input = Console.ReadLine().Split().ToArray();

    for(int col = 0; col < cols; col++)
    {
        matrix[row, col] = input[col];
    }
}

string[] command = Console.ReadLine().Split().ToArray();

while(command[0] != "END")
{
    if (command.Contains("swap") && command.Length == 5)
    {
        int row1 = int.Parse(command[1]);
        int col1 = int.Parse(command[2]);
        int row2 = int.Parse(command[3]);
        int col2 = int.Parse(command[4]);

        if (row1 + 1 <= rows && col1 + 1 <= cols && row2 + 1 <= rows && col2 + 1 <= cols)
        {
            string input1 = matrix[row1, col1];
            string input2 = matrix[row2, col2];

            matrix[row1, col1] = input2;
            matrix[row2, col2] = input1;

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; ++col)
                {
                    Console.Write($"{matrix[row, col]} ");
                }
                Console.WriteLine();
            }
        }
        else
        {
            Console.WriteLine("Invalid input!");
        }
    }
    else
    {
        Console.WriteLine("Invalid input!");
    }
    command = Console.ReadLine().Split().ToArray();
}