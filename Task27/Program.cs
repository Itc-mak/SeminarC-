
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine()), count = 1, result = 0;
while (n != 0)
{
count = n % 10;
n = n / 10;
result = result + count;
}
Console.WriteLine(result);
