Console.Write("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите Второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
if (a < b)
{
    Console.WriteLine("max = " + b);
    Console.WriteLine("min = " + a); 
}
else
{
    Console.WriteLine("max = " + a);
    Console.WriteLine("min = " + b);
}