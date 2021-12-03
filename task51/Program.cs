// 51. Задать двумерный массив следующим правилом: Aₘₙ = m+n

int[,] CreateArray(int rowsCount, int columnsCount)
{
    return new int[rowsCount, columnsCount];
}

int[,] Fill2DArrayByRule(int[,] array2D) //заполняем массив из диапозона [minValue..maxValue]
{
    for (int i = 0; i < array2D.GetLength(0); i++)
    {
        for (int j = 0; j < array2D.GetLength(1); j++)
        {
            array2D[i, j] = i+j;
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

int m = 5;
int n= 5;
int[,] testArray = CreateArray(m, n);
Fill2DArrayByRule(testArray);
Console.WriteLine(Print2DArray(testArray));