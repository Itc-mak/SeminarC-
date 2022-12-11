/*Console.Write("Введите 1 число: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 2 число: ");
int m = Convert.ToInt32(Console.ReadLine());
if (m * m == n)
    Console.Write("yes");
else
    Console.Write("no");

Console.Write("Введите день недели:");
int n = Convert.ToInt32(Console.ReadLine());
while (n<1 || n>7)
{
    Console.Write("Вы ошиблись, введите день:");
    int n = Convert.ToInt32(Console.ReadLine());
}
if (n == 1)
Console.Write("Понедельник");
else if (n == 2)
Console.Write("Вторник");
else if (n == 3)
Console.Write("Среда");
else if (n == 4)
Console.Write("Четверг");
else if (n == 5)
Console.Write("Пятница");
else if (n == 6)
Console.Write("Суббота");
else 
Console.Write("Воскресенье");



Console.Write("Введите  число: ");
int n = Convert.ToInt32(Console.ReadLine());
int i = n * (-1);
while (i <= n)
{
    Console.Write($"{i} ");
    i =i+1;
}
Console.Write("Введите  число: ");
int n = Convert.ToInt32(Console.ReadLine());
int i = n * (-1)
for (int i + (-1)*n; i<=n;  i++)
    Console.Write(i + " ");*/


    

// task 31


/*void InputArray(int[] array)
{
for (int i = 0; i < array.Length; i++)
array[i] = new Random().Next(-9, 10); // [-9, 9]
}


void ReleaseArray(int[] array)
{
int sumNegative = 0, sumPositive = 0;
for (int i = 0; i < array.Length; i++)
{
if (array[i] > 0)
sumPositive += array[i];
else
sumNegative += array[i];
}
Console.WriteLine($"Сумма положительных чисел равна {sumPositive}");
Console.WriteLine($"Сумма отрицательных чисел равна {sumNegative}");
}


Console.Clear();
Console.Write("Введите кол-во элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
InputArray(array);
Console.WriteLine($"[{string.Join(", ", array)}]");
ReleaseArray(array);*/


// task 32

/*
void InputArray(int[] array)
{
for (int i = 0; i < array.Length; i++)
array[i] = new Random().Next(-9, 10); // [-9, 9]
}

void ReleaseArray(int[] array)
{
for (int i = 0; i < array.Length; i++)
array[i] = array [i] * (-1);
}
Console.Clear();
Console.Write("Введите кол-во элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
InputArray(array);
Console.WriteLine($"[{string.Join(", ", array)}]");
ReleaseArray(array);
Console.WriteLine($"[{string.Join(", ", array)}]");
*/


// task 32

/*
void InputArray(int[] array)
{
for (int i = 0; i < array.Length; i++)
array[i] = new Random().Next(-9, 10); // [-9, 9]
}


void ReleaseArray(int[] array)
{
for (int i = 0; i < array.Length; i++)
array[i] *= (-1);
}


Console.Clear();
Console.Write("Введите кол-во элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
InputArray(array);
Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");
ReleaseArray(array);
Console.WriteLine($"Конечный массив: [{string.Join(", ", array)}]");
*/

// task 33

/*
void InputArray(int[] array)
{
for (int i = 0; i < array.Length; i++)
array[i] = new Random().Next(-9, 10); // [-9, 9]
}


string ReleaseArray(int[] array, int k)
{
for (int i = 0; i < array.Length; i++)
{
if (array[i] == k)
return "yes";
}
return "no";
}


Console.Clear();
Console.Write("Введите кол-во элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
InputArray(array);
Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");
Console.Write("Введите число, которое нужно найти в массиве: ");
int k = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(ReleaseArray(array, k));


//task 35

void InputArray(int[] array)
{
for (int i = 0; i < array.Length; i++)
array[i] = new Random().Next(-9, 100); // [-9, 9]
}


int ReleaseArray(int[] array)
{
    int count = 0;
for (int i = 0; i < array.Length; i++)
{
if (array[i] >= 10 && array[i] <= 99)
count++;
}
return count;
}


Console.Clear();
Console.Write("Введите кол-во элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
InputArray(array);
Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");
Console.WriteLine(ReleaseArray(array));  */


//Task40
/*Console.WriteLine("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число: ");
int c = Convert.ToInt32(Console.ReadLine());
if ((a < b + c) && (b < a + c) && (c < a+c))
Console.WriteLine("Да");
else
Console.WriteLine("No");*/

//Task42 
/*
Console.WriteLine("Введитe число: ");
int a = Convert.ToInt32(Console.ReadLine());
string result = String.Empty;
while (n > 0)
{
result = Convert.ToString(n % 2) + result;
n /= 2;
}
Console.WriteLine(result);*/

//Task44
/*
Console.WriteLine("Введитe число:  ");
int n = Convert.ToInt32(Console.ReadLine());
int a0 = 0, a1 = 1, x;
for (int i = 0; i < n; i++)
{
Console.Write($"{a0} ");
x = a0 + a1;
a0 = a1;
a1 = x;
} */

//Task45
nt[] a = {1, 2, 3, 4, 5};
int[] b = new int[a.Length];

for (int i = 0; i < a.Length; i++)
b[i] = a[i];

b[0] = -1;
Console.WriteLine($"[{string.Join(", ", a)}]");
Console.WriteLine($"[{string.Join(", ", b)}]");
