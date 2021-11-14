// 27. Определить количество цифр в числе
int N = 423432;

int numsAmount (int n)
{
    int result = 0;
    while (n!=0)
    {
        result++;
        n /= 10;
    }
    return result;
}

Console.WriteLine(numsAmount(N));