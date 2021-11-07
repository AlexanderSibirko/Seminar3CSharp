// See https://aka.ms/new-console-template for more information
Console.WriteLine(); //лишняя красота
Console.WriteLine("Задача 15: Дано число. Проверить кратно ли оно 7 и 23"); //лишняя красота

bool dividableBy (int N15, int divider) => N15 % divider == 0;

int N15 = new Random().Next(-1000,1001);
Console.WriteLine($"Число: {N15}");
int dividerNum = 7;
Console.WriteLine(dividableBy(N15,dividerNum));
dividerNum = 23;
Console.WriteLine(dividableBy(N15,dividerNum));
