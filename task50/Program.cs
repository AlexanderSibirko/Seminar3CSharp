// 50. В двумерном массиве n×k заменить четные элементы на противоположные

int[,] CreateArray(int rowsCount, int columnsCount)
{
    return new int[rowsCount, columnsCount];
}

int[,] Fill2DArray(int[,] array2D, int minValue, int maxValue) //заполняем массив из диапозона [minValue..maxValue]
{
    for (int i = 0; i < array2D.GetLength(0); i++)
    {
        for (int j = 0; j < array2D.GetLength(1); j++)
        {
            array2D[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return array2D;
}

string Print2DArray(int[,] array2D)
{
    string print = string.Empty;
    for (int i = 0; i < array2D.GetLength(0); i++)
    {
        for (int j = 0; j < array2D.GetLength(1); j++)
        {
            print += $"{array2D[i, j],8} "; //выравнивание по 5 знаков
        }
        print += '\n';
    }
    return print;
}

int n = 5;
int k = 8;
int[,] testArray = CreateArray(n, k);
Fill2DArray(testArray, -10, 10);
Console.WriteLine(Print2DArray(testArray));



int[,] RevertEvenNumbers2(int[,] array2D)
{
    for (int i = 0; i < array2D.GetLength(0); i++)
    {
        for (int j = 0; j < array2D.GetLength(1); j++)
        {
            if (array2D[i, j] % 2 == 0)
            {
                array2D[i,j] = -array2D[i,j];
            }
        }
    }
    return array2D;
}

Console.WriteLine(Print2DArray(
                            RevertEvenNumbers2(testArray)
                            ));