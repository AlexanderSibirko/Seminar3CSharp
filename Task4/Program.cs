// 4. Найти максимальное из трех чисел
Console.WriteLine(); //лишняя красота
Console.WriteLine("Задача 4: Найти максимальное из трех чисел"); //лишняя красота
// Лейсан Файзуллина
int a4 = new Random().Next(-50, 50);
int b4 = new Random().Next(-50, 50);
int c4 = new Random().Next(-50, 50);
Console.WriteLine($"a={a4}, b={b4}, c={c4}");

int Max(int a, int b, int c)
{
    int result = a;
    if (b > result) result = b;
    if (c > result) result = c;
    return result;
}
int max = Max(a4, b4, c4);
Console.WriteLine($"Максимальное число = {max}");

// // Альетрнатива (через числа передаваемые массивом)
// int[] NumArr4 = {a4, b4, c4};
// int findMaxinArr(int[] NumArr)
// {
//     int MaxNum = NumArr[0];
//     for (int i = 1; i < NumArr.Length; i++)
//     {
//         if (NumArr[i] > MaxNum)
//         {
//             MaxNum = NumArr[i];
//         }
//     }
//     return MaxNum;
// }
// Console.WriteLine($"Максимальное число = {findMaxinArr(NumArr4)}");