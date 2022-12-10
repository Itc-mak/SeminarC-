void InputArray(int[] array)
{
for (int i = 0; i < array.Length; i++)
array[i] = new Random().Next(1, 50); 
}

int ReleaseArrayMax(int[] array)
{
    int max = 0;
for (int i = 0; i < array.Length; i ++)
{
    if ( max < array[i])
    max = array[i];
}
return max;
}

int ReleaseArrayMin(int[] array)
{
    int min = array[0];
for (int i = 1; i < array.Length; i++)
{
    if (array[i] < min) 
    min = array[i];
}
return min;
}


Console.Write("Введите кол-во элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
InputArray(array);
Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");
Console.WriteLine($"Максимальное: {ReleaseArrayMax(array)}");
Console.WriteLine($"Минимальное: {ReleaseArrayMin(array)}");
Console.WriteLine($"Разница: {ReleaseArrayMax(array) - ReleaseArrayMin(array)}");