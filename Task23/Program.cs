// 23. Показать таблицу квадратов чисел от 1 до N
string tablePow2UpToN(int N) //применяя функцию степени
{
    string result = "";
    for (int i = 1; i <= N; i++)
    {
        result += $"\n {i} x {i} = {Math.Pow(i, 2)}";
    }
    return result;
}

string tablePow2UpToNAlt(int N) //применяя ряд квадратов чисел (есть сумма N первых нечётных чисел 9*9 = 1 + 3 + 5 + 7 + 9 + 11 + 13 + 15 + 17, (2i-1)
{
    string result = "";
    int pow2 = 1;
    int K = 1;
    for (int i = 1; i <= N; i++)
    {
        result += $"\n {i} x {i} = {pow2}";
        K += 2;
        pow2 = pow2 + K;
    }
    return result;
}

int N = 200;
Console.WriteLine(tablePow2UpToN(N));

Console.WriteLine(tablePow2UpToNAlt(N));