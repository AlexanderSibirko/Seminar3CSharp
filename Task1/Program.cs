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
// a1 = 16;
// b1 = 4;
// Console.WriteLine($"Число {a1} является квадратом числа {b1}? Ответ: {aSqrbYesNo(a1, b1)}");

// Альтернатива 2 (делегаты)
// bool aSqrbYesNo(int Na, int Nb) => Na == Math.Pow(Nb,2);