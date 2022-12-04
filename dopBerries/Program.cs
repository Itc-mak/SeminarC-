Console.WriteLine("Введите число кустов: ");
int n = Convert.ToInt32(Console.ReadLine());
int sum = 0;
int [] array = new int[n];
for (int i = 0; i < array.Length; i++)
    array[i] = Convert.ToInt32(Console.ReadLine());
for (int i =1; i < array.Length -1; i++)
{
    if (sum < array[i-1] + array [i] + array[i+1])
    sum = array[i - 1] + array [i] + array[i + 1];
}
 if (sum < array[n - 1] + array [n - 2] + array[0])
    sum = array[n - 1] + array [n - 2] + array[0];
 if (sum < array[0] + array [1] + array[n - 1])
    sum = array[0] + array [1] + array[n-1];
Console.WriteLine(sum);