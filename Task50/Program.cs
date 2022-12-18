
void InputMatrix(int[, ] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(-10, 11);
            Console.Write($"{matrix[i, j]} \t");
        }
        Console.WriteLine();
    }
}

void ReleaseMatrix(int[,] matrix, int a, int b)
{
if (a > matrix.GetLength(0) || b > matrix.GetLength(1))
Console.WriteLine("такой позиции в массиве нет"); 
else
Console.WriteLine(matrix[a,b]);
}

Console.Clear();

int[,] matrix = new int[5,8];
InputMatrix(matrix);
Console.WriteLine ("Введите позицию элемента: ");
int[] poz = Console.ReadLine().Split(" ").Select(a => int.Parse(a)).ToArray();
ReleaseMatrix(matrix, poz[0] - 1, poz[1] - 1);