// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

Console.WriteLine("Введите количество элементов массива: ");
int N = int.Parse(Console.ReadLine());
int[] randomArray = new int[N];

void Rand(int N)
{
    for(int i = 0; i < N; i++)
    {
        randomArray[i] = new Random().Next(100, 999);
        Console.Write(randomArray[i] + " ");
    }
}

int even(int[] randomArray)
{
    int even = 0;
    for(int i = 0; i < randomArray.Length; i++)
    {
        if (randomArray[i] % 2 == 0)
        even = even + 1;
    }
    return even;
}


Rand(N);
Console.WriteLine($"Количество чётных чисел в массиве: {even(randomArray)}");