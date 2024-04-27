// Задайте произвольный массив. Выведете его элементы, начиная с конца.
//  Использовать рекурсию, не использовать циклы.

void Len(int num)
{
    if (num == 0) return;
    Console.Write($"{num} ");
    Len`(num - 1);
}
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
Len(n);

int[] num = [1, 2, 5, 0, 10, 34];
