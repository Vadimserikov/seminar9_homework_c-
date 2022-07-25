// Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
int PrintN(int M, int N)
{
    if (M == N)
    {
        return N;
    }
    else
    {
        Console.Write($"{M}, ");
        return PrintN(M + 1, N);
    }
}
Console.WriteLine("Введите начальное число");
int M = int.Parse(Console.ReadLine());
Console.WriteLine("Введите конечное число");
int N = int.Parse(Console.ReadLine());
Console.Write(PrintN(M, N));
int sum = 0;
void PrintSum(int sum, int M, int N)
{
sum = sum + N;
  if (N <= M)
  {
    Console.Write($"Сумма элементов= {sum} ");
    return;
  }
}
PrintSum(sum,M,N);