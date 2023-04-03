//Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
Console.WriteLine("input row number: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("input column number: ");
int col = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[row, col];
double[] result = new double[col];
double avg = 0;

FillArray(array);
PrintArray(array);
Average(array);
Console.WriteLine();
PrintResult(result);

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] =  new Random().Next(0, 10);
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"     {array[i, j],2} \t");
        Console.WriteLine();
    }
}
void Average(int[,] array)
{
    for (int i = 0; i < array.GetLength(1); i++)
    {
        for (int j = 0; j < array.GetLength(0); j++)
            avg = array[j, i] + avg;
        result[i] = Math.Round(avg / 3, 2);
        avg = 0;
    }
}   
void PrintResult(double[] result)
{
    for (int i = 0; i < result.Length; i++)
        Console.Write($"avg= {result[i],3} \t");
}