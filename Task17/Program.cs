// 17. По двум заданным числам проверять является ли одно квадратом другого
int a; 
int b;
bool aSqrbYesNo(int Na, int Nb) => Na == Math.Pow(Nb,2) || Nb == Math.Pow(Na,2);

a = 6; b = 5;
Console.WriteLine($"Является ли одно из чисел {a},{b} квадратом другого числа? Ответ: {aSqrbYesNo(a, b)}");
a = -2; b = 4;
Console.WriteLine($"Является ли одно из чисел {a},{b} квадратом другого числа? Ответ: {aSqrbYesNo(a, b)}");
a = 9; b = 3;
Console.WriteLine($"Является ли одно из чисел {a},{b} квадратом другого числа? Ответ: {aSqrbYesNo(a, b)}");
a = -9; b = 4;
Console.WriteLine($"Является ли одно из чисел {a},{b} квадратом другого числа? Ответ: {aSqrbYesNo(a, b)}");