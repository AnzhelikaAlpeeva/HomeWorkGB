// Задача 31: Задайте массив из 12 элементов, заполненный 
// случайными числами из промежутка [-9, 9]. Найдите сумму 
// отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма 
// положительных чисел равна 29, сумма отрицательных равна 
// -20.

// void FillArray(int[] numbers) // метод заполнения
//             {
//                 Random rnd = new Random();

//                 for (int i = 0; i < numbers.Length; i++)
//                 {
//                     // [-9; 10)
//                     numbers[i] = rnd.Next(-9, 10);
//                 }

// void PrintArray(int[] numbers) // метод печати
//                 {
//                     for (int i = 0; i < numbers.Length; i++)
//                     {
//                         Console.Write($"{numbers[i]} ");
//                     }
//                     Console.WriteLine();
//                 }               
//             }
//  void Task1() // создание метода(функции)
//             {

//                 int size = 12;
//                 int[] number = new int[size];
//                 FillArray(number);
//                 PrintArray(number);
             
//             } // тело метода


//             Task1(); // вызов метода

// методы - процедуры (не возвращает результат) и функции (возвращает результат)




void FillArray(int[] numbers)
            {
                Random rnd = new Random();
                for (int i = 0; i < numbers.Length; i++)
                {
                    numbers[i] = rnd.Next(-9, 10);
                }
            }

            void PrintArray(int[] numbers)
            {
                for (int i = 0; i < numbers.Length; i++)
                {
                    Console.Write($"{numbers[i]} ");
                }
                Console.WriteLine();
            }

            int FindSumElements_Positive(int[] numbers)
            {
                int sum = 0;
                for (int i = 0; i < numbers.Length; i++)
                {
                    if (numbers[i] > 0)
                    {
                        sum += numbers[i];
                    }
                }
                return sum;
            }

            int FindSumElements_Negative(int[] numbers)
            {
                int sum = 0;
                for (int i = 0; i < numbers.Length; i++)
                {
                    if (numbers[i] < 0)
                    {
                        sum += numbers[i];
                    }
                }
                return sum;
            }

            //Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9].
            //Найдите сумму отрицательных и положительных элементов массива.
            // void Task1()
            // {
            //     int size = 12;
            //     int[] numbers = new int[size];
            //     FillArray(numbers);
            //     PrintArray(numbers);
            //     int summa = FindSumElements_Positive(numbers);
            //     Console.WriteLine($"Сумма положительных элементов массива равна {summa}");

            //     Console.WriteLine($"Сумма отрицательных элементов массива равна {FindSumElements_Negative(numbers)}");
                
            // }

            // // методы -> процедуры (не возвращают результат) и функции (возвращают результат)
            // Task1();


// Задача 32: Напишите программу замены элементов 
// массива: положительные элементы замените на 
// соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]
            void Task2()
            {
                int size = 4;
                int[] numbers = new int[size];
                FillArray(numbers);
                PrintArray(numbers);
                int summa = FindSumElements_Positive(numbers);
            }

            // методы -> процедуры (не возвращают результат) и функции (возвращают результат)
            Task2();

// int[] ChangeArray()
// {
//     int size = ReadInt("число размера массива");
//     int[] array = RandomArray(size);

//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] *= -1;
//     }
//     PrintArrayTask32(array);
//     return array;
// }






// Задача 33: Задайте массив. Напишите программу, которая 
// определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да

void Task3()
            {
                int size = 6;
                int[] numbers = new int[size];
                FillArray(numbers);
                PrintArray(numbers);
            }
Task3();