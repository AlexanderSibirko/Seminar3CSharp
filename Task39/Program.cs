// 39. Найти произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д.

// метод произведения числе в массиве спереди и сзади

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

int[] multStartEnd(int[] arr)
{
    int len = arr.Length;
    int[] resultMults = new int[len / 2];
    for (int i = 0; i < len / 2; i++)
    {
        resultMults[i] = arr[i] * arr[len - i -1 ];
    }
    return resultMults;
}

int[] yarr = CreateFilledIntArray(10, -10, 10);
Console.WriteLine(PrintArray(yarr));

int[] multsyarr = multStartEnd(yarr);
Console.WriteLine(PrintArray(multsyarr));
