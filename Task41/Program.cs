Console.WriteLine("Введите колличество чисел: ");
int n = Convert.ToInt32(Console.ReadLine());
int count = 0;
for (int i = 0; i < n; i++)
{
  Console.WriteLine("Введите число : ");
  int x = Convert.ToInt32(Console.ReadLine());
  if (x > 0)
  count++;
}
Console.WriteLine($"Количество положительных чисел-> {count}");