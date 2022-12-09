// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

int value = 645; 
int a = value / 100;
int b = (value / 10) % 10 ;
int C = value % 10;
Console.WriteLine(C);

int value1 = 78; 
int a1 = value1 / 100;
int b1 = (value1 / 10) % 10 ;
int C1 = value1 % 10;
Console.WriteLine("Имя С1 не сушествует");


int value2 = 32679;
int buf = value2;
int ing = 0;

do {buf = buf / 10;
    
    ing++;
  
    Console.WriteLine(buf>=1);
    }
  

