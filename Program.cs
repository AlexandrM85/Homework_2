//  Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую
//  цифру этого числа. Решаем с помощью "/" и "%", со строками не работаем
Console.WriteLine("--------------Задача №10.--------------");
int num = new Random().Next(100, 999);
int a = num%100;
int b = a/10;

Console.WriteLine($"Второй цифрой числа {num}, является {b} ");

// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.WriteLine("--------------Задача №13.--------------");
Console.Write("Введи число от 1 до 100000: ");
int number = int.Parse(Console.ReadLine()!);

if (number > 99 && number < 1000)
{
    int num1 = number%10;
    Console.WriteLine($"В числе {number} третья цифра {num1} ");
}

else

if (number > 999 && number < 10000)
{
    int num2 = number%100;
    int num3 = num2/10;
    Console.WriteLine($"В числе {number} третья цифра {num3} ");
}

else

if (number > 9999 && number <= 100000)
{
    int num4 = number%1000;
    int num5 = num4/100;
    Console.WriteLine($"В числе {number} третья цифра {num5} ");
}

else

if (number/100 == 0)
{
    Console.WriteLine($"В числе {number} третьей цифры нет ");
}

// Задача 15. Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
Console.WriteLine("--------------Задача №15.--------------");
Console.Write("Введите номер дня недели: ");
int numberWeekDay = int.Parse(Console.ReadLine()!);
switch (numberWeekDay)
{
    case 1: Console.WriteLine("Понедельник"); break;
    case 2: Console.WriteLine("Вторник"); break;
    case 3: Console.WriteLine("Среда"); break;
    case 4: Console.WriteLine("Четверг"); break;
    case 5: Console.WriteLine("Пятница"); break;
    case 6: Console.WriteLine("Суббота"); break;
    case 7: Console.WriteLine("Воскресенье"); break;
    default: Console.WriteLine("Такого дня недели не существует"); break;
}

if (numberWeekDay == 6 || numberWeekDay == 7)
{
    Console.WriteLine(" - это выходной день");
}