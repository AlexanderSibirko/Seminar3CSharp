// Участники команды: Лейсан Файзуллина, Алексей Родионов, Александр Сибирко

// 0. Вывести квадрат числа
Console.WriteLine(); //лишняя красота
Console.WriteLine("Задача 0: Вывести квадрат числа"); //лишняя красота
// Александр Сибирко
int SquareNum(int N) { return N * N; } //изобретаем велосипед с костылями пишем свой метод возведения в квадрат

int Num0 = new Random().Next(-50, 50);
Console.WriteLine($"Число {Num0} в квадрате = {SquareNum(Num0)}");

// Альтернатива
// Console.WriteLine($"Число {Num0} в квадрате = {Math.Pow(Num0, 2)}"); //через готовый метод


// 1. По двум заданным числам проверять является ли первое квадратом второго
Console.WriteLine(); //лишняя красота
Console.WriteLine("Задача 1: По двум заданным числам проверять является ли первое квадратом второго"); //лишняя красота

// Алексей Родионов
bool SQR(int a, int b)
{
    if (a == b * b)
    {
        return true;
    }
    return false;
}
int a1 = 16; int b1 = 4; //проверка на true
Console.WriteLine($"{SQR(a1, b1)} a: {a1} , b: {b1} ");
a1 = 1; b1 = 0; //проверка на false
Console.WriteLine($"{SQR(a1, b1)} a: {a1} , b: {b1} ");

// Альтернатива
// bool aSqrbYesNo(int Na, int Nb)
// {
//     return Na == Math.Pow(Nb,2);
// }
// int a1 = 16;
// int b1 = 4;
// Console.WriteLine($"Число {a1} является квадратом числа {b1}? Ответ: {aSqrbYesNo(a1, b1)}");


// 2. Даны два числа. Показать большее и меньшее число
Console.WriteLine(); //лишняя красота
Console.WriteLine("Задача 2: Даны два числа. Показать большее и меньшее число"); //лишняя красота

// Лейсан Файзуллина
int a2 = new Random().Next(-50, 500);
int b2 = new Random().Next(-50, 500);
void BiggerSmaller(int a, int b)
{
    if (a < b)
    {
        Console.WriteLine($"min = {a}, max = {b}");
    }
    else
    {
        Console.WriteLine($"min = {b}, max = {a}");
    }
}
BiggerSmaller(a2, b2);

// Альтернатива без void метода
//
//


// 3. По заданному номеру дня недели вывести его название
Console.WriteLine(); //лишняя красота
Console.WriteLine("Задача 3: По заданному номеру дня недели вывести его название"); //лишняя красота
// Алексей Родионов
int number = 4;
void DayWeek(int number)
{
    if (number == 1) Console.WriteLine("понедельник");
    if (number == 2) Console.WriteLine("вторник");
    if (number == 3) Console.WriteLine("среда");
    if (number == 4) Console.WriteLine("четверг");
    if (number == 5) Console.WriteLine("пятница");
    if (number == 6) Console.WriteLine("суббота");
    if (number == 7) Console.WriteLine("воскресенье");
}
DayWeek(number);

// Альтернатива
// string DayWeekName (int daynumber)
// {
//  string[] Dayweek = {"Понедельник", "Вторник", "Cреда", "Четверг", "Пятница", "Cуббота", "Воскресение"};
//  return Dayweek[daynumber-1];
// }
// int daynumber3 = new Random().Next(1,8);
// Console.WriteLine($"{daynumber3} день недели называется = {DayWeekName(daynumber3)}");


// 4. Найти максимальное из трех чисел
Console.WriteLine(); //лишняя красота
Console.WriteLine("Задача 4: Найти максимальное из трех чисел"); //лишняя красота
// Лейсан Файзуллина
int a4 = new Random().Next(-50, 50);
int b4 = new Random().Next(-50, 50);
int c4 = new Random().Next(-50, 50);
Console.WriteLine($"a={a4}, b={b4}, c={c4}");

int Max(int a, int b, int c)
{
    int result = a;
    if (b > result) result = b;
    if (c > result) result = c;
    return result;
}
int max = Max(a4, b4, c4);
Console.WriteLine($"Максимальное число = {max}");

// Альетрнатива (через числа передаваемые массивом)
//
//


// 5. Написать программу вычисления значения функции y=f(a), где f(а) = sin^[кол-во букв Фамилии](а)
Console.WriteLine(); //лишняя красота
Console.WriteLine("Задача 5: Написать программу вычисления значения функции y=f(a), где f(а) = sin^[кол-во букв Фамилии](а)"); //лишняя красота
//Алексей Родионов
double Trig(double a)
{
    double x, y;
    x = a * Math.PI / 180;
    Console.WriteLine("Угол в радианах = {0}", x);
    y = Math.Pow(Math.Sin(x), 8); //Алексей Родионов
    return y;
}
double a = 60;
Console.WriteLine($"sin (x) = {Trig(a)}");

// Альтернатива
// double ysinxpow7(double a)
// {
//     return Math.Pow(Math.Sin(a * Math.PI / 180), 7);
// }
// string surName5 = "Сибикро";
// for (double i = 0; i < 360; i += 60)
// { Console.WriteLine($"sin({i})^{surName5.Length} = {ysinxpow7(i)}"); }

// 6. Выяснить является ли число чётным
Console.WriteLine(); //лишняя красота
Console.WriteLine("Задача 6: Выяснить является ли число чётным"); //лишняя красота
// Лейсан Файзуллина
int a6 = new Random().Next(-50, 50);
Console.WriteLine($"Число а: {a6}");
bool Number(int a)
{
    if (a % 2 == 0)
    {
        return true;
    }
    else return false;
}
Console.WriteLine($"{Number(a6)}");

// // Альтернатива
// bool NumisEven(int Na)
// { return Na % 2 == 0; }
// int a6 = 16;
// Console.WriteLine($"Число чётное {a6}? Ответ: {NumisEven(a6)}");
// a6 = 13;
// Console.WriteLine($"Число чётное {a6}? Ответ: {NumisEven(a6)}");

// 7. Показать числа от -N до N
Console.WriteLine(); //лишняя красота
Console.WriteLine("Задача 7: Показать числа от -N до N"); //лишняя красота
//$$$ outdate code
// void ShowNums(int N)
// {
//     for (int i = 0; i < N * 2 + 1; i++)
//     {
//         Console.Write($"{-N + i} ");
//     }
//     Console.WriteLine();
// }
//$$$ outdate code

// Александр Сибирко
string ShowNums(int N)
{
    string NumsShow = "";
    for (int i = -N; i < N; i++)
    {
        NumsShow = NumsShow + i + " ";
    }
    return NumsShow;
}

int N7 = 20;
Console.WriteLine(ShowNums(N7));

// 8. Показать четные числа от 1 до N
Console.WriteLine(); //лишняя красота
Console.WriteLine("Задача 8: Показать четные числа от 1 до N"); //лишняя красота
//Алексей Родионов
void Numbers(int N)
{
    for (int i = 2; i <= N; i = i + 2)
    {
        Console.WriteLine(i);
    }
}
int N = 12;
Numbers(N);

// Альтернатива
// string EvenNums(int N)
// {
//     string evenNumsStr = "";
//     for (int i = 2; i <=N; i +=2)
//     {
//         evenNumsStr = evenNumsStr + i + " ";
//     }
//     return evenNumsStr;
// }
// int N8 = 20;
// Console.WriteLine(EvenNums(N8));

// 9. Показать последнюю цифру трёхзначного числа
Console.WriteLine(); //лишняя красота
Console.WriteLine("Задача 9: Показать последнюю цифру трёхзначного числа"); //лишняя красота
// Лейсан Файзуллина 
int a9 = new Random().Next(100, 1000);
Console.WriteLine($"a: {a9}");
void LastNumber(int a)
{
    int b = a % 10;
    Console.WriteLine($"Последняя цифра числа: {b}");
}
LastNumber(a9);

// Альтернатива без void методов
//
//


// 10. Показать вторую цифру трёхзначного числа
Console.WriteLine(); //лишняя красота
Console.WriteLine("Задача 10: Показать вторую цифру трёхзначного числа"); //лишняя красота
// Лейсан Файзуллина 
int a10 = new Random().Next(100, 1000);
Console.WriteLine($"a: {a10}");
void SecondNumber(int a)
{
    a = a % 100;
    a = a / 10;
    Console.WriteLine($"Вторая цифра числа: {a}");
}
SecondNumber(a10);


// Альтернатива без void методов
//
//

// 11. Дано число из отрезка [10, 99]. Показать наибольшую цифру числа
Console.WriteLine(); //лишняя красота
Console.WriteLine("Задача 11: Дано число из отрезка [10, 99]. Показать наибольшую цифру числа"); //лишняя красота
// Алексей Родионов
int a11 = new Random().Next(10, 100);
Console.WriteLine($"a = {a}");

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
//
//


// 12. Удалить вторую цифру трёхзначного числа
Console.WriteLine(); //лишняя красота
Console.WriteLine("Задача 12: Удалить вторую цифру трёхзначного числа"); //лишняя красота
// Алексей Родионов
int a12 = new Random().Next(100, 1000);
Console.WriteLine($"a = {a12}");

void DelMidNumeral(int a)
{
    int b = a / 100;
    int c = a / 10;
    int d = a % 10;
    Console.WriteLine($"новое число = {b * 10 + d}");
    //Console.WriteLine($"новое число = {b}{d}");
}

DelMidNumeral(a12);

// 13. Выяснить, кратно ли число заданному, если нет, вывести остаток.
Console.WriteLine(); //лишняя красота
Console.WriteLine("Задача 13: Выяснить, кратно ли число заданному, если нет, вывести остаток."); //лишняя красота

int a13 = new Random().Next(-100, 100);
int k13 = new Random().Next(0, 16);
Console.WriteLine($"Число {a13} кратно ли {k13}? Если нет какой остаток?");

string ifmultiply(int N, int K)
{
    string result = "";
    if (N % K != 0)
    {
        result = "" + (N % K);
    }
    return result;
}
Console.WriteLine(ifmultiply(a13, k13));


// 14. Найти третью цифру числа или сообщить, что её нет
Console.WriteLine(); //лишняя красота
Console.WriteLine("Задача 14: Найти третью цифру числа или сообщить, что её нет"); //лишняя красота
// Александр Сибирко
string FindFirdNumber(int N, bool fromRtoL = true) //ищем третью цифру, по умолчанию справа на лево как идут разряды, если нужно слева направо то указываем что "НЕТ" поиску справа налево.
{
    string NumStr = Convert.ToString(Math.Abs(N));
    string result;
    if (NumStr.Length < 3)
    {
        result = $"У числа {N} нету третей цифры";
    }
    else
    {
        if (fromRtoL)
        {
            result = $"Третья цифра {NumStr[NumStr.Length-3]}";
        }
        else
        {
            result = $"Третья цифра {NumStr[2]}";
        }
    }
    return result;
}

int Number14 = new Random().Next(-100, 100);
Console.WriteLine($"Тест для слишком короткого числа/ {FindFirdNumber(Number14)}");
Number14 = new Random().Next(-10000000, 10000000);
Console.WriteLine($"Ищем третье справа-налево по разрядам, для числа {Number14}. {FindFirdNumber(Number14)}");
Number14 = new Random().Next(-10000000, 10000000);
Console.WriteLine($"Ищем третье слева-направо \"как читаем\", для числа {Number14}. {FindFirdNumber(Number14, false)}");



// SPOILERS
// Почувствуй себя джуном
// 15. Дано число. Проверить кратно ли оно 7 и 23
// 16. Дано число обозначающее день недели. Выяснить является номер недели выходным днём
// 17. По двум заданным числам проверять является ли одно квадратом другого
// 18. Проверить истинность утверждения ¬(X ⋁ Y) = ¬X ⋀ ¬Y
// 19. Определить номер четверти плоскости, в которой находится точка с координатами Х и У, причем X ≠ 0 и Y ≠ 0
// 20. Ввести номер четверти, показать диапазоны для возможных координат
// 21. Программа проверяет пятизначное число на палиндромом.
// 22. Найти расстояние между точками в пространстве 2D/3D

// Почувствуй себя мидлом
// 23. Показать таблицу квадратов чисел от 1 до N 
// 24. Найти кубы чисел от 1 до N
// 25. Найти сумму чисел от 1 до А
// 26. Возведите число А в натуральную степень B используя цикл
// 27. Определить количество цифр в числе
// 28. Подсчитать сумму цифр в числе
// 29. Написать программу вычисления произведения чисел от 1 до N
// 30. Показать кубы чисел, заканчивающихся на четную цифру

// Почувствуй себя сеньором
// 31. Задать массив из 8 элементов и вывести их на экран 
// 32. Задать массив из 8 элементов, заполненных нулями и единицами вывести их на экран 
// 33. Задать массив из 12 элементов, заполненных числами из [0,9]. Найти сумму положительных/отрицательных элементов массива
// 34. Написать программу замену элементов массива на противоположные
// 35. Определить, присутствует ли в заданном массиве, некоторое число 
// 36. Задать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечетных\четных чисел
// 37. В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]
// 38. Найти сумму чисел одномерного массива стоящих на нечетной позиции
// 39. Найти произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д.
// 40. В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом

// Почувствуй себя лидом
// 41. Выяснить являются ли три числа сторонами треугольника 
// 42. Определить сколько чисел больше 0 введено с клавиатуры
// 43. Написать программу преобразования десятичного числа в двоичное
// 44. Найти точку пересечения двух прямых заданных уравнением y=kx+b, а1 k1 и а2 и k2 заданы
// 45. Показать числа Фибоначчи
// 46. Написать программу масштабирования фигуры
// 47. Написать программу копирования массива