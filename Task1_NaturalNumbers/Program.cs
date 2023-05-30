Console.WriteLine("Введите число N:");
int n = int.Parse(Console.ReadLine());
PrintNumbers(n);
Console.ReadLine();
static void PrintNumbers(int n)
{
  if(n > 0)
  {
    Console.WriteLine(n);
    PrintNumbers(n - 1);
  }
}