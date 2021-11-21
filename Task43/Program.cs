// 43. Написать программу преобразования десятичного числа в двоичное 

// вот тут вспомнить подумать, по сути цикл/рекурсия и вывернутое отображение 
// двочиных чисел нету (или они все двочиные для компа xD), можем лишь строковое отображение сделать в двоичном виде
// проблемы с отрицательными и дробными числами =)



string intToBit(int number)
{
    string resStr = string.Empty;
    if (number == 0)
    {
        return "0";
    }
    while (number > 0)
    {
        resStr = number % 2 + resStr;
        number = number / 2;
    }
    return resStr;
}

for (int i = 0; i <= 255; i++)
{
    Console.WriteLine($"{i} = {intToBit(i)} = {Convert.ToInt32(intToBit(i), 2)} = {Convert.ToString(i,2)}");
}