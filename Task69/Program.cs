// 69. Найти сумму элементов от M до N, N и M заданы

int sumMtoN(int m, int n)
{
    if (n == m) return n;
    if (m > n) {return m + sumMtoN(m - 1, n);}
    else {return m + sumMtoN(m + 1, n);}
}

int n = 1;
int m = 5;
Console.WriteLine(sumMtoN(m, n));

Console.WriteLine();

n = 10;
m = 5;
Console.WriteLine(sumMtoN(m, n));

Console.WriteLine();

n = -10;
m = 10;
Console.WriteLine(sumMtoN(m, n));