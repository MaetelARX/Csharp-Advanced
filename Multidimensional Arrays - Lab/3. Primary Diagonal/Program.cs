﻿int n = int.Parse(Console.ReadLine());

int[,] matrix = new int[n, n];

int sum = 0;

for (int row = 0; row < n; row++)
{
    int[] input = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

    for (int col = 0; col < n; col++)
    {
        matrix[row,col] = input[col];
    }
}

for (int i = 0; i < matrix.GetLength(0); i++)
{
    sum += matrix[i,i];
}
Console.WriteLine(sum);