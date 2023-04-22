// палиндром для строк
// string s = "12a21";

// bool b = true;


// for (int i = 0; i < s.Length / 2; i++)
// {
// 	if (s[i] != s[s.Length - 1 - i])
// 	{
// 		b = false; break;
// 	}
// }

// Console.WriteLine(b);


// Задача Напишите программу, которая принимает на вход 
// число (А) и выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

// System.Console.WriteLine("Введите число А: ");
//   int A = int.Parse(Console.ReadLine());

//   int getsum(int number)
//   {
//    int sum = 0;

//   for (int i = 1; i <= A; i++)

//   sum += i;
//   return sum;
// }

// System.Console.WriteLine($"Сумма чисел от 1 до {A}^ {getsum (A)}");


// Задача 26: Напишите программу, которая принимает 
// на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

// Console.WriteLine("Введите число: ");
// int number = int.Parse(Console.ReadLine());

// int count = 0;
// while(number != 0)
// {
//     number /= 10;
//     count++;
// }
// Console.WriteLine($"Количество цифр в числе: {count}");

// Второе решение:

// Console.WriteLine("Введите число: ");
// int num = 0;
// while(!int.TryParse(Consile.ReadLine(), out num))
// {
//     Console.WriteLine("Это не число!");
// }
// int numDigit = 0;
// numDigit = NumberDigit(num);

// int NumberDigit(int number)
// {
//     number = Math.Abs(number);
//     int count = 0;
//     while(number > 0)
//     {
//         number = number / 10;
//         count++;
//     }
//     return count;
// }

// Console.WriteLine(numDigit);

// Console.WriteLine(byte.MaxValue);
// Console.WriteLine(byte.MinValue); // 8
// Console.WriteLine();
// Console.WriteLine(short.MaxValue);
// Console.WriteLine(short.MinValue); // 16
// Console.WriteLine();
// Console.WriteLine(int.MaxValue);
// Console.WriteLine(int.MinValue); // 32
// Console.WriteLine();
// Console.WriteLine(long.MaxValue);
// Console.WriteLine(long.MinValue); // 2^64



// Задача 28: Напишите программу, которая 
// принимает на вход число N и выдаёт 
// произведение чисел от 1 до N.
// 4 -> 24 
// 5 -> 120

// int ReadInt(string argument)

// int Factorial(int x)
// {
//     int fact = 1;
//     for(int i = 1; i < x; i++)
//     {
//         fact = fact * (i + 1);
//     }
//     return fact;
// }

// int x = ReadInt("Введите число: ");
// Console.WriteLine(Factorial(x));

// Задача 30: Напишите программу, которая 
// выводит массив из 8 элементов, заполненный 
// нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]