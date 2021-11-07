// 18. Проверить истинность утверждения ¬(X ⋁ Y) = ¬X ⋀ ¬Y

// Проверка на "листочке"
// Исх   Лев Ч   Прав Ч
// 0/0     1       1
// 0/1     0       0
// 1/0     0       0
// 1/1     0       0
// Вывод должны получить в итоге true

bool solveTester()
{
    for (int i = 0; i < 2; i++)
    {
        for (int j = 0; j < 2; j++)
        {
            bool x = Convert.ToBoolean(i);
            bool y = Convert.ToBoolean(j);
            if (!((!(x || y)) == (!x && !y)))
            {
                return false;
            }
        }
    }
    return true;
}
Console.WriteLine(solveTester());
