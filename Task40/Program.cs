// 40. В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом 

// находим минимальный, находим максимальный, находим разницу => массив double - вещественные числа

double DoubleRndNum(double min, double max) => new Random().NextDouble() * (max - min) + min;

double[] CreateFilledDoubleArray(int count, double minValue, double maxValue)
{
    double[] array = new double[count];
    for (int i = 0; i < count; i++)
    {
        array[i] = DoubleRndNum(minValue, maxValue);
    }
    return array;
}

string PrintArray(double[] array)
{
    int count = array.Length;
    string result = String.Empty;
    for (int i = 0; i < count; i++)
    {
        result += $"{array[i]} ";
    }
    return result;
}

double FindMin(double[] arr) //если массив пустой возвращаем 0.0
{
    int len = arr.Length;
    if (len == 0) { return 0.0; }

    double min = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] < min)
        {
            min = arr[i];
        }
    }
    return min;
}

double FindMax(double[] arr) //если массив пустой возвращаем 0.0
{
    int len = arr.Length;
    if (len == 0) { return 0.0; }

    double max = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] > max)
        {
            max = arr[i];
        }
    }
    return max;
}

double FindMaxMinDiff(double[] arr)
{
    return FindMax(arr) - FindMin(arr);
}
double[] testArr = CreateFilledDoubleArray(10, -10.5, 20.65465);
Console.WriteLine(PrintArray(testArr));
Console.WriteLine(FindMaxMinDiff(testArr));