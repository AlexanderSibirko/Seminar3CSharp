// 42. Определить сколько чисел больше 0 введено с клавиатуры

// метод ввода с клавиатуры, заполняем массив ? считаем сколько из них 0, или пишем Лог, потом парсим Лог =)
// ввод строка через ","

// 1) Разделить строку на подстроки (разделённые ,) Подстроки загнать в массив ?
// 2) Проверять каждую строку массива на преобразование в число.
// 3) Посчитать кол-во чисел больше 0, в получишвемся массиве чисел.

string[] splitString(string S, char Delimiter) //пока рассматриваем для одного варианта разделителя
{
    int sLen = S.Length;
    string[] subStrings = new string[sLen]; //худший вариант
    int subStri = 0;
    for (int i = 0; i < sLen; i++)
    {
        if (S[i] == Delimiter)
        {
            subStri++;
        }
        else
        {
            subStrings[subStri] += S[i];
            // Console.WriteLine(subStrings[j]); //debug code
        }
    }
    Array.Resize(ref subStrings, subStri + 1);
    return subStrings;
}

bool checkIfNumber(string S) //ещё проверять "-", если хотябы один символ не удовлетворяет цифре, то говорим что не число, метод который можно применить к поиску не только цифр (но более трудоёмкий, так как делаем перебор)
{
    S = S.Trim(); //пробелы в начале и в конце не считаем проблемой, просто их откидываем
    bool isNumber = false;
    char[] digits = { '1', '2', '3', '4', '5', '6', '7', '8', '9', '0' };
    for (int i = 0; i < S.Length; i++)
    {
        isNumber = false;
        if (i == 0 && S[0] == '-')
        {
            continue;
        }
        for (int j = 0; j < digits.Length; j++)
        {
            if (S[i] == digits[j])
            {
                isNumber = true;
                break;
            }
        }
        if (isNumber == false)
        {
            break;
        }
    }
    return isNumber;
}

bool checkIfNumber2(string S) //если хотябы один символ не удовлетворяет цифре, то говорим что не число (проверяем по номеру в таблице кодировки)
{
    S = S.Trim(); //пробелы в начале и в конце не считаем проблемой, просто их откидываем
    bool isNumber = false;
    for (int i = 0; i < S.Length; i++)
    {
        isNumber = false;
        if (i == 0 && (char)S[0] == 45)
        {
            continue;
        }
        if ((char)S[i] <= 57 && (char)S[i] >= 48) //цифры 0-9 находятся в таблице символов char на позициях 48-57
        {
            isNumber = true;
        }
        if (isNumber == false)
        {
            break;
        }
    }
    return isNumber;
}

int[] makeIntArr(string[] sArr)
{
    int sArrLen = sArr.Length;
    int[] intArr = new int[sArrLen];
    int intArri = 0;
    for (int sArri = 0; sArri < sArrLen; sArri++)
    {
        if (sArr[sArri] != null)
        {
            if (checkIfNumber(sArr[sArri]))
            {
                intArr[intArri] = Int32.Parse(sArr[sArri]);
                intArri++;
            }
        }
    }
    Array.Resize(ref intArr, intArri);
    return intArr;
}

int[] makeIntArr2(string[] sArr)
{
    int sArrLen = sArr.Length;
    int[] intArr = new int[sArrLen];
    int intArri = 0;
    for (int sArri = 0; sArri < sArrLen; sArri++)
    {
        if (sArr[sArri] != null)
        {
            if (checkIfNumber2(sArr[sArri]))
            {
                intArr[intArri] = Int32.Parse(sArr[sArri]);
                intArri++;
            }
        }
    }
    Array.Resize(ref intArr, intArri);
    return intArr;
}

int sumAboveZero(string S)
{
    int sum = 0;
    int[] numsArr = makeIntArr(splitString(S, ','));
    for (int i = 0; i < numsArr.Length; i++)
    {
        if (numsArr[i] > 0)
        {
            sum++;
        }
    }
    return sum;
}

Console.WriteLine("Введите числа через ',' (не более 100):"); // для дробных чисел как разделитель использовать '.', лишние пробелы в начале или в конце не считаем грубой "ошибкой"
string userString = Console.ReadLine();
string[] splited = splitString(userString, ','); //test splitter
Console.WriteLine(String.Join("|", splited));

int[] newIntArr = makeIntArr(splited); //test makeing int array our of splitted array
Console.WriteLine(String.Join("|", newIntArr));

int[] newIntArr2 = makeIntArr2(splited); //test makeing int array our of splitted array (2nd method)
Console.WriteLine(String.Join("|", newIntArr2));

Console.WriteLine(sumAboveZero(userString));