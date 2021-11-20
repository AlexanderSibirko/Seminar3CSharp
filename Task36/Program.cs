// 36. Задать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечетных\четных чисел

// пробежка по массиву с условием % 2 и подсчитываем (два метода)

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

int CountEvenUneven(int[] arr, bool LookforEven = true) // LookforEven = true - ищем чётные, False - нечётные
{
    int count = 0;
    for (int i = 0 ; i < arr.Length; i++)
    {
        if (LookforEven) 
        {
            if (arr[i] % 2 == 0)
            {
                count++;
            }
        }
        else
        {
            if (arr[i] % 2 != 0)
            {
                count++;
            }
        }
    }
    return count;
}

int[] Test = CreateFilledIntArray(10,100,1000);

Console.WriteLine(PrintArray(Test));
Console.WriteLine($"Чётных чисел = {CountEvenUneven(Test)}");
Console.WriteLine($"Не чётных чисел = {CountEvenUneven(Test,false)}");
