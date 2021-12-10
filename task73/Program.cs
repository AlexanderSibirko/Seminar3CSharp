// 73. Написать программу показывающие первые N чисел, для которых каждое следующее равно сумме двух предыдущих. Первые два элемента последовательности задаются пользователем

// string Fibonachi (int N)
// {
//     if (N == 0 || N ==1) {return $"{N}";}
//     else return Fibonachi(N-1) + Fibonachi(N-2);
// }

int K = 8; // первое число
int M = 20; // второе число
int N = 8; //N[0] = 5, N[1]=10, N[X]=N[x-2]+N[x-1]...;

string FirstNofKPlusMSequence(int K, int M, int N)
{
    if (N == 1) return $"{K}";
    else return $"{K} {FirstNofKPlusMSequence(M, K + M, N-1)}";
}

Console.WriteLine(FirstNofKPlusMSequence(K, M, N));
