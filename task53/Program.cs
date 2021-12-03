// 53. В двумерном массиве показать позиции числа, заданного пользователем или указать, 
// что такого элемента нет

int[,] CreateArray(int rowsCount, int columnsCount)
{
    return new int[rowsCount, columnsCount];
}

int[,] Fill2DArray(int[,] array2D, int minValue, int maxValue) //заполняем массив из диапозона [minValue..maxValue]
{
    for (int i = 0; i < array2D.GetLength(0); i++)
    {
        for (int j = 0; j < array2D.GetLength(1); j++)
        {
            array2D[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return array2D;
}

string Print2DArray(int[,] array2D)
{
    string print = string.Empty;
    for (int i = 0; i < array2D.GetLength(0); i++)
    {
        for (int j = 0; j < array2D.GetLength(1); j++)
        {
            print += $"{array2D[i, j],8} "; //выравнивание по 8 знаков
        }
        print += '\n';
    }
    return print;
}

int GetUserNumber()
{
    int userNumber;
    Console.Write("Введите число для поиска:");
    while(!Int32.TryParse(Console.ReadLine(), out userNumber))
    {
       Console.Write("Вы ввели не число =(, повторите ввод:");
    }
    return userNumber;
}

string FindAllNumberPositions(int[,] numbersArray, int searchValue)
{
    string result = string.Empty;
    for (int i = 0; i < numbersArray.GetLength(0); i++)
    {
        for (int j = 0; j < numbersArray.GetLength(1); j++)
        {
            if (numbersArray[i,j] == searchValue)
            {
                result += $"({i},{j}) ";
            }
        }
    }
    if (result == string.Empty) return $"Числа {searchValue} в массиве нет";
    return result.Trim();
}

int n = 6;
int k = 8;
int[,] testArray = CreateArray(n, k);
Fill2DArray(testArray, -10, 10);
Console.WriteLine(Print2DArray(testArray));

int a = GetUserNumber();

Console.WriteLine(FindAllNumberPositions(testArray,a));




