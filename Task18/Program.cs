// 18. Проверить истинность утверждения ¬(X ⋁ Y) = ¬X ⋀ ¬Y

// Проверка на "листочке"
// Исх   Лев Ч   Прав Ч
// 0/0     1       1
// 0/1     0       0
// 1/0     0       0
// 1/1     0       0
// Вывод должны получить в итоге true

// //Вариант 1, тупо перебор, но работает только на вписанное в код утверждение => фу-фу-фу
// bool solveTester()
// {
//     for (int i = 0; i < 2; i++) //???Как циклом перебрать Булево???
//     {
//         for (int j = 0; j < 2; j++)
//         {
//             bool x = Convert.ToBoolean(i);
//             bool y = Convert.ToBoolean(j);
//             if (!((!(x || y)) == (!x && !y)))
//             {
//                 return false;
//             }
//         }
//     }
//     return true;
// }
// Console.WriteLine(solveTester());

// OBSOLETE //написал метод получепния начальных условий исходя из кол-ва переменных, более не нужно задавать вручную
// bool[] X = { true, true, false, false }; //варианты начальных параметров, на самом деле зависит от количества переменных (руками создан вариант для 2-х перменных)
// bool[] Y = { true, false, true, false };
// OBSOLETE

bool[] baseBoolArr(int paramTotalCount, int paramNum) //создатель базовых исходов входных параметров (общее кол-во переменных, номер переменной)
{
    int arrLen = (int)Math.Pow(2, paramTotalCount);
    bool[] result = new bool[arrLen];
    bool curBool = true;
    int y = 1;
    for (int i = 0; i < arrLen; i++)
    {
        if (y > arrLen / (int)Math.Pow(2, paramNum))
        {
            curBool = !curBool;
            y = 1;
        }
        result[i] = curBool;
        y++;
    }
    return result;
} //???Мысли про метод: можно переписать на метод возвращающий массив массивов с входным параметров тоолько: (кол-во переменных)

bool[] AND(bool[] a, bool[] b) //метод  для заданных двух входных параметров возвращает таблицу соотвествия применяя к ним И
{
    bool[] result = new bool[4];
    for (int i = 0; i < a.Length; i++)
    {
        result[i] = a[i] && b[i];
    }
    return result;
}

bool[] OR(bool[] a, bool[] b) //метод  для заданных двух входных параметров возвращает таблицу соотвествия применяя к ним ИЛИ
{
    bool[] result = new bool[4];
    for (int i = 0; i < a.Length; i++)
    {
        result[i] = a[i] || b[i];
    }
    return result;
}

bool[] NOT(bool[] a) //метод  для заданного параметра возвращает таблицу соотвествия применяя к нему НЕ
{
    bool[] result = new bool[4];
    for (int i = 0; i < a.Length; i++)
    {
        result[i] = !a[i];
    }
    return result;
}

bool isRight(bool[] a, bool[] b) //метод сравнивает две таблицы, на равенство друг другу, сообщает верно ли логическое утверждение
{
    for (int i = 0; i < a.Length; i++)
    {
        if (a[i] != b[i]) { return false; }
    }
    return true;
}

bool[] X = baseBoolArr(2, 1); //инициируем переменную X
bool[] Y = baseBoolArr(2, 2); //инициируем переменную Y
Console.WriteLine($"Значения X {string.Join(",",X)}"); //debugging result check
Console.WriteLine($"Значения У {string.Join(",",Y)}"); //debugging result check

Console.WriteLine(isRight(NOT(OR(X, Y)), AND(NOT(X), NOT(Y)))); //вроверка правильности утверждения

// "Задача 15"
// ---
// Проверить является ли логическое выражение тождеством
// - ¬(X ⋀ Y) ⋀ (X ⋁ Y) = X ⊕ Y
// - ¬(X or Y) = ¬X ⋀ ¬Y
// - (X ⊕ Y) ⋀ X = X ⋀ ¬Y

// ¬ - _отрицание, инверсия;_<br>
// ⋀ - _конъюнкция, логическое умножение, операция "И", операция "AND";_<br>
// ⋁ - _дизъюнкция, нестрогая дизъюнкция, логическое сложение, операция "ИЛИ", операция "OR";_<br>
// ⊕ - _строгая дизъюнкция, разделительная дизъюнкция, исключающее "ИЛИ"_


bool[] XOR(bool[] a, bool[] b) //исключающее ИЛИ
{
    bool[] result = new bool[4];
    for (int i = 0; i < a.Length; i++)
    {
        result[i] = a[i] ^ b[i];
    }
    return result;
}

Console.WriteLine($"Верно ли выражение ¬(X and Y) and (X or Y) = X xor Y ? Ответ:{isRight(AND(NOT(AND(X, Y)), OR(X, Y)), XOR(X, Y))}");
Console.WriteLine(string.Join(",",AND(X, Y))); // проверка (вертикальная таблица истинности) - 1 действие левой части
Console.WriteLine(string.Join(",",OR(X, Y))); // проверка (вертикальная таблица истинности) - 2 дейтсвие левой части
Console.WriteLine(string.Join(",",NOT(AND(X, Y)))); // проверка (вертикальная таблица истинности) - 3 действие левой части
Console.WriteLine(string.Join(",",AND(NOT(AND(X, Y)), OR(X, Y)))); // проверка (вертикальная таблица истинности) - 4 действие левой части
Console.WriteLine(string.Join(",",XOR(X, Y))); // проверка (вертикальная таблица истинности) - правая часть
Console.WriteLine($"Верно ли выражение ¬(X or Y) = ¬X and ¬Y ? Ответ:{isRight(NOT(OR(X, Y)), AND(NOT(X), NOT(Y)))}");
Console.WriteLine($"Верно ли выражение (X xor Y) and X = X and ¬Y ? Ответ:{isRight(AND(XOR(X, Y), X), AND(X, NOT(Y)))}");
