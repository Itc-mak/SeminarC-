Console.Write("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число: ");
int c = Convert.ToInt32(Console.ReadLine());
if (a>b && a>c)
{
    Console.Write("max = " + a);
}
else if (b>a && b>c)
{
    Console.Write("max = " + b);
}
else if (c>a && c>b)
{
    Console.Write("max = " + c);
}
else
{
    Console.Write("Вы ввели одинаковые числа, попробуйте сначала");
}