// Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

// M = 1; N = 5. -> ""1, 2, 3, 4, 5""

// M = 4; N = 8. -> ""4, 6, 7, 8""

int PrintN(int m, int n)
{
    if (m == n)
    {
        return n;
    }
    else
    {
        Console.Write($"{m}, ");
        return PrintN(m + 1, n);
    }
}
Console.WriteLine("Введите начальное число");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите конечное число");
int n = int.Parse(Console.ReadLine());
Console.Write(PrintN(m, n));