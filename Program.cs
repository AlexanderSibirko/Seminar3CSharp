// Почувствуй себя интерном
//  0. Вывести квадрат числа
Console.WriteLine(); //лишняя красота
Console.WriteLine("Задача 0: Вывести квадрат числа"); //лишняя красота
// Console.WriteLine($"Число {Num0} в квадрате = {Math.Pow(Num0, 2)}"); //через готовый метод

// Александр
int SquareNum(int N) { return N * N; } //изобретаем велосипед с костылями пишем свой метод возведения в квадрат

int Num0 = new Random().Next(-50, 50);
Console.WriteLine($"Число {Num0} в квадрате = {SquareNum(Num0)}");


//  1. По двум заданным числам проверять является ли первое квадратом второго
Console.WriteLine(); //лишняя красота
Console.WriteLine("Задача 1: По двум заданным числам проверять является ли первое квадратом второго"); //лишняя красота

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


//  2. Даны два числа. Показать большее и меньшее число
Console.WriteLine(); //лишняя красота
Console.WriteLine("Задача 2: Даны два числа. Показать большее и меньшее число"); //лишняя красота

// Лейсан
int a2 = new Random().Next(-50, 500);
int b2 = new Random().Next(-50, 500);
void BiggerSmaller(int a, int b) //!!!избавиться от void
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

//  3. По заданному номеру дня недели вывести его название
Console.WriteLine(); //лишняя красота
Console.WriteLine("Задача 3: По заданному номеру дня недели вывести его название"); //лишняя красота
// Алексей
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

//  4. Найти максимальное из трех чисел
Console.WriteLine(); //лишняя красота
Console.WriteLine("Задача 4: Найти максимальное из трех чисел"); //лишняя красота

// Лейсан
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

//Альетрнатива (через числа передаваемые массивом)
//
//

//  5. Написать программу вычисления значения функции y=f(a), где f(а) = sin^[кол-во букв Фамилии](а)
Console.WriteLine(); //лишняя красота
Console.WriteLine("Задача 5: Написать программу вычисления значения функции y=f(a), где f(а) = sin^[кол-во букв Фамилии](а)"); //лишняя красота

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


// double ysinxpow7(double a)
// {
//     return Math.Pow(Math.Sin(a * Math.PI / 180), 7);
// }
// string surName5 = "Сибикро";
// for (double i = 0; i < 360; i += 60)
// {
//     Console.WriteLine($"sin({i})^{surName5.Length} = {ysinxpow7(i)}");
// }

//  6. Выяснить является ли число чётным


//  7. Показать числа от -N до N
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

int N7 = 20;
string ShowNums(int N)
{
    string NumsShow = "";
    for (int i = -N; i < N; i++)
    {
        NumsShow = NumsShow + (i) + " ";
    }
    return NumsShow;
}
Console.WriteLine(ShowNums(N7));

//  8. Показать четные числа от 1 до И


//  9. Показать последнюю цифру трёхзначного числа


// 10. Показать вторую цифру трёхзначного числа


// 11. Дано число из отрезка [10, 99]. Показать наибольшую цифру числа


// 12. Удалить вторую цифру трёхзначного числа


// 13. Выяснить, кратно ли число заданному, если нет, вывести остаток.


// 14. Найти третью цифру числа или сообщить, что её нет

string FindFirdNumber(int N, bool fromRtoL = true) //ищем третью цифру, по умолчанию справа на лево как идут разряды, если нужно слева направо то указываем что "НЕТ" поиску справа налево.
{
    string NumStr = Convert.ToString(Math.Abs(N));
    if (NumStr.Length < 3)
    {
        return $"У числа {N} нету третей цифры";
    }
    return NumStr + " Проверка";
    // return "Третей цифры нет";
}
int Number14 = new Random().Next(-100, 100);
Console.WriteLine($"Тест для слишком короткого числа {FindFirdNumber(Number14)}");
Number14 = new Random().Next(-100000, 100000);
Console.WriteLine($"Ищем третье справа-налево по разрядам: {FindFirdNumber(Number14)}");
Number14 = new Random().Next(-100000, 100000);
Console.WriteLine($"Ищем третье слева-направо \"как читаем\": {FindFirdNumber(Number14, false)}");