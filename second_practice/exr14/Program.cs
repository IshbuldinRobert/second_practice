﻿// программа, которая принимаетна вход число и проверяет, кратно ли оно одновременно 7 и 23
// например: 14 -> нет, 46 -> нет, 161 -> да

int x = new Random().Next(1, 10000);

if ((x % 7 == 0) && (x % 23 == 0))
    Console.WriteLine($"{x} -> да");
else Console.WriteLine($"{x} -> нет");