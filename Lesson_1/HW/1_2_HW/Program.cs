﻿// Задача 4: Напишите программу, которая принимает на вход три числа 
// и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22


string na = Console.ReadLine()!;
string nb = Console.ReadLine()!;
string nc = Console.ReadLine()!;

int a = int.Parse(na);
int b = int.Parse(nb);
int c = int.Parse(nc);
int max = a;

if(a > max) max = a;
if(b > max) max = b;
if(c > max) max = c;

Console.Write("max = ");
Console.WriteLine(max);