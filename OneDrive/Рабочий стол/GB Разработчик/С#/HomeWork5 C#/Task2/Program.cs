// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов с нечётными индексами.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.WriteLine("Введите количество элементов массива: ");
int A = int.Parse(Console.ReadLine());
int[] randomArray = new int[A];

void FillArray(int A)
{
    for(int i = 0; i < A; i++)
    {
        randomArray[i] = new Random().Next(-10, 100);
        Console.Write($"{randomArray[i]} ");
    }
}

int SumOdd(int[] randomArray)
{
    int sum = 0;
    for(int i = 1; i < randomArray.Length; i = i + 2)
    {
        sum = sum + randomArray[i];
    }
    return sum;
}

FillArray(A);
Console.WriteLine($"Сумма элементов массива с нечетными индексами: {SumOdd(randomArray)}");