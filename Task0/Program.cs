// 0. Вывести квадрат числа
Console.WriteLine(); //лишняя красота
Console.WriteLine("Задача 0: Вывести квадрат числа"); //лишняя красота
// Первый раз
int SquareNum(int N) { return N * N; } //изобретаем велосипед с костылями пишем свой метод возведения в квадрат

int Num0 = new Random().Next(-50, 50);
Console.WriteLine($"Число {Num0} в квадрате = {SquareNum(Num0)}");

// Альтернатива
Console.WriteLine($"Число {Num0} в квадрате = {Math.Pow(Num0, 2)}"); //через готовый метод

