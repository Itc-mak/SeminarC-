Console.WriteLine("Введите трехзначное число: ");
int n = Convert.ToInt32(Console.ReadLine());
if ((n/100)<=0 || (n/100)>=10)
{
Console.WriteLine("Число не соответствует условию, попробуйте еще раз");
}
else
{
int n2 = n/10%10;
Console.WriteLine(n2);
}