﻿// 22. Найти расстояние между точками в пространстве 2D/3D
string printPointArr(double[] arr) //печать массива точки
{
    string result ="(";
    for (int i=0;i < arr.Length;i++)
    {
        result = result + arr[i] + ", ";   
    }
    return result.TrimEnd(' ', ',')+")";
}

double DoubleRndNum (double min, double max) => new Random().NextDouble()*(max-min)+min; //произвольное действительно число между Мин и Макс 

double[] createPoint (int dimensionsNum) //создаём массив координат точки
{
    double[] point = new double[dimensionsNum];
    for (int i=0; i < point.Length; i++)
    {
        point[i] = DoubleRndNum(-100,100);
    }
    return point;
}

double dist2D(double[] point1, double[] point2) => Math.Sqrt(Math.Pow(point2[0]-point1[0],2) + Math.Pow(point2[1]-point1[1],2));
double dist3D(double[] point1, double[] point2) => Math.Sqrt(Math.Pow(point2[0]-point1[0],2) + Math.Pow(point2[1]-point1[1],2)+ Math.Pow(point2[2]-point1[2],2));

double distUniveral(double[] point1, double[] point2) //точки должны быть с одинаковой мерностью
{
    int dimesions = point1.Length;
    double value = 0;
    for (int i = 0; i < dimesions; i++)
    {
        value = value + Math.Pow(point2[i]-point1[i],2);
    }
    return value = Math.Sqrt(value);
}

double[] point1_2D = createPoint(2); //создаем точку 1
double[] point2_2D = createPoint(2); //создаем точку 2
Console.WriteLine(printPointArr(point1_2D)); //координаты точки 1
Console.WriteLine(printPointArr(point2_2D)); //координаты точки 2
Console.WriteLine(dist2D(point1_2D,point2_2D)); //расстояние методом только для двумерного пространства
Console.WriteLine(distUniveral(point1_2D,point2_2D)); //используя универсальный метод для точек любой мерности

double[] point1_3D = createPoint(3); //создаем точку 1
double[] point2_3D = createPoint(3); //создаем точку 2
Console.WriteLine(printPointArr(point1_3D)); //координаты точки 1
Console.WriteLine(printPointArr(point2_3D)); //координаты точки 2
Console.WriteLine(dist3D(point1_3D,point2_3D)); //расстояние методом только для трёхмерного пространства
Console.WriteLine(distUniveral(point1_3D,point2_3D)); //используя универсальный метод для точек любой мерности

// point1_2D[0] = 0;
// point1_2D[1] = 10;
// point2_2D[0] = 0;
// point2_2D[1] = 0;
// Console.WriteLine(printPointArr(point1_2D));
// Console.WriteLine(printPointArr(point2_2D));
// Console.WriteLine(dist2D(point1_2D,point2_2D));
// Console.WriteLine(distUniveral(point1_2D,point2_2D));
