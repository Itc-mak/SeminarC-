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
Console.WriteLine("Нет");*/

Console.WriteLine("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
if ( (a == b * b) || (b == a * a))
Console.WriteLine("Да");
else
Console.WriteLine("Нет");