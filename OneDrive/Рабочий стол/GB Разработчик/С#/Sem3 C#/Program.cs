// Задача первая: Напишите программу, которая принимает на вход координаты точки (x, y),
// при чем икс не равен нулю, игрик не равен нулю и выдает номер четверти плоскости в которой находится эта точка

// int x = ReadInt("X");
// int y = ReadInt("Y");

// if (IsCoordinatesCorrect(x, y))
// 	Console.WriteLine(GetQuarter(x, y));
// else
// 	Console.WriteLine("Ooops");


// int ReadInt(string argument)
// {
// 	Console.Write($"Input {argument}: ");

// 	int i;

// 	while (!int.TryParse(Console.ReadLine(), out i))
// 	{
// 		Console.WriteLine("It's not a number");
// 	}

// 	return i;
// }

// int GetQuarter(int x, int y)
// {
// 	if (x > 0 && y > 0)
// 	{
// 		return 1;
// 	}
// 	else if (x < 0 && y > 0)
// 	{
// 		return 2;
// 	}
// 	else if (x < 0 && y < 0)
// 	{
// 		return 3;
// 	}
// 	else
// 	{
// 		return 4;
// 	}
// }

// bool IsCoordinatesCorrect(int x, int y)
// {
// 	if (x == 0 || y == 0)
// 	{
// 		return false;
// 	}

// 	return true;
// }



// Задача вторая:  Напишите программу, которая по 
// заданному номеру четверти, показывает диапазон 
// возможных координат точек в этой четверти (x и y).

// System.Console.Write("число 1-4: ");
// int i;
// while (! int.TryParse(System.Console.ReadLine(), out i)){
//     System.Console.WriteLine("not number");
// };


// int Qad(int i){
//     switch(i){
//         case 1:{
//             System.Console.WriteLine("x & y -> [1, inf]");
//             break;
//         }
//         case 2:{
//             System.Console.WriteLine("x = [-inf, -1], y = [1, inf]");
//             break;
//         }
//         case 3:{
//             System.Console.WriteLine("x = [-inf, -1], y = [-1, -inf]");
//             break;
//         }
//         case 4:{
//             System.Console.WriteLine("x = [1, inf], y = [-1, -inf]");
//             break;
//         }
//         default:{
//             System.Console.WriteLine("такой четверти нет");
//             break;
//         }
//     }
//     return i;
// }

// Qad(i);



// Напишите программу, которая 
// принимает на вход координаты двух точек и 
// находит расстояние между ними в 2D 
// пространстве.
// A (3,6); B (2,1) -> 5,09 
// A (7,-5); B (1,-1) -> 7,21

// через картеж

// int ReadCordinat(string arg){ 
//     System.Console.WriteLine($"input {arg}");

//     int i;
//     while (! int.TryParse(System.Console.ReadLine(), out i)){
//         System.Console.WriteLine("not num");
//     }
//     return i;
// }

// var A = (x: ReadCordinat("X1"), y: ReadCordinat("Y1"));
// var B = (x: ReadCordinat("X2"), y: ReadCordinat("Y2"));

// double DistanceOf((int x, int y) A, (int x, int y) B){
//     double distans = Math.Sqrt(Math.Pow((A.x-B.x),2) + Math.Pow((A.y-B.y),2));
//     System.Console.WriteLine(distans);
//     return distans;
// }

// DistanceOf(A, B);

// !!!ВТОРОЙ ВАРИАНТ:

// Console.Write("Введите x1: ");
//     int x1 = int.Parse(Console.ReadLine());
//     //if (int.TryParse(text, out int number))

// Console.Write("Введите x2: ");
//     int x2 = int.Parse(Console.ReadLine());
//     //if (int.TryParse(text, out int number))

// Console.Write("Введите y1: ");
//     int y1 = int.Parse(Console.ReadLine());

// Console.Write("Введите y2: ");
//     int y2 = int.Parse(Console.ReadLine());
// Console.WriteLine(FindLehgth(x1, x2, y1, y2));
// double FindLehgth(int x1, int x2, int y1, int y2)
// {
// double result;
// result = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2));

// return result;
// }



// Задача. Напишите программу, которая 
// принимает на вход число (N) и выдаёт таблицу 
// квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4


// int a = ReadN("num: ");

// int ReadN(string a){
//     System.Console.WriteLine("введите число: ");

//     int i;
//     while(! int.TryParse(System.Console.ReadLine(), out i)){
//         System.Console.WriteLine("это не число, введи новое: ");
//     }
//     return i;
// }

// int[] Array(int a){

//     int[] arr = new int[a]; //пустой список [.., .., ..]
    
//     for (int i = 0; i < arr.Length; i++){
//         arr[i] = (int) Math.Pow(i, 2);
//     }
//     return arr;
// }

// System.Console.WriteLine(String.Join(", ", Array(a)));
