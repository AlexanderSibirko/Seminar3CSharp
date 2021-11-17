// 2. Даны два числа. Показать большее и меньшее число
Console.WriteLine(); //лишняя красота
Console.WriteLine("Задача 2: Даны два числа. Показать большее и меньшее число"); //лишняя красота

// Лейсан Файзуллина
int a2 = new Random().Next(-50, 500);
int b2 = new Random().Next(-50, 500);
void BiggerSmaller(int a, int b)
{
    if (a < b)
    {
        Console.WriteLine($"min = {a}, max = {b}");
    }
    else
    {
        Console.WriteLine($"min = {b}, max = {a}");
    }
}
BiggerSmaller(a2, b2);

// Альтернатива без void метода
int Big(int NumA, int NumB)
{
    if (NumA < NumB)
    {
        return NumB;
    }
    return NumA;
}
int Small(int NumA, int NumB)
{
    if (NumA < NumB)
    {
        return NumA;
    }
    return NumB;
}
Console.WriteLine($"Большее:{Big(a2,b2)}, Меньшее: {Small(a2,b2)}");

//Альтернатива 2
int[] BigSmallArr(int NumA, int NumB) //метод сравнивает два числа, возврат в 0 индексе большее, в 1 индексе меньшее.
{
    int[] result = new int[2];
    if (NumA < NumB)
    {
        result[0] = NumB;
        result[1] = NumA;
    }
    else
    {
        result[0] = NumA;
        result[1] = NumB;
    }
    return result;
}
Console.WriteLine($"Большее:{BigSmallArr(a2,b2)[0]}, Меньшее: {BigSmallArr(a2,b2)[1]}");

//Альтернатива 3
(int B, int S) BigSmall(int NumA, int NumB) //через кортеж ? уместно ли ?
{
    if (NumA < NumB)
    {
        return (B: NumB, S: NumA);
    }
    return (B: NumA, S: NumB);
}

(int Big, int Small) NumSortBS = BigSmall(a2, b2);
Console.WriteLine($"Большее:{NumSortBS.Big}, Меньшее: {NumSortBS.Small}");
