
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

void SrznachMatrix(int[, ] matrix)
{    
for (int j = 0; j < matrix.GetLength(1); j++)
{
double result = 0;
for (int i = 0; i < matrix.GetLength(0); i++)
{   
result += matrix[i,j];
}
Console.WriteLine($" Ответ {result / matrix.GetLength(0)}");
}
}

Console.Clear(); 
int[, ] matrix = new int[2,5];
InputMatrix(matrix);
SrznachMatrix(matrix);