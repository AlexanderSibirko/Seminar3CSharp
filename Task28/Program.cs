// 28. Подсчитать сумму цифр в числе
int N = 423432;

int numsSum (int n)
{
    n = Math.Abs(n);
    int result = 0;
    while (n!=0)
    {
        result = result + n % 10;
        n /= 10;
    }
    return result;
}

Console.WriteLine(numsSum(N));
