// Задача 46: Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
// m = 3, n = 4.
// 1 4 8 19
// 5 -2 33 -2
// 77 3 8 1

// System.Console.Write("Введите количество строк M: ");
// int M = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("Введите количество столбцов N: ");
// int N = Convert.ToInt32(Console.ReadLine());

// void CreateAndPrintMatrix(int a, int b)
// {
//     Random rnd = new Random();
//     int[,] arr = new int[a, b];
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//             int add = rnd.Next(1, 10);
//             arr[i, j] = add;
//         }
//     }
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//             System.Console.Write($"{arr[i,j]} ");
//         }
//         System.Console.WriteLine();
//     }
// }

// CreateAndPrintMatrix(M, N);


// Задайте двумерный массив размера m на n, 
// каждый элемент в массиве находится по формуле: A = m+n. 
// Выведите полученный массив на экран.
// m = 3, n = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5

// int m = ReadInt("Введите m ");
// int n = ReadInt("Введите n ");
// CreateNewMatrix(m, n);


// void CreateNewMatrix(int a, int b)
// {
//     int[,] arr = new int[a, b];
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//             arr[i, j] = i + j;
//         }
//     }
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//             System.Console.Write($"{arr[i,j]} ");
//         }
//         System.Console.WriteLine();
//     }
// }


// Задайте двумерный массив. Найдите элементы, у 
// которых оба индекса чётные, и замените эти элементы на их 
// квадраты.
// Например, изначально массив
// выглядел вот так:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Новый массив будет выглядеть 
// вот так:
// 1 4 7 2
// 5 81 2 9
// 8 4 2 4 






// Задача 51: Задайте двумерный массив. Найдите сумму 
// элементов, находящихся на главной диагонали (с индексами 
// (0,0); (1;1) и т.д.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12

