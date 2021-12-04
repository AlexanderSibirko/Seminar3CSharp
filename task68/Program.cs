// 68. Показать натуральные числа от M до N, N и M заданы

string showN(int m, int n)
{
    if (n == m) return $"{m}";
    if (m > n) {return $"{showN(m - 1, n)} {m}";}
    else {return $"{m} {showN(m + 1, n)}";}
}

int n = 20;
int m = 30;
Console.WriteLine(showN(m, n));


n = 20;
m = 10;
Console.WriteLine(showN(m, n));