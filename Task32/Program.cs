// 32. Задать массив из 8 элементов, заполненных нулями и единицами вывести их на экран
// метод создания массива, метод заполнения массива, метод вывода массива


// int[] CreateArray(int count)
// {
//     return new int[count];
// }

// void FillArray(int[] array, int minValue, int maxValue)
// {
//     int count = array.Length;
//     for (int i = 0; i < count; i++)
//     {
//         array[i] = new Random().Next(minValue, maxValue);
//     }
// }

// string PrintArray(int[] array)
// {
//     int count = array.Length;
//     string res = String.Empty;
//     for (int i = 0; i < count; i++)
//     {
//         res += $"{array[i]} ";
//     }
//     return res;
// }

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

Console.WriteLine(PrintArray(CreateFilledIntArray(8,0,2)));