// Задача 58: Задайте две матрицы. Напишите программу, 
// которая будет находить произведение двух матриц.

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rand = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            matrix[i, j] = rand.Next(min, max + 1);
        }
    }
    return matrix;
}
void PrintMatrix(int[,] arr)
{
    int rows = arr.GetLength(0);
    int columns = arr.GetLength(1);

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write($"{arr[i, j],5}");
        }
        Console.WriteLine();
    }
}

int[,] MultiplyMatrix(int[,] firstMtr, int[,] secondMtr)
{
    int newRow = 0;
    int newCol = 0;
    if (firstMtr.GetLength(0) > secondMtr.GetLength(0))
    {
        newRow = secondMtr.GetLength(0);
    }
    else
    {
        newRow = firstMtr.GetLength(0);
    }
    if (firstMtr.GetLength(1) > secondMtr.GetLength(1))
    {
        newCol = secondMtr.GetLength(1);
    }
    else
    {
        newCol = firstMtr.GetLength(1);
    }

    int[,] newMatrix = new int[newRow, newCol];

    for (int i = 0; i < newRow; i++)
    {
        for (int j = 0; j < newCol; j++)
        {
            for (int k = 0; k < newRow; k++)
            {
                newMatrix[i, j] += firstMtr[i, k] * secondMtr[k, j];
            }
        }
    }
    return newMatrix;
}

int[,] firstMatrix = CreateMatrixRndInt(3, 3, 0, 10);
PrintMatrix(firstMatrix);
Console.WriteLine();

int[,] secondMatrix = CreateMatrixRndInt(3, 3, 0, 10);
PrintMatrix(secondMatrix);
Console.WriteLine();

if (firstMatrix.GetLength(1) != secondMatrix.GetLength(0))
{
    Console.WriteLine("Невозможно умножить матрицы");
    return;
}

int[,] resultMatrix = MultiplyMatrix(firstMatrix, secondMatrix);
PrintMatrix(resultMatrix);