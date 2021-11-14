// 29. Написать программу вычисления произведения чисел от 1 до N

int factN(int N)
{
    int result = 1;
    for (int i = 2; i < N + 1; i++)
    {
        result *= i;
    }
    return result;
}

int factN2(int N, int i = 1, int res = 1) //через рекурсию? а стоит ли?
{
    if (N > 1)
    {return factN2(N - 1, i += 1, res *= i);}
    else
    {return res;}
}

// int factN3(int N) //оптимизация вычисления? или хрень, умножений столько же получается по сути
// {
//     int result = 1;
//     for (int i = 1; i < N + 1; i += 2)
//     {
//         if (i == N) 
//         {
//             result *= i;
//         }
//         else
//         {
//             result = result * (i * (i+1));
//         }
//     }
//     return result;
// }


Console.WriteLine(factN(3)); //1*2*3 = 6
Console.WriteLine(factN(5)); //1*2*3*4*5 = 120
Console.WriteLine(factN(10)); //1*2*3*4*5*6*7*8*9*10 = 3628800

Console.WriteLine(factN2(3)); //1*2*3 = 6
Console.WriteLine(factN2(5)); //1*2*3*4*5 = 120
Console.WriteLine(factN2(10)); //1*2*3*4*5*6*7*8*9*10 = 3628800

// Console.WriteLine(factN3(3)); //1*2*3 = 6
// Console.WriteLine(factN3(5)); //1*2*3*4*5 = 120
// Console.WriteLine(factN3(10)); //1*2*3*4*5*6*7*8*9*10 = 3628800
