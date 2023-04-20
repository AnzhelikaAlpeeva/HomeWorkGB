// Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

int a = ReadN("Число ");
int ReadN(string a)
{
    Console.WriteLine("Введите число: ");

    int i;
    while(! int.TryParse(Console.ReadLine(), out i))
    {
        Console.WriteLine("Это не число");
    }
    return i;
}

int[] Array(int a)
{
    int[] arr = new int[a]; 
    
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = (int) Math.Pow(i+1, 3);
    }
    return arr;
}

System.Console.WriteLine(String.Join(", ", Array(a)));