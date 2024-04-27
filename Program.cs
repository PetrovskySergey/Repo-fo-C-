﻿// Задайте значения M и N. Напишите программу, 
// которая выведет все натуральные числа в промежутке 
// от M до N. Использовать рекурсию, не использовать циклы.

// void FromMtoN(int m, int n)
// {
// if (m > n)
// {
// FromMtoN(m - 1, n);
// System.Console.Write(m + " ");
// }
// else if (n > m)
// {
// FromMtoN(m, n - 1);
// System.Console.Write(n + " ");
// }
// else System.Console.Write(m + " ");
// }
// FromMtoN(2, 8);


// Напишите программу вычисления функции Аккермана с помощью
//  рекурсии. Даны два неотрицательных числа m и n.


Console.Write("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());

AkkermanFunction(m,n);


// вызов функции Аккермана
void AkkermanFunction(int m, int n)
{
    Console.Write(Akkerman(m, n)); 
}

// функция Аккермана
int Akkerman(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0 && m > 0)
    {
        return Akkerman(m - 1, 1);
    }
    else
    {
        return (Akkerman(m - 1, Akkerman(m, n - 1)));
    }
}