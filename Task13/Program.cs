// 13. Выяснить, кратно ли число заданному, если нет, вывести остаток.
Console.WriteLine(); //лишняя красота
Console.WriteLine("Задача 13: Выяснить, кратно ли число заданному, если нет, вывести остаток."); //лишняя красота

int a13 = new Random().Next(-100, 100);
int k13 = new Random().Next(0, 16);
Console.WriteLine($"Число {a13} кратно ли {k13}? Если нет какой остаток?");

string ifmultiply(int N, int K)
{
    string result = "";
    if (N % K != 0)
    {
        result = "" + (N % K);
    }
    return result;
}
Console.WriteLine(ifmultiply(a13, k13));