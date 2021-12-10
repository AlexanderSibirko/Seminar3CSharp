// 41. Выяснить являются ли три числа сторонами треугольника

// определяем по формуле соотношения сторон треугольника (если 3 числа ему удовлетворяют, то это треугольник, если нет, то это не треугольник) a < b + c (находим макс, потом сумму не макс и срваниваем)
// Ввод данных: 3 числа через ","

Console.WriteLine("Введите 3 числа ',':"); // для дробных чисел как разделитель использовать '.'
string userString = Console.ReadLine();

string[] SplitString(string S, char delimiter) //пока рассматриваем для одного варианта разделителя
{
    string[] subStrings = S.Split(delimiter); //худший вариант
    return subStrings;
}

double[] SubStringToDouble (string[] S)
{
    int arrLen = S.Length;
    double[] doublesArr = new double[arrLen];
    for (int i = 0 ; i < arrLen; i++)
    {
        S[i] = S[i].Replace('.',','); //если виндовс русский - костыль
        double.TryParse(S[i],out doublesArr[i]);
    }
    return doublesArr;
}

double[] sides = SubStringToDouble(SplitString(userString,','));
double a = sides[0];
double b = sides[1];
double c = sides[2];

bool checkTriangle(double a, double b, double c)
{
    return a+b >= c && a+c >= b && b+c >= a;
}

Console.WriteLine(checkTriangle(a,b,c));
Console.WriteLine(checkTriangle(5,8,6));
Console.WriteLine(checkTriangle(15,6,7));
