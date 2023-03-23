// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


int NumbersSum(int m, int n)
{
  if (m > n) return 0;
  else
  {
    return m + NumbersSum(m + 1, n);
  }
}
Console.Clear();
Console.Write("Введите число от: ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Введите число до: ");
int n = int.Parse(Console.ReadLine()!);
int sum = NumbersSum(m, n);
Console.Write(sum);