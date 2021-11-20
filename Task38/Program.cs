// 38. Найти сумму чисел одномерного массива стоящих на нечетной позиции

//сумма стоящих на нечетной в массиве (со стороны массива или со стороны пользователя)

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

int sumUnevenPos(int[] arr) //нечётная позиция по индексу
{
    int sum = 0;
    for (int i = 1; i < arr.Length ; i += 2)
    {
        sum += arr[i];
    }
    return sum;
}

int sumUnevenPosByCount(int[] arr) //нечётная позиция по порядку от начала (т.е. четные индексы, начиная с 0)
{
    int sum = 0;
    for (int i = 0; i < arr.Length ; i += 2)
    {
        sum += arr[i];
    }
    return sum;
}


int[] testarr = CreateFilledIntArray(10,-10,10);
Console.WriteLine(PrintArray(testarr));

Console.WriteLine(sumUnevenPos(testarr));
Console.WriteLine(sumUnevenPosByCount(testarr));
