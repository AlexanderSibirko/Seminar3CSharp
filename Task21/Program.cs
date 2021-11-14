// 21. Программа проверяет пятизначное число на палиндромом.

// Вариант 1 декомпозиции целого числа на цифры (через преобразование в строку)
int[] decompNumAsStr(int N) //разбиватель числа в массив из его цифр (очередность цифр внтури массива справа на лево, по рязрядам)
{
    // int arrLen = NumberCharNum(N); //определяем количество цифр в числе (без превращения числа в строку)
    string numberStr = Convert.ToString(Math.Abs(N)); //превращаем число в строку, по модулю на случай отрицательного числа
    int arrLen = numberStr.Length; //определяем количество цифр в числе
    int[] numbersInNum = new int[arrLen]; //задаёмся массивом для цифр
    for (int i = 0; i < arrLen;i++) //передача цифр числа в массив
    {
        numbersInNum[i] = numberStr[i];
    }
    return numbersInNum;
}

// Вариант 2 декомпозиции целого числа на цифры (гибрид) - чтобы не делать цикл поиска длинны числа
int[] decompNumHalfStr(int N) //разбиватель числа в массив из его цифр (очередность цифр внтури массива справа на лево, по рязрядам)
{
    // int arrLen = NumberCharNum(N); //определяем количество цифр в числе (без превращения числа в строку)
    int arrLen = N.ToString().Length; //определяем количество цифр в числе
    int[] numbersInNum = new int[arrLen]; //задаёмся массивом для цифр
    for (int i = 0; i < arrLen;i++) //передача цифр числа в массив
    {
        numbersInNum[i] = N % 10; //получаем цифры справа на лево (по разрядам)
        N = N / 10;
    }
    return numbersInNum;
}

// Вариант 3 без приведения к строке
int[] decompNumNoStr(int N) //разбиватель числа в массив из его цифр (очередность цифр внтури массива справа на лево, по рязрядам)
{
    int arrLen = NumberCharNum(N); //определяем количество цифр в числе (без превращения числа в строку)
    //int arrLen = N.ToString().Length; //определяем количество цифр в числе
    int[] numbersInNum = new int[arrLen]; //задаёмся массивом для цифр
    for (int i = 0; i < arrLen;i++) //передача цифр числа в массив
    {
        numbersInNum[i] = N % 10; //получаем цифры справа на лево (по разрядам)
        N = N / 10;
    }
    return numbersInNum;
}

int NumberCharNum(int N) //счётчик количества цифр в числе (мат метод)
{
    int count = 1;
    while (Math.Abs(N / 10) > 0) //Math.Abs чтобы работало и с отрицательными числами
    {
        N = N / 10;
        count++;
    }
    return count;
}


bool numIsPalendrome(int N)
{
    int[] digitsInNum = decompNumNoStr(N); //decompNumNoStr, decompNumHalfStr, decompNumAsStr - любым способом разбиваем число на массив его цифр
    int arrlen = digitsInNum.Length;
    for (int i = 0; i < arrlen/2; i++)
    {
        if (digitsInNum[i] != digitsInNum[arrlen-1-i]) return false;
    }
    return true;
}

bool numIsPalendrome2(int N) //без декомпозиции числа на массив из его цифр ?
{
    int numLen = NumberCharNum(N);
    for (int i = 0 ; i < numLen/2; i++)
    {
        //Console.WriteLine((int)(N / Math.Pow(10.0,numLen-1-2*i))); //debug code
        //Console.WriteLine(N % 10); //debug code
        if ((int)(N / Math.Pow(10.0,numLen-1-2*i)) != N % 10) {return false;}
        N = N / 10;
        N = N % (int)Math.Pow(10.0,numLen-2-2*i);
        //Console.WriteLine(N); //debug code
    }   
    return true;
}

// bool numIsPalendrome3(int N) //без декомпозиции числа на массив из его цифр, не находя предварительно длинну числа ?
// {
//     int numLen = NumberCharNum(N); //исключить этот момент можем как-то?
//     for (int i = 0 ; i < numLen/2; i++)
//     {
//         //Console.WriteLine((int)(N / Math.Pow(10.0,numLen-1-2*i))); //debug code
//         //Console.WriteLine(N % 10); //debug code
//         if ((int)(N / Math.Pow(10.0,numLen-1-2*i)) != N % 10) {return false;}
//         N = N / 10;
//         N = N % (int)Math.Pow(10.0,numLen-2-2*i);
//         //Console.WriteLine(N); //debug code
//     }   
//     return true;
// }


int number = 53435; //принудительная проверка палиндром
Console.WriteLine($"Число {number} палиндом? Ответ: {numIsPalendrome(number)}");
Console.WriteLine($"Число {number} палиндом? Ответ: {numIsPalendrome2(number)}");
//Console.WriteLine($"Число {number} палиндом? Ответ: {numIsPalendrome3(number)}"); //метод не готов

number = 12345; //принудительная проверка не палиндром
Console.WriteLine($"Число {number} палиндом? Ответ: {numIsPalendrome(number)}");
Console.WriteLine($"Число {number} палиндом? Ответ: {numIsPalendrome2(number)}");
//Console.WriteLine($"Число {number} палиндом? Ответ: {numIsPalendrome3(number)}"); //метод не готов