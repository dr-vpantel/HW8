// Задача 54: Задайте двумерный массив. Напишите программу, 
// которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2
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

// void SortRowElements(int[,] mtr)
// {
//     for (int i = 0; i < mtr.GetLength(0); i++)
//     {
//         for (int j = 0; j < mtr.GetLength(1); j++)
//         {
//             for (int k = 0; k < mtr.GetLength(1) - 1; k++)
//             {
//                 if (mtr[i, k] < mtr[i, k + 1])
//                 {
//                     int temp = mtr[i, k + 1];
//                     mtr[i, k + 1] = mtr[i, k];
//                     mtr[i, k] = temp;
//                 }
//             }
//         }
//     }
// }
void SortRowElements(int[,] mtr)
{
    for (int i = 0; i < mtr.GetLength(0); i++)
    {
        for (int j = 0; j < mtr.GetLength(1); j++)
        {
            for (int k = 0; k < mtr.GetLength(1) - 1; k++)
            {
                if (mtr[i, k] < mtr[i, k + 1])
                {
                    int temp = mtr[i, k + 1];
                    mtr[i, k + 1] = mtr[i, k];
                    mtr[i, k] = temp;
                }
            }
        }
    }
}

int[,] matrix = CreateMatrixRndInt(5, 5, 0, 10);
PrintMatrix(matrix);
Console.WriteLine();
SortRowElements(matrix);
PrintMatrix(matrix);