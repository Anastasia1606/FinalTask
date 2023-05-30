Console.WriteLine("Введите числа M и N (M <= N):");
int m = int.Parse(Console.ReadLine());
int n = int.Parse(Console.ReadLine());
int sum = 0;
for (int i = m; i <=n; i++)
{
  if(i > 0)
  {
    sum += i;
  }
}
Console.WriteLine($"Сумма натуральных элементов в промежутке от {m} до {n}: {sum}");
Console.ReadLine();