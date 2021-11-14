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

double sumUpToN2(double N) //суммирование по формуле первых Х членов последовательности
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