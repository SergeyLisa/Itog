﻿
// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.WriteLine("Введите начальное число M:");
int numM = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите начальное число N:");
int numN = int.Parse(Console.ReadLine()!);

int AckFun (int numM, int numN)
{
    if (numM == 0) return numN + 1;
    if (numN == 0) return AckFun(numM - 1, 1);
    if (numM > 0 && numN > 0) return AckFun(numM - 1, AckFun(numM, numN - 1));
return AckFun(numM, numN);
}

Console.WriteLine($"Функция Аккермана для чисел A({numM},{numN}) = {AckFun(numM, numN)}");