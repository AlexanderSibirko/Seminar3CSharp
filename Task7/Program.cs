// 7. Показать числа от -N до N
Console.WriteLine(); //лишняя красота
Console.WriteLine("Задача 7: Показать числа от -N до N"); //лишняя красота
//$$$ outdate code
// void ShowNums(int N)
// {
//     for (int i = 0; i < N * 2 + 1; i++)
//     {
//         Console.Write($"{-N + i} ");
//     }
//     Console.WriteLine();
// }
//$$$ outdate code

// Александр Сибирко
string ShowNums(int N)
{
    string NumsShow = "";
    for (int i = -N; i < N; i++)
    {
        NumsShow = NumsShow + i + " ";
    }
    return NumsShow;
}

int N7 = 20;
Console.WriteLine(ShowNums(N7));