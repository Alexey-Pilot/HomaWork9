
double Ackerman (double m, double n)
{
  if(m == 0) 
    return n + 1;
  if (m > 0 && n == 0) 
    return Ackerman(m - 1, 1);
  if (m > 0 && n > 0) 
    return Ackerman(m - 1, Ackerman(m, n - 1));
    
  return Ackerman(m, n);
}

Console.Clear();
Console.Write("Введите число M: ");
double m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число N: ");
double n = Convert.ToInt32(Console.ReadLine());


Console.WriteLine(Ackerman(m, n));