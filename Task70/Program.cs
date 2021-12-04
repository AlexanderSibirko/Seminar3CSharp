// 70. Найти сумму цифр числа

int sumDigits(int number)
{
    number = Math.Abs(number);
    if (number / 10 == 0) return number;
    return number%10 + sumDigits(number/10);
}

int number = 123456;
Console.WriteLine(sumDigits(number));

number = -12345;
Console.WriteLine(sumDigits(number));
