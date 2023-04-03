// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
//m = 3, n = 4.
//0,5 7 -2 -0,2
//1 -3,3 8 -9,9
//8 7,8 -7,1 9 
Console.WriteLine("input m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("input n: ");
int n = Convert.ToInt32(Console.ReadLine());
double[,] array = new double[m, n];

FillArray(array);
PrintArray(array);

void FillArray(double[,] array)
{
    Random random = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] =  Math.Round(random.Next(-1000, 1001)*0.01, 2);
}

void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i, j],5} \t");
        Console.WriteLine();
    }
}