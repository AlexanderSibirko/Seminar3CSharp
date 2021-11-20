// 37. В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]

// метод пробежка по массиву и поиск по двойному условию (а если бы массив был отсортирован, можно было бы прерваться не перебирая все 123)

int[] CreateFilledIntArray(int count, int minValue, int maxValue)
{
    int[] array = new int[count];
    for (int i = 0; i < count; i++)
    {
        array[i] = new Random().Next(minValue, maxValue);
    }
    return array;
}

string PrintArray(int[] array)
{
    int count = array.Length;
    string result = String.Empty;
    for (int i = 0; i < count; i++)
    {
        result += $"{array[i]} ";
    }
    return result;
}

int calcFoundMinMax(int[] arr, int lookmin, int lookmax)
{
    int count = 0;
    for (int i = 0 ; i < arr.Length; i++)
    {
        if (arr[i] >= lookmin && arr[i] <= lookmax)
        {
            count++;
        }
    }
    return count;
}

int[] TestSmall = CreateFilledIntArray(10,0,200);
Console.WriteLine(PrintArray(TestSmall));
Console.WriteLine(calcFoundMinMax(TestSmall,10,99));

int[] fulltest = CreateFilledIntArray(123,-100,200);
Console.WriteLine(PrintArray(fulltest));
Console.WriteLine(calcFoundMinMax(fulltest,10,99));