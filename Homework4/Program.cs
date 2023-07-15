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
// for (int i = 0; i < num; i++)
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






// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

// Вариант 1

// int a = Message ("Введите число");
// int b = Message ("Введите степень");
// if (Zero(b))
// {
//     System.Console.WriteLine(Sum(a,b));
// }

// int Message(string message)
// {
// Console.WriteLine(message);
// int result = Convert.ToInt32(Console.ReadLine());
// return result;
// }

// int Sum(int a, int b)
// {
// int result = 1;
// for (int i = 1; i <= b; i++)
// {
//     result = result * a;
// }
// return result;
// }

// bool Zero(int b)
// {
// if (b < 0)
// {
//     System.Console.WriteLine("Показатель не должен быть меньше нуля");
//     return false;
// }
// return true;
// }

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

// int Message(string message)
// {
// Console.WriteLine(message);
// int num = Convert.ToInt32(Console.ReadLine());
// return num;
// }

// int Sum(int num)
// {
// int sum = 0;
// for (int i = 0; i <= num; i++)
// {
//     sum = sum + num % 10;
//     num = num / 10;
// }
// return sum;
// }

// int num = Message("Введите число");
// System.Console.WriteLine(Sum(num));

// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

// int Message(string message)
// {
// Console.WriteLine(message);
// int result = Convert.ToInt32(Console.ReadLine());
// return result;
// }

// int [] Array(int Length)
// {
//     int [] array = new int [Length];
//     for (int i = 0; i < Length-1; i++)
// {
//     array[i] = Convert.ToInt32(Console.ReadLine());
// }
// return array;
// }

// void ArrayPrint(int[]array)
// {
// System.Console.Write("[ ");
// for (int i = 0; i < array.Length; i++)
// {
//     System.Console.Write(array[i] + " ");
// }
// System.Console.Write("]");
// }

// int length = Message ("Длинна массива");
// int aRRay = Message ("Введите числа массива");
// int [] array = Array (length);
// ArrayPrint(array);