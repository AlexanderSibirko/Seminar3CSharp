// Почувствуй себя интерном
//  0. Вывести квадрат числа
int SquareNum(int N)
{ return N * N; }

int Num = new Random().Next(-50, 50);
Console.WriteLine($"Число {Num} в квадрате = {SquareNum(Num)}");

//  1. По двум заданным числам проверять является ли первое квадратом второго
// bool aSqrbYesNo(int Na, int Nb)
// { return Na == Nb * Nb; }
// int a = 16;
// int b = 4;
// Console.WriteLine($"Число {a} является квадратом числа {b}? Ответ: {aSqrbYesNo(a, b)}");


//  2. Даны два числа. Показать большее и меньшее число
int a = new Random().Next(-50, 500);
int b = new Random().Next(-50, 500);
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
BiggerSmaller(a, b);

//  3. По заданному номеру дня недели вывести его название
// void DayWeekName (int daynumber)
// {
//  string[] Dayweek = {"Понедельник", "Вторник", "Cреда", "Четверг", "Пятница", "Cуббота", "Воскресение"};
//  Console.WriteLine(Dayweek[daynumber-1]);
// }
// int daynumber = new Random().Next(1,8);
// // Console.Write($"Рандом выбрал: {daynumber} = "); //### debugging code
// DayWeekName (daynumber);

int number = 4;
void DayWeek(int number)
{
    if (number == 1) Console.WriteLine ("понедельник");
    if (number == 2) Console.WriteLine ("вторник");
    if (number == 3) Console.WriteLine ("среда");
    if (number == 4) Console.WriteLine ("четверг");
    if (number == 5) Console.WriteLine ("пятница");
    if (number == 6) Console.WriteLine ("суббота");
    if (number == 7) Console.WriteLine ("воскресенье");
}
DayWeek(number);


//  4. Найти максимальное из трех чисел
//  5. Написать программу вычисления значения функции y=f(a)
//  6. Выяснить является ли число чётным
//  7. Показать числа от -N до N
int N = 20;
void ShowNums(int N)
{
    for (int i = 0; i < N * 2 + 1; i++)
    {
        Console.Write($"{-N + i} ");
    }
    Console.WriteLine();
}
ShowNums(N);
//  8. Показать четные числа от 1 до И
//  9. Показать последнюю цифру трёхзначного числа
// 10. Показать вторую цифру трёхзначного числа
// 11. Дано число из отрезка [10, 99]. Показать наибольшую цифру числа
// 12. Удалить вторую цифру трёхзначного числа
// 13. Выяснить, кратно ли число заданному, если нет, вывести остаток.
// 14. Найти третью цифру числа или сообщить, что её нет
int Number = new Random().Next(-100000, 100000);

string FindFirdNumber(int N)
{
    N = N / 100;
    string NumStr = Convert.ToString(N);
    return NumStr + " Проверка";
        // return "Третей цифры нет";
}
Console.WriteLine(FindFirdNumber(Number));