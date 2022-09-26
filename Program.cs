/*Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1
Console.WriteLine("Введите число");
int number = int.Parse(Console.ReadLine());
int num1 = number % 100; 
int num2 = number / 10;
int num3 = num2 % 10;
Console.WriteLine(num3);*/

/*Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
Console.WriteLine("Введите число");
int number = int.Parse(Console.ReadLine());
int 

Console.WriteLine(num2);*/



/*Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет

Console.WriteLine("введите число");
int number = int.Parse(Console.ReadLine());
if (number == 1)
{
    Console.WriteLine("Сегодня Понедельник");
}
    if (number == 2)
    {
       Console.WriteLine("Сегодня Вторник"); 
    }
    if (number == 3)
    {
        Console.WriteLine("Сегодня Среда");
    }
    if (number == 4)
    {
        Console.WriteLine("Сегодня Четверг");
    }
     if (number == 5)
    {
        Console.WriteLine("Сегодня Пятница");
    }
     if (number == 6)
    {
        Console.WriteLine("Сегодня Суббота");
    }
     if (number == 7)
    {
        Console.WriteLine("Сегодня Воскресенье");
    }
        if ((number == 6) || (number == 7))
        {
            Console.WriteLine("Сегодня Выходной");
        }
        else
        {
             Console.WriteLine("Сегодня Будний день");
        }*/