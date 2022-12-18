//Задайте массив заполненный случайными положительными трехзначными числами.
// Напишите программу, которая покажет количество четных чисел в массиве.


Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];
FillArray(numbers);
Console.WriteLine("Вот наш массив: ");
PrintGood (numbers);

int count = 0;

for (int z = 0; z < numbers.Length; z++)
if (numbers[z] % 2 == 0)
count++;

Console.WriteLine($"всего {numbers.Length} чисел, {count} из них чётные");


// 0. Метод, считывающий число от пользователя из консоли
int GetNumber(string text)
{
  Console.Write(text);
  int value = int.Parse(Console.ReadLine()!);
  return value;
}

// 1. метод, создающий массив с указанным количеством эл.
int[] CreateArray(int count)
{
  return new int[count];
}

int[] arr = CreateArray(new int{});

// метод заполнякт массив
    
void FillArray(int[] array)
{
  int size = array.Length;

  int index = 0;
  while (index < size)
  {
    array[index] = GetNumber($"array[{index}]: ");
    index++;
  }
}

 // печать массива 
string PrintGood (int[] numbers)
{
 int count = numbers.Length;
 int i = 0; 
string result = "[ ";

while (i < count)
{
    result += ($"{numbers[i], 3} ");
    i++;
}
return result + " ]";
}





