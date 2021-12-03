// 55. Дан целочисленный массив. Найти среднее арифметическое каждого из столбцов.

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
            print += $"{array2D[i, j],6} "; //выравнивание по 6 знаков
        }
        print += '\n';
    }
    return print;
}

double[] meanOfColumns(int[,] array2D)
{
    int rowCount = array2D.GetLength(0);
    int colCount = array2D.GetLength(1);
    double[] result = new double[colCount];
    for (int j =0; j < colCount; j++)
    {
        int sum = 0;
        for (int i = 0; i < rowCount; i++)
        {
            sum += array2D[i,j];
        }
        result[j] = (double)sum/(rowCount);
    }
    return result;
}

int i = 5;
int j = 10;
int[,] testArray = CreateArray(i, j);
Fill2DArray(testArray, 0, 10);
Console.WriteLine(Print2DArray(testArray));
double[] means = meanOfColumns(testArray);
Console.WriteLine(string.Join("|",means));

