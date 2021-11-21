// 41. Выяснить являются ли три числа сторонами треугольника

// определяем по формуле соотношения сторон треугольника (если 3 числа ему удовлетворяют, то это треугольник, если нет, то это не треугольник) a < b + c (находим макс, потом сумму не макс и срваниваем)
// Ввод данных: 3 числа через "," или " "

Console.WriteLine("Введите числа через ',' (не более 100):"); // для дробных чисел как разделитель использовать '.'
string userString = Console.ReadLine();

string[] splitString(string S, char delimiter) //пока рассматриваем для одного варианта разделителя
{
    string[] subStrings = S.Split(delimiter); //худший вариант
    return subStrings;
}

double[] subStringToDouble (string[] S)
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

// (bool result, string error) checkTriangle(double[] sides)
// {
//     int Len = sides.Length;
//     if (Len != 3) {}
// }

Console.WriteLine(String.Join("|",subStringToDouble(splitString(userString,','))));