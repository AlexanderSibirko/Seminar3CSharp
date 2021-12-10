// 66. Показать натуральные числа от 1 до N, N задано

string showN(int n)
{
    if (n == 1) return "1";
    return showN(n-1) + $" {n}";
}

int n = 20;
Console.WriteLine(showN(n));
