﻿// Задача 6 - Папка: Task6a
// --- 
// Выяснить является ли вещественное m
// - целой степенью числа 3                     //в цикле делим m/3 пока не будет <= 1, если равно то является если меньше 1 то не является
// - корнем целой степени из 5,                 //в цикле делим 5/m пока не будет <= 1, если равно то является если меньше 1 то не является
// - синусом угла кратного 45 градусам          //возможные значение для sin(a) при a кратном 45°,  [0, √2/2, 1, -√2/2, -1]? Т.е. нужно проверить соответствие/кратность 0, ±√2/2, ±1
//alt+0176 = °, alt+251 = √, alt+0177 = ± (for windows)

double m = Math.Pow(3,5);

bool mIsIntPowOf3 (double N)
{
    return false;
}

