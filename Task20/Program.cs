// 20. Ввести номер четверти, показать диапазоны для возможных координат

// Листочек бумаги (возможные выходы)
// 1. X > 0, Y > 0
// 2. X < 0, Y > 0
// 3. X < 0, Y < 0
// 4. X > 0, Y < 0
// В идеале нужно уточнение максимальных значений, без уточнения принимаем самое большое из того что знаем, это min и max от double

string PossibleCoordsDouble(int quater)
{
    switch (quater)
    {
        case 1:
            return $"(X( 0, {double.MaxValue}]) , Y( 0, {double.MaxValue}])";
        case 2:
            return $"(X[{double.MinValue}, 0)) , Y( 0, {double.MaxValue}])";
        case 3:
            return $"(X[{double.MinValue}, 0)) , Y[{double.MinValue}, 0))";
        case 4:
            return $"(X( 0, {double.MaxValue}]) , Y[{double.MinValue}, 0))";
        default:
            return "Четверть не обозначена";
    }
}

for (int i = 1; i < 5; i++) //проверяем результаты для всех 4-х четвертей
{
    Console.WriteLine(PossibleCoordsDouble(i));
}