int Sum(int m, int n)
{
  if (m == n)
    return m;
  return m + Sum(m + 1, n);
}

Console.Clear();
Console.Write("Введите первое число: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int m = Convert.ToInt32(Console.ReadLine());
if(n < m)
  Console.WriteLine($"Сумма чисел от {m} до {n} равняется: {Sum(n, m)}");
else
  Console.WriteLine($"Сумма чисел от {m} до {n} равняется: {Sum(m, n)}");
