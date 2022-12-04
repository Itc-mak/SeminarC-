Console.Write("Введите пятизначное число: ");
string c = Convert.ToString(Console.ReadLine());;
int len = c.Length;
if (len<=4 || len>=6)
Console.WriteLine("Ошибка, число не пятизначное. Попробуйте сначала");
else if (c[0] == c[4] && c[1] ==c[3])
Console.WriteLine("Палиндром ");
else
Console.WriteLine("не палиндром ");