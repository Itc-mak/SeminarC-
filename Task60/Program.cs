void InputMatrix(int[,,] matrix)
{
    int n = 6;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
             for (int p = 0; p < matrix.GetLength(2); p++)
            {
            matrix[i, j, p] = n++;
            Console.Write($"{matrix[i, j, p]} индекс ( {i}, {j}, {p} ) \t");
        }
        Console.WriteLine();
    }
}
}



Console.Clear();
Console.Write("Введите размер матриц: ");
int[] coord = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
int[,,] matrix = new int[coord[0], coord[1], coord[2]];
Console.WriteLine("Массив");
InputMatrix(matrix);
Console.WriteLine();

