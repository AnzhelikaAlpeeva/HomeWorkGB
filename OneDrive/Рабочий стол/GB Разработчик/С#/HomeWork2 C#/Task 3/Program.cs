// Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите цифру, которая обозначает день недели: ");
int numberDay = int.Parse(Console.ReadLine());
if (numberDay >= 1 && numberDay <=7) 
{
	if (numberDay >= 6) 
    {
		Console.WriteLine("Это выходной");
	} 
    else 
    {
		Console.WriteLine("Это рабочий день");
	}
} 
else 
{
	Console.Write("В неделе дней 7, вы набрали цифру не соответствующую условиям");
}