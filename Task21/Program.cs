// 21. Программа проверяет пятизначное число на палиндромом.
int[] decompNum(int N) //разбиватель числа в массив из его цифр (очередность цифр внтури массива справа на лево, по рязрядам)
{
    // int arrLen = NumberCharNum(N); //определяем количество цифр в числе (без превращения числа в строку)
    string numberStr = Convert.ToString(N);
    int arrLen = numberStr.Length; //определяем количество цифр в числе
    int[] numbersInNum = new int[arrLen]; //задаёмся массивом для цифр
    for (int i = 0; i < arrLen;i++) //передача цифр числа в массив
    {
        numbersInNum[i] = numberStr[i];
    }
    return numbersInNum;
}

bool numIsPalendrome(int N)
{
    int[] digitsInNum = decompNum(N);
    int arrlen = digitsInNum.Length;
    for (int i = 0; i < arrlen/2; i++)
    {
        if (digitsInNum[i] != digitsInNum[arrlen-1-i]) return false;
    }
    return true;
}


int number = 53435; //принудительная проверка палиндром
Console.WriteLine($"Число {number} палиндом? Ответ: {numIsPalendrome(number)}");
number = 12345; //принудительная проверка не палиндром
Console.WriteLine($"Число {number} палиндом? Ответ: {numIsPalendrome(number)}");