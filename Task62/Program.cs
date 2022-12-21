void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " \t");
        }
        Console.WriteLine();
    }
}


Console.Write("Введите размер квадратного массива: ");
int coord = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[coord, coord];
int num = 1;
int i = 0;
int j = 0;

while (num <= Math.Pow(coord, 2))
{
    array[i, j] = num;
    if (i <= j + 1 && i + j < coord - 1)
        j++;
    else if (i < j && i + j >= coord - 1)
        i++;
    else if (i >= j && i + j > coord - 1)
        j--;
    else
        i--;
    num++;
}
PrintArray(array);