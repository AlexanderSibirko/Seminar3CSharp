// 49. Показать двумерный массив размером m×n заполненный вещественными числами

double[,] CreateDoubleArray(int rowsCount, int columnsCount)
{
    return new double[rowsCount, columnsCount];
}

double DoubleRandomNumber(double minValue, double maxValue) => new Random().NextDouble() * (maxValue - minValue) + minValue;

double[,] FillDouble2DArray(double[,] array2D, double minValue, double maxValue) //заполняем массив из диапозона [minValue..maxValue]
{
    for (int i = 0; i < array2D.GetLength(0); i++)
    {
        for (int j = 0; j < array2D.GetLength(1); j++)
        {
            array2D[i, j] = DoubleRandomNumber(minValue, maxValue);
        }
    }
    return array2D;
}

string PrintDouble2DArray(double[,] array2D, int roundValue)
{
    string print = string.Empty;
    for (int i = 0; i < array2D.GetLength(0); i++)
    {
        for (int j = 0; j < array2D.GetLength(1); j++)
        {
            print += $"{Math.Round(array2D[i, j], roundValue),8} "; //выравнивание по 5 знаков
        }
        print += '\n';
    }
    return print;
}

int m = 5;
int n = 5;

double[,] testArray = CreateDoubleArray(m, n);
FillDouble2DArray(testArray, -10.0, 10.0);
Console.WriteLine(PrintDouble2DArray(testArray, 3));