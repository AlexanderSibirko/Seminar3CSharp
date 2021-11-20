// 42. Определить сколько чисел больше 0 введено с клавиатуры

// метод ввода с клавиатуры, заполняем массив ? считаем сколько из них 0, или пишем Лог, потом парсим Лог =)
// ввод строка через ","

// 1) Разделить строку на подстроки (разделённые ,) Подстроки загнать в массив ?
// 2) Проверять каждую строку массива на преобразование в число.
// 3) Посчитать кол-во чисел больше 0, в получишвемся массиве чисел.

Console.WriteLine("Введите числа через ',' (не более 100):"); // для дробных чисел как разделитель использовать '.', лишние пробелы в начале или в конце не считаем грубой "ошибкой"
string userString = Console.ReadLine();

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

string[] splited = splitString(userString, ',');
Console.WriteLine(String.Join("|", splited));

bool checkIfNumber(string S, char[] charsCheck) //если хотябы один символ не удовлетворяет цифре, то говорим что не число
{
    S = S.Trim(); //пробелы в начале и в конце не считаем проблемой, просто их откидываем
    bool isNumber = false;
    for (int i = 0; i < S.Length; i++)
    {
        isNumber = false;
        for (int j = 0; j < charsCheck.Length; j++)
        {
            if (S[i] == charsCheck[j])
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

bool checkIfNumber2(string S) //если хотябы один символ не удовлетворяет цифре, то говорим что не число
{
    S = S.Trim(); //пробелы в начале и в конце не считаем проблемой, просто их откидываем
    bool isNumber = false;
    for (int i = 0; i < S.Length; i++)
    {   
        isNumber = false;
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
    char[] digits = { '1', '2', '3', '4', '5', '6', '7', '8', '9', '0' };
    for (int sArri = 0; sArri < sArrLen; sArri++)
    {
        if (checkIfNumber(sArr[sArri],digits))
        {
            intArr[intArri] = Int32.Parse(sArr[sArri]);
            intArri++;
        }
    }
    Array.Resize(ref intArr,intArri);
    return intArr;
}

int[] newIntArr = makeIntArr(splited);

// char[] digits = { '1', '2', '3', '4', '5', '6', '7', '8', '9', '0' };
// for (int i = 0; i < splited.Length; i++)
// {
//     Console.WriteLine(checkIfNumber(splited[i],digits));
//     // Console.WriteLine(checkIfNumber2(splited[i]));
// }

Console.WriteLine(String.Join("|", newIntArr));