Console.WriteLine("Введите число");
int n = Convert.ToInt32(Console.ReadLine());
if (n/100<=0)
    Console.WriteLine("Третьего числа нет");
else 
{
while (n > 1000)
    n /=10;
Console.WriteLine(n % 10);
}
