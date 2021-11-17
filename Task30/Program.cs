// 30. Показать кубы чисел, заканчивающихся на четную цифру


//!есть проблема с верхней границей! из-за неточности double
string pow3OfAllEvenMinMax (int minN, int maxN) //если числа заданы интервалом [min, max]
{
    string result = "";
    int mini = (int)Math.Pow(minN+1,1.0/3.0); //получаем ближаший корень кубический
    mini += mini % 2; //доводим до ближашего большего чётного
    // Console.WriteLine(mini); //debug code
    int maxi = (int)Math.Pow(maxN+1,1.0/3.0); //если не делать +1, то кубический корень 512 = 7,999999
    // Console.WriteLine(maxi); //debug code
    for (int i = mini; i <= maxi ; i += 2)
    {
        result += Math.Pow(i,3) + "\n";
    }
    return result.Trim(); //
}

// string pow3OfAllEvenFromArr (int[] numArr) //если числа заданы массивом (списком) WIP
// {
//     for (int i = )
//     string result = string.Empty;
//     return result;
// }

//вариант получения чисел для выполнения задачи интервалом [min, max]
int minN = 50; //передача min как отдельной переменной
int maxN = 2500; //передача max как отдельной переменной
Console.WriteLine(pow3OfAllEvenMinMax(minN, maxN));

// //вариант получения чисел для выполнения задачи списком интересующих "пользователя" чисел в виде массива 
// int[] Numbers = {2,46,342,6457,532,23,654,74};
// Console.WriteLine(pow3OfAllEvenFromArr(Numbers));