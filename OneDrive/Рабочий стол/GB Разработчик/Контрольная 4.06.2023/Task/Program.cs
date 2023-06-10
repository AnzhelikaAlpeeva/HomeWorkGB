// Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

string[] stringArray = {"hello", "2", "world", ":-)"};

void printArray(string [] stringArray)
{
    Console.Write("[");
    for (int i = 0;i<stringArray.Length;i++)
    {
    Console.Write($"'{stringArray[i]}', ");
    }
    Console.Write("]");
}

string [] element(string [] stringArray)
{
  int n = 0;
  for (int i = 0; i < stringArray.Length; i++)
  {
    if(stringArray[i].Length <= 3)
    n++;
  }
string [] result = new string [n];
int j = 0;
  for (int i = 0; i < stringArray.Length; i++)
  {
    if(stringArray[i].Length <=3)
    {
        result[j] = stringArray[i];
        j++;
    }
  }
  return result;
}

printArray(element(stringArray));







