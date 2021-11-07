Console.WriteLine(); //лишняя красота
Console.WriteLine("Задача 15: Дано число. Проверить кратно ли оно 7 и 23"); //лишняя красота

int dividerNum1 = 7;
int dividerNum2 = 23;

//метод для кратности, остальное в консоли
bool dividableBy (int N15, int divider) => N15 % divider == 0;

int N15 = 49;
Console.WriteLine($"Число: {N15}");
Console.WriteLine((dividableBy(N15,dividerNum1) && dividableBy(N15,dividerNum2)));
N15 = 46;
Console.WriteLine($"Число: {N15}");
Console.WriteLine((dividableBy(N15,dividerNum1) && dividableBy(N15,dividerNum2)));
N15 = 161;
Console.WriteLine($"Число: {N15}");
Console.WriteLine((dividableBy(N15,dividerNum1) && dividableBy(N15,dividerNum2)));
Console.WriteLine();

//ИЛИ через два метода каждый решает свой мини кусочек
// bool dividableBy (int N15, int divider) => N15 % divider == 0; //метод возвращения кратности числу
bool doubledivider (int N15, int D1, int D2) => dividableBy(N15,D1) && dividableBy(N15,D2); //метод проверки кратности двум числам

N15 = 49;
Console.WriteLine($"Число: {N15}");
Console.WriteLine(doubledivider(N15,dividerNum1,dividerNum2));
N15 = 46;
Console.WriteLine($"Число: {N15}");
Console.WriteLine(doubledivider(N15,dividerNum1,dividerNum2));
N15 = 161;
Console.WriteLine($"Число: {N15}");
Console.WriteLine(doubledivider(N15,dividerNum1,dividerNum2));
Console.WriteLine();

//ИЛИ через один метод проверки кратности двум числам
bool dividableBytwo (int N15, int D1, int D2) => N15 % D1 == 0 &&  N15 % D2 == 0; //одним метод, как прошлое решени, но если надо будет проверять 3,4,5...N кратностей, то нету ничего готового
N15 = 49;
Console.WriteLine($"Число: {N15}");
Console.WriteLine(dividableBytwo(N15,dividerNum1,dividerNum2));
N15 = 46;
Console.WriteLine($"Число: {N15}");
Console.WriteLine(dividableBytwo(N15,dividerNum1,dividerNum2));
N15 = 161;
Console.WriteLine($"Число: {N15}");
Console.WriteLine(dividableBytwo(N15,dividerNum1,dividerNum2));
Console.WriteLine();

//ИЛИ без методов (не хорошо)
N15 = 49;
Console.WriteLine($"Число: {N15}");
Console.WriteLine(N15 % dividerNum1 == 0 && N15 % dividerNum1 == 0);
N15 = 46;
Console.WriteLine($"Число: {N15}");
Console.WriteLine(N15 % dividerNum1 == 0 && N15 % dividerNum1 == 0);
N15 = 161;
Console.WriteLine($"Число: {N15}");
Console.WriteLine(N15 % dividerNum1 == 0 && N15 % dividerNum1 == 0);
Console.WriteLine();
