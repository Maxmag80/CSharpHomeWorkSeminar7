//Задача 50. Напишите программу, которая на вход принимает значение элемента в двумерном массиве,
//и возвращает позицию этого элемента или же указание, что такого элемента нет.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//17 -> такого числа в массиве нет
Console.WriteLine("input row number: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("input column number: ");
int col = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("input number for search: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[row, col];
bool count = false;

FillArray(array);
PrintArray(array);
Check(array);

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
            Console.Write($"{array[i, j],3} \t");
        Console.WriteLine();
    }
}
void Check(int[,] array)
{
    for (int k = 0; k < array.GetLength(0); k++)
        for (int l = 0; l < array.GetLength(1); l++)
        {    
            if(array[k, l] == n)
                count = true;
        }
}   
if(count == true)
{
    Console.Write($"position(s) of number {n} in this array is:  ");
    for (int o = 0; o < array.GetLength(0); o++)
        for (int p = 0; p < array.GetLength(1); p++)
        {    
            if(array[o, p] == n)
                Console.Write($"({o},{p})   ");
        }      
}
else Console.WriteLine($"there is no number {n} in this array");