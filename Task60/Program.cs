// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, 
// добавляя индексы каждого элемента.

int[,,] CreateCubeInt(int rows, int columns, int depth, int min, int max)
{
    if (min >= 10 && max <= 99)
    {
        int[,,] cube = new int[rows, columns, depth];
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                for (int k = 0; k < depth; k++)
                {
                    cube[i, j, k] = min++;
                }
            }
        }
        return cube;
    }
    else
    {
        Console.WriteLine("Числа не двузначные");
        return null;
    }
}

void PrintCube(int[,,] arr)
{
    int rows = arr.GetLength(0);
    int columns = arr.GetLength(1);
    int depth = arr.GetLength(2);

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            for (int k = 0; k < depth; k++)
            {
                 Console.Write($"{arr[i, j, k]}({i},{j},{k}) ");
            }
        }
        Console.WriteLine();
    }
}

int[,,] array3d = CreateCubeInt(2, 2, 2, 10, 99);
PrintCube(array3d);