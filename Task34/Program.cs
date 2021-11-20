// 34. Написать программу замену элементов массива на противоположные

// к задачам 31-33, дописать метод замены элементов массива на противоположные по знаку


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

int[] reverseSign(int[] arr)
{
    int len = arr.Length;    
    int[] arrgh = new int[len];
    for (int i = 0; i < len; i++)
    {
        arrgh[i] = -arr[i];
    }
    return arrgh;
}

int[] TestArr = CreateFilledIntArray(10,-10,11);
Console.WriteLine(PrintArray(TestArr));
TestArr = reverseSign(TestArr);
Console.WriteLine(PrintArray(TestArr));