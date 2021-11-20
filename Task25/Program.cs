// 25. Найти сумму чисел от 1 до А
double sumUpToN(double N) //суммирование перебором
{
    double result = 0;
    for (int i = 1; i <= N; i++)
    {
        result += i;
    }
    return result;
}

double sumUpToN2(double N) //суммирование по формуле первых Х членов последовательности      1 2 3 4 5 6 7 8 9 10   1+10=11 2+9=11 3+8=11
{
    return (N*(N+1))/2.0;
}


double N = 1000000000;
DateTime dt = DateTime.Now;
Console.WriteLine(sumUpToN(N));
Console.WriteLine((DateTime.Now - dt).TotalMilliseconds);

dt = DateTime.Now;
Console.WriteLine(sumUpToN2(N));
Console.WriteLine((DateTime.Now - dt).TotalMilliseconds);