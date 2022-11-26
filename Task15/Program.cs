Console.WriteLine("Введите день недели числом от 1 до 7 включительно: ");
int n = Convert.ToInt32(Console.ReadLine());
if (n<=0 || n>7)
Console.WriteLine("Введенное число не соответсвует условию, повторите ввод!");
else
{
    if (n==6 || n==7)
    Console.WriteLine("Выходной");
    else
    Console.WriteLine("Не выходной");
}