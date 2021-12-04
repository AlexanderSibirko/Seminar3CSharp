// 71. Написать программу вычисления функции Аккермана

int funcAkerman(int m, int n)
{
    if (m == 0) return n+1;
    if (m>0 && n==0) return funcAkerman(m-1,1);
    return funcAkerman(m-1, funcAkerman(m,n-1));
}

Console.WriteLine(funcAkerman(1,0));
Console.WriteLine(funcAkerman(2,0));
Console.WriteLine(funcAkerman(3,0));
Console.WriteLine(funcAkerman(4,0));

Console.WriteLine(funcAkerman(1,1));
Console.WriteLine(funcAkerman(2,2));
Console.WriteLine(funcAkerman(3,3));
Console.WriteLine(funcAkerman(4,1));
