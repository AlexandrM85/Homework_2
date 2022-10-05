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