// 54. В матрице чисел найти сумму элементов главной диагонали

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
            print += $"{array2D[i, j],6} "; //выравнивание по 8 знаков
        }
        print += '\n';
    }
    return print;
}

int MainDiagonalSum(int[,] array2D)
{
    int sum = 0;
    for (int i = 0; i < array2D.GetLength(0); i++)
    {
        for (int j = 0; j < array2D.GetLength(1); j++)
        {
            if (i == j) sum += array2D[i,j];
        }
    }
    return sum;
}

int n = 6;
int k = 8;
int[,] testArray = CreateArray(n, k);
Fill2DArray(testArray, -10, 10);
Console.WriteLine(Print2DArray(testArray));
Console.WriteLine(MainDiagonalSum(testArray));
