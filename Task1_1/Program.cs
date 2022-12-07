/* int n = new Random().Next(10,100);
int n1 = n/10;
int n2 = n%10;
Console.WriteLine($"Случайное число: {n}");
if (n1>n2)
    Console.Write(n1);
else
    Console.Write(n2); 

    int n = new Random().Next(100,1000);
    int n1 = n/100;
    int n2 = (n/10)%10;
    int n3 = n%10;
    Console.WriteLine($"Случайное число: {n}");
    Console.WriteLine(n1*10+n3);
Console.WriteLine("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
if (b % a == 0)
Console.WriteLine("Кратно");
else
Console.WriteLine(b%a); 

Console.WriteLine("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
if ((n % 7 == 0) && (n % 23 == 0))
Console.WriteLine("ДА");
else
Console.WriteLine("Нет");

Console.WriteLine("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
if ( (a == b * b) || (b == a * a))
Console.WriteLine("Да");
else
Console.WriteLine("Нет");

Console.Clear();

Console.Write("Введите четверть: ");
double x = Convert.ToDouble(Console.ReadLine());

if (x == 1)
    Console.WriteLine("x > 0 && y > 0");
else if (x == 2)
    Console.WriteLine("x < 0 && y > 0");
else if (x == 3)
    Console.WriteLine("x < 0 && y < 0");
else if (x == 4)
    Console.WriteLine("x > 0 && y < 0");
else
    Console.WriteLine("ошибка");


Console.Write("Введите x1: ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите y1: ");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите x2: ");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите y2: ");
double y2 = Convert.ToDouble(Console.ReadLine());
double z = 0;
z = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2));
Console.Write(z);


Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i <= n; i++)
    Console.Write(Math.Pow(i, 2) + " " ); 


Console.WriteLine("Введите число элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int [] array = new int[n];
for (int i = 0; i < array.Length; i++)
{
    Console.WriteLine("Введит элемент массива: ");
    array[i] = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine($"[{string.Join(", ", array)}]"); 

Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int res =1;
while (n / 10 != 0)
{
    n /= 10;
    res++;
}
Console.WriteLine(res);


 


Console.WriteLine("Введите число элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int [] array = new int[8];
for (int i = 0; i < array.Length; i++)
    array[i] = new Random().Next(0, 2);
Console.WriteLine($"[{string.Join(", ", array)}]"); 