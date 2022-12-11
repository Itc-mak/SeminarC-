Console.Write("Введите количество цифр: ");
int n = Convert.ToInt32(Console.ReadLine());
int count = 0;
for (int i = 0; i < n; i++)
{
int a = Convert.ToInt32(Console.ReadLine());
if (a > 0)
count++;
}
Console.WriteLine($"Количество положительных чисел: {count}");