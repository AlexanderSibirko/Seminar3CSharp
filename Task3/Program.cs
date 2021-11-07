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
string DayWeekName (int daynumber)
{
 string[] Dayweek = {"Понедельник", "Вторник", "Cреда", "Четверг", "Пятница", "Cуббота", "Воскресение"};
 return Dayweek[daynumber-1];
}
int daynumber3 = new Random().Next(1,8);
Console.WriteLine($"{daynumber3} день недели называется = {DayWeekName(daynumber3)}");
