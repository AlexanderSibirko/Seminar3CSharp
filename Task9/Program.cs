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
int LastNum(int a)
{
    return  a % 10;
}
Console.WriteLine(LastNum(a9));

// Альтернатива (делегирование)
int LastN(int a) => a % 10;
Console.WriteLine(LastN(a9));