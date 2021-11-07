﻿// 19. Определить номер четверти плоскости, в которой находится точка с координатами Х и У, причем X ≠ 0 и Y ≠ 0
int X = 0;
while (X == 0) { X = new Random().Next(-10, 11); } //так как есть опасность при рандомизации получить 0, "крутим" пока будет не 0
int Y = 0;
while (Y == 0) { Y = new Random().Next(-10, 11); } //так как есть опасность при рандомизации получить 0, "крутим" пока будет не 0

int quaterOfPlane(int x, int y)
{
    switch (x, y)
    {
        case ( > 0, > 0):
            return 1;
        case ( < 0, > 0):
            return 2;
        case ( < 0, < 0):
            return 3;
        case ( > 0, < 0):
            return 4;
        default:
            return -1;
    }
}
Console.WriteLine($"Точка ({X},{Y} находиться в {quaterOfPlane(X,Y)} четверти проскости)");