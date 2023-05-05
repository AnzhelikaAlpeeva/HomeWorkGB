// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 4
// 8 4 2 4
// 17 -> такого числа в массиве нет

Console.Write("Введите количество строк m массива: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов n массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] randomArray = new int[m,n];
Console.Write("Введите позицию строки: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите позицию столбца: ");
int b = Convert.ToInt32(Console.ReadLine());

void ReturnElement(int m, int n)
{
    for(int i = 0; i < randomArray.GetLength(0); i++)
    {
        for(int j = 0; j < randomArray.GetLength(1); j++)
        {
            randomArray[i, j] = new Random().Next(10, 99);
            Console.Write($" {randomArray[i, j]} ");
        }
        Console.WriteLine();
    }
}
    
ReturnElement(m, n);

if(a < 0 | a > randomArray.GetLength(0) - 1 | b < 0 | b > randomArray.GetLength(1) - 1)
{
    Console.WriteLine("такого числа в массиве нет  ");
}
else
{
    Console.WriteLine("Значение элемента массива = {0}", randomArray[a, b]);
}





