// 47. Написать программу копирования массива

// написать свою или есть котовый метод Array.Copy
// ?Что значит копировать? В новый массив или куда?

T[] CopyArray <T> (T[] inputArr)
{
    T[] res = new T[inputArr.Length];
    for (int i = 0; i < inputArr.Length;i++)
    {
        res[i] = inputArr[i];
    }
    return res;
}

string[] stringArr = {"432","4324","regreg"};
int[] intArr = {432,324,4534};
double[] doubleArr = {334.23,3543.66,0.0001};

Console.WriteLine(string.Join('|',CopyArray<string>(stringArr)));
Console.WriteLine(string.Join('|',CopyArray<int>(intArr)));
Console.WriteLine(string.Join('|',CopyArray<double>(doubleArr)));