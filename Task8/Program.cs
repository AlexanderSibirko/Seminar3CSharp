// 8. Показать четные числа от 1 до N
Console.WriteLine(); //лишняя красота
Console.WriteLine("Задача 8: Показать четные числа от 1 до N"); //лишняя красота
//Алексей Родионов
void Numbers(int N)
{
    for (int i = 2; i <= N; i = i + 2)
    {
        Console.WriteLine(i);
    }
}
int N = 12;
Numbers(N);

// Альтернатива без void
string EvenNums(int N)
{
    string evenNumsStr = "";
    for (int i = 2; i <=N; i +=2)
    {
        evenNumsStr = evenNumsStr + i + " ";
    }
    return evenNumsStr;
}
int N8 = 20;
Console.WriteLine(EvenNums(N8));
