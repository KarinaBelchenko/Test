
//[345, 897, 568, 234] -> 2


//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

//[3, 7, 23, 12] -> 19

//[-4, -6, 89, 6] -> 0


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
int Length = array.Length;
    int index = 0;
    while (index < Length)


    array[index] = new Random().Next(1, 8);
    index++;
}
    

// 3. метод, подсчёта четных элементов
int CountIsEven(int[] collection)
{
  int result = 0;

  int size = collection.Length;
  int i = 0;
  while (i < size)
  {
    if (collection[i] % 2 == 0) result++;
    i++;
  }

  return result;
}
int[] Solution(int[] collectionElements, int evenCounts)
{

  int[] items = new int[evenCounts];
  int length = collectionElements.Length;
  int position = 0;
  int indexInItems = 0;
  while (position < length)
  {
    if (collectionElements[position] % 2 == 0)
    {
      items[indexInItems] = collectionElements[position];
      indexInItems++;
    }
    position++;
  }

  return items;
}

 // печать массива 
string PrintGood (int[] collection)
{
 int count = collection.Length;
 int i = 0; 
string result = "[ ";

while (i < count)
{
    result += ($"{collection[i], 3} ");
    i++;
}
return result + " ]";
}


int size = Convert.ToInt32(Console.ReadLine());
int countCollection = GetNumber("Введите количество эл массива: ");
int[] array = CreateArray(countCollection);
FillArray(array);
PrintGood(array);
int even = CountIsEven(array);
int[] newArr = Solution(arr, even);
Console.WriteLine(PrintGood(array));



int count = 0;

for (int z = 0; z < array.Length; z++)
if (array[z] % 2 == 0)
count++;

