﻿// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

// Console.WriteLine("Введите трехзначное число");
// int num = Convert.ToInt32(Console.ReadLine());
// int sec = (num/10)%10;
// Console.WriteLine(sec);

// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

// Console.WriteLine("Введите число");
// int num = Convert.ToInt32(Console.ReadLine());

// if (num < 100)
// {
//     Console.WriteLine("Третьей цифры нет");
// }
// else {
//    while (num >= 1000)
// {
//     num = num/10;
// }
// num = num%10;
// Console.WriteLine(num);
// }

// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

// Console.WriteLine("Введите число");
// int day = Convert.ToInt32(Console.ReadLine());
// int working = 1; 
// int off = 5;
// int stop = 7;

// if (day >= working && day <= off)
//     Console.WriteLine("нет");

// else if (day > working && day > off && day <= stop )
//     Console.WriteLine("да");

// else if (day > stop)
//     Console.WriteLine($"В неделе 7 дней, а не {day}!");