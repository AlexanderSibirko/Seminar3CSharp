// 13. Выяснить, кратно ли число заданному, если нет, вывести остаток.
Console.WriteLine(); //лишняя красота
Console.WriteLine("Задача 13: Выяснить, кратно ли число заданному, если нет, вывести остаток."); //лишняя красота

// int a13 = new Random().Next(-20, 21);
// int k13 = new Random().Next(2, 5);


string ifmultiply(int N, int K)
{
    string result = "";
    if (N % K != 0)
    {
        result = "" + (N % K);
    }
    return result;
}

int a13 = 15;
int k13 = 5;
Console.WriteLine($"Число {a13} кратно ли {k13}? Если нет какой остаток?");
Console.WriteLine(ifmultiply(a13, k13));
k13 = 8;
Console.WriteLine($"Число {a13} кратно ли {k13}? Если нет какой остаток?");
Console.WriteLine(ifmultiply(a13, k13));