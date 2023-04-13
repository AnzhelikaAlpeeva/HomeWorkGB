// Первая задача


// int random = new Random().Next(10, 100);
// Console.WriteLine(random);

// int first = random / 10;
// int second = random % 10;

// if (first > second)
// {
// 	Console.WriteLine(first);
// }
// else
// {
// 	Console.WriteLine(second);
// }

// Вторая задача
// Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98

// System.Console.WriteLine("Введите первое число: ");
// int number1 = int.Parse(Console.ReadLine());

// System.Console.WriteLine("Введите второе число: ");
// int number2 = int.Parse(Console.ReadLine());

// int ostatok = number1 % number2;

// if (ostatok == 0)
// {
//   Console.WriteLine($"Число {number2} кратно {number1}");
// }
// else
// {
//   Console.WriteLine($"Число {number2} не кратно {number1}");
//   Console.WriteLine($"Остаток : {ostatok}");
// }


// 3. Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого

// System.Console.WriteLine("Введите первое число: ");
// int number1 = int.Parse(Console.ReadLine());

// System.Console.WriteLine("Введите второе число: ");
// int number2 = int.Parse(Console.ReadLine());

// if (number1 == number2 * number2 || number2 == number1 * number1)
// {
//   System.Console.WriteLine("ДА");
// }
// else
// {
//   System.Console.WriteLine("НЕТ");
// }