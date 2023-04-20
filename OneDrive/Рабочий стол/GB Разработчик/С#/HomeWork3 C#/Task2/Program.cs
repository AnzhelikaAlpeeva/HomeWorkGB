// Напишите программу, которая принимает на вход координаты двух точек и
// находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

int ReadCordinat(string arg)
{ 
    Console.WriteLine($"Введите {arg}");
    int i;
    while (! int.TryParse(Console.ReadLine(), out i))
    {
        Console.WriteLine("нет значения");
    }
    return i;
}

var A = (x: ReadCordinat("X1"), y: ReadCordinat("Y1"), ReadCordinat("Z1"));
var B = (x: ReadCordinat("X2"), y: ReadCordinat("Y2"), ReadCordinat("Z2"));

double DistanceOf((int x, int y, int z) A, (int x, int y, int z) B)
{
    double distans = Math.Sqrt(Math.Pow((A.x-B.x),2) + Math.Pow((A.y-B.y),2) + Math.Pow((A.z-B.z),2));
    Console.WriteLine(distans);
    return distans;
}

DistanceOf(A, B);




