// Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.Write("Введите количество строк m массива: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов n массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] randomArray = new int[m,n];

void RandomElement(int m, int n)
{
    for(int i = 0; i < randomArray.GetLength(0); i++)
    {
        for(int j = 0; j < randomArray.GetLength(1); j++)
        {
            randomArray[i, j] = new Random().Next(1, 10);
            Console.Write($" {randomArray[i, j]} ");
        }
        Console.WriteLine();
    }
}

void AverageColumn(int m, int n)
{
    Console.Write("Среднее арифметическое каждого столбца: ");
    for(int j = 0; j < n; j++)
    {
        double sum = 0;
        for(int i = 0; i < m; i++)
        {
            sum = sum + randomArray[i,j];
        }
        Console.WriteLine($"{sum/m}");
    }
}

RandomElement(m, n);
AverageColumn(m, n);
