// Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.WriteLine("Введите количество элементов массива: ");
int M = int.Parse(Console.ReadLine());
int[] Array = new int[M];

void EachElement(int M)
{
    for(int i = 0; i < M; i++)
    {
        Console.WriteLine($"Введите {i+1} элемент массива: ");
        Array[i] = int.Parse(Console.ReadLine());
    }
}

int MoreZero(int[] Array)
{
    int i = 0;
    int sum = 0;
    while(i < Array.Length)
    {
        if(Array[i] > 0)
        sum = sum + 1;
        i++;
    }
    return sum;
}

EachElement(M);
Console.WriteLine($"Чисел больше нуля: {MoreZero(Array)}");