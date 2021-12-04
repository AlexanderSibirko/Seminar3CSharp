// 67. Показать натуральные числа от N до 1, N задано

string showN(int n)
{
    if (n == 1) return "1";
    return $"{n} {showN(n-1)}";
}

int n = 20;
Console.WriteLine(showN(n));

