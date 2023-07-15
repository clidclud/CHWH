// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

// Вариант 1

// int Result()
// {
// Console.WriteLine("Введите число");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите степень");
// int b = Convert.ToInt32(Console.ReadLine());
// int result = 1;
// for (int i = 1; i <= b; i++)
// {
//     result = result * a;
// }
// return result;
// }
// Console.WriteLine(Result());

// Вариант 2
// Result();
// void Result()
// {
// Console.WriteLine("Введите число");
// double a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите степень");
// double b = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(Math.Pow(a,b));
// }

// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

// Sum();
// void Sum()
// {
// Console.WriteLine("Введите число");
// int num = Convert.ToInt32(Console.ReadLine());
// int num2 = num;
// int count = 0;
// while(num2 > 0)
// {
//     num2 = num2/10;
//     count++;
// }
// int sum = 0;
// for (int i = 0; i < count; i++)
// {
//     sum = sum + num % 10;
//     num = num / 10;
// }
// System.Console.WriteLine(sum);
// }

// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

// Array();
// void Array()
// {
// Console.WriteLine("Введите 8 чисeл");
// int [] array = new int[8];
// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = Convert.ToInt32(Console.ReadLine());
// }
// for (int i = 0; i < array.Length; i++)
// {
//     System.Console.Write(array[i] + " ");
// }
// }