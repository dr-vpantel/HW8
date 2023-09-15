// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.
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

int[] RowSumArray(int[,] matrix)
{

    int[] array = new int[matrix.GetLength(0)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int sumNum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sumNum = sumNum + matrix[i, j];
        }
        array[i] = sumNum;
    }
    return array;
}

int MinSumRowIndex(int[] arr)
{
    int min = arr[0];
    int k = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (min > arr[i])
        {
            min = arr[i];
            k = i;
        }
    }
    return k;
}

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.Write("]");
}

int[,] matrix = CreateMatrixRndInt(4, 4, 0, 10);
PrintMatrix(matrix);

int[] array = RowSumArray(matrix);
Console.Write("Суммы элементов в строках:");
PrintArray(array);

int minSumRowIndex = MinSumRowIndex(array);
Console.WriteLine();
Console.WriteLine($"Строка с наименьшей суммой элементов - {minSumRowIndex + 1}");
