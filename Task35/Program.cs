// 35. Определить, присутствует ли в заданном массиве, некоторое число

// методы массивов + метод поиска числа в массиве (перебором по всему массиву от начала к концу, так как массив не отсортирован)

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

bool isFound(int[] arr, int lookfor)
{
    for (int i = 0 ; i < arr.Length; i++)
    {
        if (arr[i] == lookfor)
        {
            return true;
        }
    }
    return false;
}

int[] TestSubject = CreateFilledIntArray(10,-4,5);

Console.WriteLine(PrintArray(TestSubject));
Console.WriteLine($" looking for '5' Result:{isFound(TestSubject,5)}");

TestSubject[new Random().Next(0,10)] = 5;
Console.WriteLine(PrintArray(TestSubject));
Console.WriteLine($" looking for '5' Result:{isFound(TestSubject,5)}");