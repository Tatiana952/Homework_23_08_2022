double Fact(int a)
{
  if (a == 0 || a == 1) return 1;
  return Fact(a-1) * a;
}

int n = Convert.ToInt32(Console.ReadLine())+1;

for (int i = 0; i < n; i++)
{
  for (int j = 0; j <= n-i; j++)
  {
    Console.Write("  ");
  }
  for (int j = 0; j <= i; j++)
  {
    double C = Fact(i)/(Fact(j)*Fact(i-j));
    if (C >= 1000) Console.Write(" ");
    else if (C >= 100) Console.Write("  ");
    else if (C >= 10) Console.Write("   ");
    else Console.Write("    ");
    Console.Write(C);
  }
  Console.WriteLine();
  Console.WriteLine();
}