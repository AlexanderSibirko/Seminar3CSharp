// 26. Возведите число А в натуральную степень B используя цикл
double ApowB(double A, int B) //брут форс метод
{
    double a = A;
    for (int i = 1; i < B; i++)
    {
        A = A * a;
    }
    return A;
}

// 2^70 = ((2^2)^5)^7,  70 = 2*5*7 разложив на простые множители ()
double ApowbigB(double A, int B) //оптимизация для больших степеней
{
    double result = A;
    int i = 2;
    while (i * i <= B) //цикл для определения делителей (из ряда простых чисел), на выходе B = последнему наибольшему простому делителю
    {
        if (B % i == 0)
        {
            B = B / i;
            result = ApowB(result, i);
        }
        else
        {
            i++;
        }
    }
    result = ApowB(result, B); //в цикле не происходит умножения на последний делитель, делаем это сразу после цикла, или же если цикл не нашёл делителей (степень = число простое)
    return result;
}

double A = 5.85; //А любое число
int B = 7; //B натуральное число 1+
Console.WriteLine(ApowB(A, B)); //проверка
Console.WriteLine(ApowbigB(A, B)); //проверка

A = 2;
B = 8;
Console.WriteLine(ApowB(A, B)); //проверка
Console.WriteLine(ApowbigB(A, B)); //проверка

//сравнить базовый, оптимизированный и Math.Pow методы по скорости
//при выполении операции 1 раз, или малом значении степени, быстрее та что вызывается позже - системы кэширования?, при большой степени и количестве повторений 1_000_000 видна разница
A = 5;
B = 195;
double x = 0;
int imax = 1_000_000;
DateTime dt = DateTime.Now;
for (int i = 0; i < imax; i++)
{
      x = Math.Pow(A,B); //проверка
}
Console.WriteLine((DateTime.Now - dt).TotalMilliseconds);

dt = DateTime.Now;
for (int i = 0; i < imax; i++)
{
       x = ApowbigB(A, B); //проверка
}  
Console.WriteLine((DateTime.Now - dt).TotalMilliseconds);

dt = DateTime.Now;
for (int i = 0; i < imax; i++)
{
    x = ApowB(A, B); //проверка
}
Console.WriteLine((DateTime.Now - dt).TotalMilliseconds);
