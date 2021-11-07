// 14. Найти третью цифру числа или сообщить, что её нет
Console.WriteLine(); //лишняя красота
Console.WriteLine("Задача 14: Найти третью цифру числа или сообщить, что её нет"); //лишняя красота
// Александр Сибирко
string FindThirdNumber(int N, bool fromRtoL = true) //ищем третью цифру, по умолчанию справа на лево как идут разряды, если нужно слева направо то указываем что "НЕТ" поиску справа налево.
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
            result = $"Третья цифра {NumStr[NumStr.Length - 3]}";
        }
        else
        {
            result = $"Третья цифра {NumStr[2]}";
        }
    }
    return result;
}
int Number14 = new Random().Next(-100, 100);
Console.WriteLine($"Тест для слишком короткого числа/ {FindThirdNumber(Number14)}");
Number14 = new Random().Next(-10000000, 10000000);
Console.WriteLine($"Ищем третье справа-налево по разрядам, для числа {Number14}. {FindThirdNumber(Number14)}");
Number14 = new Random().Next(-10000000, 10000000);
Console.WriteLine($"Ищем третье слева-направо \"как читаем\", для числа {Number14}. {FindThirdNumber(Number14, false)}");
