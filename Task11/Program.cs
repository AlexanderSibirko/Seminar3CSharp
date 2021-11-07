// 11. Дано число из отрезка [10, 99]. Показать наибольшую цифру числа
Console.WriteLine(); //лишняя красота
Console.WriteLine("Задача 11: Дано число из отрезка [10, 99]. Показать наибольшую цифру числа"); //лишняя красота
// Алексей Родионов
int a11 = new Random().Next(10, 100);
Console.WriteLine($"a = {a11}");

void MaxNumber(int a)
{
    int b = a / 10;
    int c = a % 10;
    if (b > c)
    {
        Console.WriteLine(b);
    }
    else Console.WriteLine(c);
}
MaxNumber(a11);

// Альтернатива без void методов
int MaxNumberAlt(int N)
{
    int N2 = N / 10;
    int N1 = N % 10;
    if (N2 > N1)
    {
        return N2;
    }
    return N1;
}
Console.WriteLine(MaxNumberAlt(a11));

// Задача 11**: Найти наибольшую цифру "любого" целого числа
a11 = new Random().Next(10000, 10000000);
int MaxNumberAnyLen(int N) //вычислятель наибольшей цифры числа
{
    int[] numbers = decompNum(N); //получаем набор цифр числа
    int maxNum = numbers[0]; //принимаем базово что первая цифра максимальна
    for (int i = 1; i < numbers.Length;i++) //находим максимальное из чисел в массиве
    {
        if (numbers[i]>maxNum)
        {
            maxNum = numbers[i];
        }
    }
    return maxNum;
}
int[] decompNum(int N) //разбиватель числа в массив из его цифр (очередность цифр внтури массива справа на лево, по рязрядам)
{
    // int arrLen = NumberCharNum(N); //определяем количество цифр в числе (без превращения числа в строку)
    int arrLen = N.ToString().Length; //определяем количество цифр в числе
    int[] numbersInNum = new int[arrLen]; //задаёмся массивом для цифр
    for (int i = 0; i < arrLen;i++) //передача цифр числа в массив
    {
        numbersInNum[i] = N % (int)Math.Pow(10,i+1) / (int)Math.Pow(10,i); //получаем цифры справа на лево (по разрядам)
    }
    return numbersInNum;
}
// int NumberCharNum(int N) //счётчик количества цифр в числе (мат метод)
// {
//     int count = 1;
//     while (N / 10 > 0)
//     {
//         N = N / 10;
//         count++;
//     }
//     return count;
// }
Console.WriteLine($"Максимальная цифра числа {a11} = {MaxNumberAnyLen(a11)}");