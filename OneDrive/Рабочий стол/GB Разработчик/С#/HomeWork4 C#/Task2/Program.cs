// Напишите программу, которая принимает 
// на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int Number(string message)
{
    Console.WriteLine(message);
    int num = int.Parse(Console.ReadLine());
    return num;
}

int Sum(int number)
{
    int num = 0;
    while(number > 0)
    {
        num += number % 10;
        number = number / 10;
    }
    return num;
}

int number = Number("Введите число: ");
Console.WriteLine($"{Sum(number)}");