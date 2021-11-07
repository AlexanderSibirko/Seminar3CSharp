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

// // Альетрнатива (делегаты С#)
// bool NumisEven(int Na) => Na % 2 == 0;