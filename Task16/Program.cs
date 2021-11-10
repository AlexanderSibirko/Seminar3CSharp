// 16. Дано число обозначающее день недели. Выяснить является номер недели выходным днём

bool WeekendYN(int weekdayN) => weekdayN > 5; //решение для стран с выходыми днями Суббота и Воскресение

for (int i = 1; i <= 7; i++)
{
    Console.WriteLine($"{i} день недели выходной? Ответ: {WeekendYN(i)}");
}

// Альтернатива (на самом деле нужно уточнение, а какие дни недели считать выходными)
bool WeekendYN2(int weekdayN, bool[] weekDaysweekend) => weekDaysweekend[weekdayN - 1]; //решение сравнивая с шаблоном принятых выходных дней

bool[] weekendDays = { false, false, false, false, false, true, true }; //шаблон выходных дней: как мы привыкли "суббота" и "воскресение"
for (int i = 1; i <= 7; i++)
{ Console.WriteLine($"{i} день недели выходной? Ответ: {WeekendYN2(i, weekendDays)}"); }

bool[] weekendDays2 = { false, false, false, false, true, true, false }; //шаблон выходных дней: например для Израиля где выходные дни приняты 5ый и 6ой ("пятница" и "суббота")
for (int i = 1; i <= 7; i++)
{ Console.WriteLine($"{i} день недели выходной? Ответ: {WeekendYN2(i, weekendDays2)}"); }
