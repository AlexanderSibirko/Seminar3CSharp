// 5. Написать программу вычисления значения функции y=f(a), где f(а) = sin(а)^[кол-во букв Фамилии]
Console.WriteLine(); //лишняя красота
Console.WriteLine("Задача 5: Написать программу вычисления значения функции y=f(a), где f(а) = sin^[кол-во букв Фамилии](а)"); //лишняя красота
// Алексей Родионов
double Trig(double a)
{
    double x, y;
    x = a * Math.PI / 180; //перевод из радиан в градусы
    Console.WriteLine("Угол в радианах = {0}", x);
    y = Math.Pow(Math.Sin(x), 8); // Алексей Родионов
    return y;
}
double a = 60;
Console.WriteLine($"sin(x)^8 = {Trig(a)}");

// Альтернатива
double ysinxpow(double a, int surlen) //угол задаём с градусах
{
    return Math.Pow(Math.Sin(a * Math.PI / 180), surlen);
}

string surName5 = "Сибирко";
for (double i = 0; i < 360; i += 60)
{
    int len = surName5.Length;
    Console.WriteLine($"sin({i})^{len} = {ysinxpow(i, len)}");
}