// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементами массива.
// [3,21 7,04 22,93 -2,71 78,24] -> 80,95

double[] Array = {3.21, 7.04, 22.93, -2.71, 78.24};

double diff(double[] Array)
{
    double minArr = Array[0];
    double maxArr = Array[0];
    for(int i = 1; i < Array.Length; i++)
    {
            if (Array[i] < minArr)
        {
            minArr = Array[i];
        }
        if (Array[i] > maxArr)
        {
            maxArr = Array[i];
        }
    }    
    return maxArr-minArr; 
}

Console.WriteLine($"Разница между минимальным и максимальным значением массива: {diff(Array)}");

