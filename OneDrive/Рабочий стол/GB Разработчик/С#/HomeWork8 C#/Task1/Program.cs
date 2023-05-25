// Задайте двумерный массив. Напишите программу, которая 
// упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

void InitArray()
{
    int[,] array = FillArray();
    RandomArray(array);
    PrintArray(array);
    Console.WriteLine();
    ChangeArray(array);
}

int[,] FillArray()
{
    Console.Write("Enter m: ");
    int m = int.Parse(Console.ReadLine());
    Console.Write("Enter n: ");
    int n = int.Parse(Console.ReadLine());
    return new int[m,n];
}

void RandomArray(int [,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
       for (int j = 0; j < array.GetLength(1); j++)
       {
        array[i,j] = new Random().Next(1,9);
       }
    }
}

void PrintArray(int [,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
       for (int j = 0; j < array.GetLength(1); j++)
       {
            Console.Write($"{array[i,j]} ");
       }
        Console.WriteLine();
    }  
}

void ChangeArray(int [,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
       for (int j = 0; j < array.GetLength(1); j++)
       {
        for(int sort = 0; sort < array.GetLength(1) - 1; sort++)
        {
            if(array[i,sort] < array[i,sort + 1])
            {
                int temp = array[i, sort + 1];
                array[i, sort + 1] = array[i, sort];
                array[i, sort] = temp;
            }
            PrintArray(array);
        }
       }
    }
}

InitArray();
Console.WriteLine();
