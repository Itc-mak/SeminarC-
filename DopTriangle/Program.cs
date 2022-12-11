Console.Write("Введите x1: ");
double x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите y1: ");
double y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите x2: ");
double x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите y2: ");
double y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите x3: ");
double x3 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите y3: ");
double y3 = Convert.ToInt32(Console.ReadLine());
double d1 = (Math.Sqrt(Math.Pow((x2-x1),2) + Math.Pow((y2-y1),2)));
double d2 = (Math.Sqrt(Math.Pow((x3-x2),2) + Math.Pow((y3-y2),2)));
double d3 = (Math.Sqrt(Math.Pow((x1-x3),2) + Math.Pow((y1-y3),2)));
double p = (d1 + d2 + d3)/2;
double sq = Math.Sqrt(p * (p -d1) * (p -d2) * (p -d3));
Console.WriteLine($"Площадь: {sq}");

