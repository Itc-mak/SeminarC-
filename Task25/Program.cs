Console.WriteLine("Введите первое число");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int b = Convert.ToInt32(Console.ReadLine());
int res = a;
int i = 0;
for (i = 1; i <= b-1; i++)
res = res * a;
Console.WriteLine(res);
