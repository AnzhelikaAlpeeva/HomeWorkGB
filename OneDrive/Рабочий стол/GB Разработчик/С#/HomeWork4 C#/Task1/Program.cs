// Напишите цикл, который принимает на вход два числа (A и B) и 
// возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int Number(string message)
{
Console.WriteLine(message);
int result = int.Parse(Console.ReadLine());
return result;
}

int Expo(int A, int B)
{
    int expo = 1;
    for(int i = 0; i < B; i++)
    {
        expo *= A;
    }
    return expo;
}

int A = Number("Введите число: ");
int B = Number("Введите степень: ");
Console.WriteLine($"{Expo(A, B)}");