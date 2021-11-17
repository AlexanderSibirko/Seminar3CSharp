// 33. Задать массив из 12 элементов, заполненных числами из [0,9]. Найти сумму положительных/отрицательных элементов массива

// решение с семинара
// // Задать массив из 12 элементов, заполненных числами из [0,9].
// // Найти сумму положительных/отрицательных элементов массива

// int[] CreateArray(int count)
// {
//     return new int[count];
// }

// void FillArray(int[] array)
// {
//     int count = array.Length;
//     for (int i = 0; i < count; i++)
//     {
//         array[i] = new Random().Next(0, 10);
//     }
// }

// void FillArray2(int[] array, int minValue, int maxValue)
// {
//     int count = array.Length;
//     for (int i = 0; i < count; i++)
//     {
//         array[i] = new Random().Next(minValue, maxValue);
//     }
// }

// void PrintArray(int[] array)
// {
//     int count = array.Length;
//     for (int i = 0; i < count; i++)
//     {
//         Console.Write($"{array[i]} ");
//     }
// }

// string PrintArray2(int[] array)
// {
//     int count = array.Length;
//     string res = String.Empty;
//     for (int i = 0; i < count; i++)
//     {
//         res += $"{array[i]} ";
//     }
//     return res;
// }

// int Sum(int[] array)
// {
//     int count = array.Length;
//     int sumP = 0;
//     for (int i = 0; i < count; i++)
//     {
//         if (array[i] > 0) sumP += array[i];
//     }
//     return sumP;
// }

// int[] arr = CreateArray(10);
// FillArray2(arr, 0, 3);
// Console.WriteLine(PrintArray2(arr));
// int s = Sum(arr);
// Console.WriteLine(s);


// кортежи, или несколько значений из одного метода
// (int x, int y) GetPoint2D()
// {
//     return (x: 10, y: 20);
// }

// (int pX, int pY) point = GetPoint2D();
// Console.WriteLine(point);
// Console.WriteLine(point.pX);
// Console.WriteLine(point.pY);