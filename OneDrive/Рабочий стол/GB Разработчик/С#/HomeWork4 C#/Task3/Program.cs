// Напишите программу, которая задаёт массив 
// из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

Console.Write("Введите число (длину массива): ");
int number = int.Parse(Console.ReadLine());

int[] array = new int[number];

    for (int i = 0; i < number; i++)
    {
        array[i] = new Random().Next(number+1);
        Console.Write(array[i] + " ");
    }
Console.WriteLine();
