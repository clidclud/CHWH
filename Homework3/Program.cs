// Урок 3. Базовые алгоритмы. Продолжение

// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

// System.Console.WriteLine("Введите пятизначное число");
// int num = Convert.ToInt32(Console.ReadLine());

// while (num > 100000)
// {
//     System.Console.WriteLine("Введите пятизначное число");
//     num = Convert.ToInt32(Console.ReadLine());
// }

// int a = num / 10000;
// int a1 = num % 10;
// int b = num / 1000 % 10;
// int b1 = num / 10 % 10;
 
// if (a == a1 && b == b1)   
// {
//     System.Console.WriteLine("Да");
// }
// else
// System.Console.WriteLine("Нет");

// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

// System.Console.WriteLine("Введите кардинату Х1");
// int X1 = Convert.ToInt32(System.Console.ReadLine());
// System.Console.WriteLine("Введите кардинату Y1");
// int Y1 = Convert.ToInt32(System.Console.ReadLine());
// System.Console.WriteLine("Введите кардинату Z1");
// int Z1 = Convert.ToInt32(System.Console.ReadLine());
// System.Console.WriteLine("Введите кардинату Х2");
// int X2 = Convert.ToInt32(System.Console.ReadLine());
// System.Console.WriteLine("Введите кардинату Y2");
// int Y2 = Convert.ToInt32(System.Console.ReadLine());
// System.Console.WriteLine("Введите кардинату Z2");
// int Z2 = Convert.ToInt32(System.Console.ReadLine());
// double result = Math.Sqrt(Math.Pow((X2-X1),2) + Math.Pow((Y2-Y1),2) + Math.Pow((Z2-Z1),2));
// System.Console.WriteLine(result);

// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

// System.Console.WriteLine("Введите число");
// int num = Convert.ToInt32(Console.ReadLine());
// for(int i=1; i<=num; i++)
// {
//     System.Console.WriteLine(Math.Pow(i,3));
// }