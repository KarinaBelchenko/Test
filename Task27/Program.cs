// Задача 29: Напишите методы, который задаёт массив из 8 элементов и выводит их на экран.


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

{
    array[index] = new Random().Next(1, 8);
    index++;
}

  }
 // печать массива 
void PrintArray (int[] collection)
{
    int count = collection.Length;
    for (int i = 0; i < count; i++)
{
Console.WriteLine($"{collection[i]} ");

}
Console.WriteLine(); 
}

int[] array = new int[8] {1, 2, 5, 7, 19, 6, 1, 33};

FillArray(array);
PrintArray(array);
