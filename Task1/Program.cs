// Задайте значения M и N. Напишите программу, 
// которая выведет все натуральные числа в промежутке 
// от M до N. Использовать рекурсию, не использовать циклы.

void FromMtoN(int m, int n)
{
if (m > n)
{
FromMtoN(m - 1, n);
System.Console.Write(m + " ");
}
else if (n > m)
{
FromMtoN(m, n - 1);
System.Console.Write(n + " ");
}
else System.Console.Write(m + " ");
}
FromMtoN(2, 8);
