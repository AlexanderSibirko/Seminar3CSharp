// 24. Найти кубы чисел от 1 до N
int[] pow3UpToN(int N) //применяя функцию степени
{
    int[] result = new int[N];
    for (int i = 0; i < N; i++)
    {
        //result[i] = i*i*i;
        result[i] = (int)Math.Pow(i+1,3);
    }
    return result;
}

int N = 20;
Console.WriteLine(string.Join(" , ", pow3UpToN(N)));