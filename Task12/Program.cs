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

// Альтернатива без void