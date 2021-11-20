// 40. В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом 

// находим минимальный, находим максимальный, находим разницу => массив double - вещественные числа

double DoubleRndNum (double min, double max) => new Random().NextDouble()*(max-min)+min;

double[] CreateFilledIntArray(int count, double minValue, double maxValue)
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

double findMin(double[] arr)
{
    double min = 0.0;
    return min;
}

double findMax(double[] arr)
{
    double max = 0.0;
    return max;
}