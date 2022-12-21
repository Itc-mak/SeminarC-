void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 11); // [1, 10]
            Console.Write($"{matrix[i, j]} \t");
        }
        Console.WriteLine();
    }
}

void Proizvedenie(int[,] matrix, int[,] matr)
{ 
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
                     Console.Write($"{matrix[i, j] * matr[i,j]} \t");
                 }
                 Console.WriteLine();
             }  
        }


Console.Clear();
Console.Write("Введите размер матриц: ");
int[] coord = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int[coord[0], coord[1]];
int[,] matr = new int[coord[0], coord[1]];
Console.WriteLine("Начальный массив 1");
InputMatrix(matrix);
Console.WriteLine();
Console.WriteLine("Начальный массив 2");
InputMatrix(matr);
Console.WriteLine();
Console.WriteLine("Конечный массив");
Proizvedenie(matrix, matr);
